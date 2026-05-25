using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Student_Record_System

{
    public partial class Form1 : Form
    {
        private string connString = "server=localhost;port=3306;username=root;password=sql123;database=StudentRecordDB";
        public Form1()
        {
            InitializeComponent();
            LoadStudentRecords();
            this.Shown += new EventHandler(Form1_Shown);

        }
        private void ExportGridToCSV(DataGridView dgv, string fileName)
        {
            try
            {
                // Build the CSV string content area safely using a StringBuilder
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                // 1. EXTRACT HEADERS: Filter out hidden columns and assemble the top row
                var validColumns = dgv.Columns.Cast<DataGridViewColumn>()
                    .Where(col => col.Visible)
                    .OrderBy(col => col.DisplayIndex)
                    .ToList();

                string headerLine = string.Join(",", validColumns.Select(col => $"\"{col.HeaderText.Replace("\"", "\"\"")}\""));
                sb.AppendLine(headerLine);

                // 2. EXTRACT ROWS: Iterates exactly down your aligned rows grid setup
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the blank input line if present

                    string rowLine = string.Join(",", validColumns.Select(col =>
                    {
                        object cellValue = row.Cells[col.Index].Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";

                        // Escape inner quotation marks to prevent format breaks in Excel
                        return $"\"{cellText.Replace("\"", "\"\"")}\"";
                    }));

                    sb.AppendLine(rowLine);
                }

                // 3. WRITE FILE: Save the text block physically to the user's computer disk storage
                File.WriteAllText(fileName, sb.ToString(), System.Text.Encoding.UTF8);

                MessageBox.Show("Student database successfully exported to CSV format!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsDuplicateExcludingSelf(string columnName, string value, string currentId = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    // If checking during an Update, exclude the current student's ID from the search
                    string query = string.IsNullOrEmpty(currentId)
                        ? $"SELECT COUNT(*) FROM students WHERE {columnName} = @value"
                        : $"SELECT COUNT(*) FROM students WHERE {columnName} = @value AND student_id != @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", value);
                        if (!string.IsNullOrEmpty(currentId))
                        {
                            cmd.Parameters.AddWithValue("@id", currentId);
                        }

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Returns true if a duplicate is found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking duplicates: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadStudentRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT student_id AS 'Student ID', full_name AS 'Full Name', date_of_birth AS 'Date of Birth', " +
                                   "gender AS 'Gender', course AS 'Course', year_level AS 'Year', email AS 'Email', phone AS 'Phone' FROM students";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvStudents.DataSource = null;
                            dgvStudents.Columns.Clear();

                            DataGridViewTextBoxColumn countColumn = new DataGridViewTextBoxColumn();
                            countColumn.Name = "No";
                            countColumn.HeaderText = "#";
                            dgvStudents.Columns.Add(countColumn);

                            dgvStudents.DataSource = dt;

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dgvStudents.Rows[i].Cells["No"].Value = (i + 1).ToString();
                            }

                            // 1. Force structural sizing calculations to Fill mode first
                            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            // 2. Adjust weights to shift Year left and balance spacing
                            for (int i = 0; i < dgvStudents.Columns.Count; i++)
                            {
                                DataGridViewColumn col = dgvStudents.Columns[i];
                                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                                if (col.Name == "No") { col.FillWeight = 35; }
                                else if (col.HeaderText == "Student ID") { col.FillWeight = 115; }
                                else if (col.HeaderText == "Full Name") { col.FillWeight = 180; }
                                else if (col.HeaderText == "Date of Birth") { col.FillWeight = 110; }
                                else if (col.HeaderText == "Gender") { col.FillWeight = 75; }

                                // Increased Course to push Year away from Email
                                else if (col.HeaderText == "Course") { col.FillWeight = 110; }
                                else if (col.HeaderText == "Year") { col.FillWeight = 75; }

                                // Normalized Email since it's now center-aligned
                                else if (col.HeaderText == "Email") { col.FillWeight = 165; }
                                else if (col.HeaderText == "Phone") { col.FillWeight = 115; }
                            }

                            // 3. Update alignments: Move Email to Center alignment alongside Year and Course
                            for (int i = 0; i < dgvStudents.Columns.Count; i++)
                            {
                                DataGridViewColumn col = dgvStudents.Columns[i];

                                if (col.HeaderText == "Full Name")
                                {
                                    // Left-align only the Full Name column for natural reading
                                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                }
                                else
                                {
                                    // Centers everything else perfectly, including Email and Year
                                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                }
                            }

                            dgvStudents.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text)) return;

            txtStudentID.TextChanged -= txtStudentID_TextChanged;

            int selectionStart = txtStudentID.SelectionStart;
            int oldLength = txtStudentID.Text.Length;
            string input = txtStudentID.Text.ToUpper();
            string cleanDigits = "";

            // Clean string values, strictly matching digits
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= input.Length - 4 && input.Substring(i, 4) == "-SM-")
                {
                    i += 3;
                    continue;
                }
                if (i <= input.Length - 2 && input.Substring(i, 2) == "SM")
                {
                    i += 1;
                    continue;
                }
                if (input[i] == '-') continue;

                if (char.IsDigit(input[i]))
                {
                    cleanDigits += input[i];
                }
            }

            // Enforce data safety rules upon pasted data modifications 
            if (cleanDigits.Length > 0 && cleanDigits[0] != '2') cleanDigits = cleanDigits.Remove(0, 1);
            if (cleanDigits.Length > 1 && cleanDigits[1] != '0') cleanDigits = cleanDigits.Remove(1, 1);

            string formatted = "";

            if (cleanDigits.Length > 0)
            {
                formatted += cleanDigits.Substring(0, Math.Min(cleanDigits.Length, 4));
            }

            if (cleanDigits.Length > 4 || (cleanDigits.Length == 4 && input.Length > 4 && input.Contains("-")))
            {
                formatted += "-";
                if (cleanDigits.Length > 4)
                {
                    formatted += cleanDigits.Substring(4, Math.Min(cleanDigits.Length - 4, 5));
                }
            }

            int middleEndIndex = formatted.Length;

            if (cleanDigits.Length > 9 || (cleanDigits.Length == 9 && input.Length > middleEndIndex))
            {
                formatted += "-SM-";
                if (cleanDigits.Length > 9)
                {
                    // Truncate pasted values to a max of 6 for the final digit sequence position
                    char finalDigit = cleanDigits[9];
                    int finalValue = (int)char.GetNumericValue(finalDigit);
                    if (finalValue > 6) finalDigit = '6';

                    formatted += finalDigit;
                }
            }

            txtStudentID.Text = formatted;
            int lengthDiff = txtStudentID.Text.Length - oldLength;
            txtStudentID.SelectionStart = Math.Max(0, Math.Min(selectionStart + lengthDiff, txtStudentID.Text.Length));

            txtStudentID.TextChanged += txtStudentID_TextChanged;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Allow control keys like Backspace, Delete, Copy, Paste, etc.
            if (char.IsControl(e.KeyChar)) return;

            // 2. Allow manual structural dashes (-)
            if (e.KeyChar == '-') return;

            string currentText = txtStudentID.Text;
            int selectionStart = txtStudentID.SelectionStart;

            // 3. Rule: Check numeric entry parameters
            if (char.IsDigit(e.KeyChar))
            {
                // Enforce that the first digit MUST be '2'
                if (selectionStart == 0 && e.KeyChar != '2')
                {
                    e.Handled = true;
                    return;
                }
                // Enforce that the second digit MUST be '0'
                if (selectionStart == 1 && e.KeyChar != '0')
                {
                    e.Handled = true;
                    return;
                }
                // Enforce that the third digit MUST be '0', '1', or '2'
                if (selectionStart == 2 && e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2')
                {
                    e.Handled = true; // Reject if 3rd char isn't 0, 1, or 2
                    return;
                }

                // Rule: Restrict the final digit after -SM- to be ONLY between 0 and 6
                if (currentText.Contains("-SM-"))
                {
                    int smIndex = currentText.IndexOf("-SM-");
                    // If the user's cursor is placed right after the "-SM-" block
                    if (selectionStart >= smIndex + 4)
                    {
                        int digitValue = (int)char.GetNumericValue(e.KeyChar);
                        if (digitValue < 0 || digitValue > 6)
                        {
                            e.Handled = true; // Reject if number is 7, 8, or 9
                            return;
                        }
                    }
                }
                return; // Allow compliant numbers
            }

            // 4. Allow 'S' or 'M' (case-insensitive) ONLY if enough numbers are present
            char upperChar = char.ToUpper(e.KeyChar);
            if (upperChar == 'S' || upperChar == 'M')
            {
                int numericCount = currentText.Count(char.IsDigit);
                if (numericCount >= 9) return;
            }

            // Reject everything else (letters, symbols, spaces)
            e.Handled = true;
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                string text = txtStudentID.Text;
                int selectionStart = txtStudentID.SelectionStart;

                if (text.Contains("-SM-"))
                {
                    int smIndex = text.IndexOf("-SM-");
                    if (selectionStart > smIndex && selectionStart <= smIndex + 4)
                    {
                        // Delete the numeric digit right before "-SM-" to step backward smoothly
                        txtStudentID.Text = text.Remove(smIndex - 1, 1);
                        txtStudentID.SelectionStart = smIndex - 1;
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text)) return;

            // Temporarily detach event to prevent an infinite loop during casing adjustment
            txtFullName.TextChanged -= txtFullName_TextChanged;

            int selectionStart = txtFullName.SelectionStart;

            // Capitalize the first letter of each word (Title Case)
            string currentText = txtFullName.Text;
            txtFullName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(currentText);

            // Keep cursor exactly where the user was typing
            txtFullName.SelectionStart = selectionStart;

            // Re-attach event handler
            txtFullName.TextChanged += txtFullName_TextChanged;

            // --- YOUR FILTER LOGIC HERE ---
            // You can use txtFullName.Text to filter your data grid or database rows as the user types.
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Allow control keys like Backspace, Delete, Copy, Paste
            if (char.IsControl(e.KeyChar)) return;

            // 2. Allow letters and spaces, but block consecutive double spaces
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
            {
                if (e.KeyChar == ' ' && txtFullName.Text.EndsWith(" "))
                {
                    e.Handled = true; // Reject a second space in a row
                }
                return;
            }

            // 3. Reject numbers and symbols completely
            e.Handled = true;
        }

        // Place this at the bottom of your Form1.cs file, outside of the Form1 class
        public class CourseItem
        {
            public string Initials { get; set; }
            public string FullName { get; set; }

            public CourseItem(string initials, string fullName)
            {
                Initials = initials;
                FullName = fullName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ReadOnly = true;

            // Column Header Default Styles
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 0, 0);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudents.ColumnHeadersHeight = 40;

            // Row Content Styling
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.GridColor = Color.FromArgb(240, 240, 240);
            dgvStudents.DefaultCellStyle.BackColor = Color.White;
            dgvStudents.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvStudents.RowTemplate.Height = 35;

            // Selection Highlight Styling
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 220, 220);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 0, 0);

            // Visual Cleanups
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.ScrollBars = ScrollBars.Both;

            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 0, 0);
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvStudents.AllowUserToAddRows = false;

            dtpDOB.MinDate = new DateTime(1901, 1, 1);
            dtpDOB.MaxDate = new DateTime(2015, 12, 31);

            List<CourseItem> courses = new List<CourseItem>
    {
        new CourseItem("BSA", "BSA Bachelor of Science in Accountancy"),
        new CourseItem("BSCpE", "BSCpE Bachelor of Science in Computer Engineering"),
        new CourseItem("BSIT", "BSIT Bachelor of Science in Information Technology"),
        new CourseItem("BSENTREP", "BSENTREP Bachelor of Science in Entrepreneurship"),
        new CourseItem("BSHM", "BSHM Bachelor of Science in Hospitality Management"),
        new CourseItem("BSEDEN", "BSEDEN Bachelor of Secondary Education major in English"),
        new CourseItem("BSEDMT", "BSEDMT Bachelor of Secondary Education major in Mathematics"),
        new CourseItem("DOMT", "DOMT Diploma in Office Management Technology")
    };

            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "FullName";
            cmbCourse.ValueMember = "Initials";

            cmbCourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourse.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbCourse.SelectedIndex = -1;
            LoadStudentRecords();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Allow control keys like Backspace, Delete, Copy, Paste
            if (char.IsControl(e.KeyChar)) return;

            // 2. Strict Character Block: Emails can NEVER contain spaces
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                return;
            }

            // 3. Prevent duplicate '@' symbols
            if (e.KeyChar == '@' && txtEmail.Text.Contains("@"))
            {
                e.Handled = true;
                return;
            }

            // 4. Standard Allowed Characters: Letters, digits, and basic email symbols
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-')
            {
                return;
            }

            // Reject all other special characters (e.g., #, $, %, !, commas, brackets)
            e.Handled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Convert text to lowercase automatically as they type (standard for emails)
            txtEmail.TextChanged -= txtEmail_TextChanged;
            int selectionStart = txtEmail.SelectionStart;

            txtEmail.Text = txtEmail.Text.ToLower();

            txtEmail.SelectionStart = selectionStart;
            txtEmail.TextChanged += txtEmail_TextChanged;

            // --- YOUR DYNAMIC SEARCH FILTER HERE ---
            // string searchEmail = txtEmail.Text.Trim();
            // studentBindingSource.Filter = $"Email LIKE '%{searchEmail}%'";
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                // Standard regular expression pattern for valid email structures
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }



        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Allow control keys like Backspace or Delete
            if (char.IsControl(e.KeyChar)) return;

            // 2. Only allow numbers (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                string currentText = txtPhone.Text;
                int selectionStart = txtPhone.SelectionStart;

                // Rule: The very first digit typed MUST be a '0'
                if (selectionStart == 0 && e.KeyChar != '0')
                {
                    e.Handled = true; // Reject if it doesn't start with 0
                    return;
                }

                // Rule: The second digit typed MUST be a '9' (Since PH mobile prefixes start with 09)
                if (selectionStart == 1 && e.KeyChar != '9')
                {
                    e.Handled = true; // Reject if it isn't 09
                    return;
                }

                return; // Allow compliant numbers
            }

            // Reject all letters, spaces, or special symbols
            e.Handled = true;
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            // Prevent getting stuck on structural dashes when backspacing
            if (e.KeyCode == Keys.Back)
            {
                string text = txtPhone.Text;
                int selectionStart = txtPhone.SelectionStart;

                // If backspacing a dash (e.g. at position 5 or 9), delete it and the number before it
                if (selectionStart > 0 && text[selectionStart - 1] == '-')
                {
                    txtPhone.Text = text.Remove(selectionStart - 2, 2);
                    txtPhone.SelectionStart = selectionStart - 2;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text)) return;

            // Temporarily detach event to prevent infinite loops during formatting
            txtPhone.TextChanged -= txtPhone_TextChanged;

            int selectionStart = txtPhone.SelectionStart;
            int oldLength = txtPhone.Text.Length;

            // 1. Extract ONLY the digits
            string cleanDigits = new string(txtPhone.Text.Where(char.IsDigit).ToArray());

            // 2. Dynamic Mask Construction (Format: 09XX-XXX-XXXX)
            string formatted = "";

            if (cleanDigits.Length > 0)
            {
                // First 4 digits (e.g., 0917)
                formatted += cleanDigits.Substring(0, Math.Min(cleanDigits.Length, 4));
            }
            if (cleanDigits.Length > 4)
            {
                // Dash + next 3 digits (e.g., -123)
                formatted += "-" + cleanDigits.Substring(4, Math.Min(cleanDigits.Length - 4, 3));
            }
            if (cleanDigits.Length > 7)
            {
                // Dash + final 4 digits (e.g., -4567)
                formatted += "-" + cleanDigits.Substring(7, Math.Min(cleanDigits.Length - 7, 4));
            }

            // 3. Update Textbox control text safely
            txtPhone.Text = formatted;

            // 4. Restore cursor position smoothly
            int lengthDiff = txtPhone.Text.Length - oldLength;
            txtPhone.SelectionStart = Math.Max(0, Math.Min(selectionStart + lengthDiff, txtPhone.Text.Length));

            // Re-attach event handler
            txtPhone.TextChanged += txtPhone_TextChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation dialog check
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record permanently?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "DELETE FROM students WHERE student_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtStudentID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentRecords();
                            ClearFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ============================================================
            // 1. INDIVIDUAL EMPTY FIELD & FORMAT VALIDATIONS
            // ============================================================

            string studentIdInput = txtStudentID.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentIdInput))
            {
                MessageBox.Show("Student ID field cannot be left blank.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return;
            }

            // STRICT FORMAT VALIDATION: Enforces YYYY-XXXXX-CC-N pattern (e.g., 2024-00174-SM-0)
            string idPattern = @"^\d{4}-\d{5}-[A-Za-z]{2}-\d$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(studentIdInput, idPattern))
            {
                MessageBox.Show("Invalid Student ID format!\n\nThe ID must match the official pattern: YYYY-XXXXX-CC-N\nExample: 2024-00174-SM-0",
                                "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name field cannot be left blank.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid option for Gender.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.DroppedDown = true;
                return;
            }

            if (cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Academic Course.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCourse.DroppedDown = true;
                return;
            }

            if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Year Level.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYear.DroppedDown = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email Address field cannot be left blank.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number field cannot be left blank.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // ============================================================
            // 2. EMAIL FORMAT REGEX VALIDATION
            // ============================================================
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("The email address structure you entered is invalid.\nPlease use a proper format (e.g., student@email.com).", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // ============================================================
            // 3. SEPARATE DATABASE DUPLICATE CHECKS
            // ============================================================
            if (IsDuplicateExcludingSelf("student_id", studentIdInput))
            {
                MessageBox.Show("This Student ID is already assigned to an existing record.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateExcludingSelf("full_name", txtFullName.Text.Trim()))
            {
                MessageBox.Show("A student with this Full Name already exists in the records.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateExcludingSelf("email", txtEmail.Text.Trim()))
            {
                MessageBox.Show("This Email Address is already registered to another student.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateExcludingSelf("phone", txtPhone.Text.Trim()))
            {
                MessageBox.Show("This Phone Number is already registered to another student.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ============================================================
            // 4. DATABASE INSERT OPERATION
            // ============================================================
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO students (student_id, full_name, date_of_birth, gender, course, year_level, email, phone) " +
                                   "VALUES (@id, @name, @dob, @gender, @course, @year, @email, @phone)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentIdInput.ToUpper());
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@course", cmbCourse.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@year", cmbYear.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadStudentRecords();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensures user didn't click header row
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // Safely map data fields by their Column Header Names
                txtStudentID.Text = row.Cells["Student ID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["Full Name"].Value?.ToString() ?? "";

                var dobValue = row.Cells["Date of Birth"].Value;
                if (dobValue != null && dobValue != DBNull.Value)
                {
                    dtpDOB.Value = Convert.ToDateTime(dobValue);
                }
                else
                {
                    dtpDOB.Value = new DateTime(2000, 1, 1); // Your safe constraint fallback date
                }

                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
                cmbYear.SelectedItem = row.Cells["Year"].Value?.ToString();

                if (row.Cells["Course"].Value != null)
                {
                    cmbCourse.SelectedValue = row.Cells["Course"].Value.ToString();
                }
                else
                {
                    cmbCourse.SelectedIndex = -1;
                }

                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure a student record is selected
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Input Validation: Check for empty values
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || cmbGender.SelectedIndex == -1 ||
                cmbCourse.SelectedIndex == -1 || cmbYear.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentStudentId = txtStudentID.Text.Trim();

            // 4. Duplicate Validation: Separate checks excluding the student's own record
            if (IsDuplicateExcludingSelf("full_name", txtFullName.Text.Trim(), currentStudentId))
            {
                MessageBox.Show("Another student with this exact Full Name already exists.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateExcludingSelf("email", txtEmail.Text.Trim(), currentStudentId))
            {
                MessageBox.Show("This Email Address is already taken by another student record.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDuplicateExcludingSelf("phone", txtPhone.Text.Trim(), currentStudentId))
            {
                MessageBox.Show("This Phone Number is already in use by another student record.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Update Record in Database
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE students SET full_name=@name, date_of_birth=@dob, gender=@gender, " +
                                   "course=@course, year_level=@year, email=@email, phone=@phone WHERE student_id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", currentStudentId);
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@course", cmbCourse.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@year", cmbYear.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadStudentRecords();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentRecords(); // Reloads data from database
            ClearFields();
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            dtpDOB.Value = new DateTime(2000, 1, 1);
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // 1. Force the active cursor focus away from the grid so it doesn't highlight anything on startup
            this.ActiveControl = null;

            // 2. Clear any automatic cell selections
            dgvStudents.ClearSelection();

            // 3. Kill the internal cell pointer that causes the blue box on the header
            dgvStudents.CurrentCell = null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Ensure there is actual data inside the grid to prevent empty text downloads
            if (dgvStudents.Rows.Count == 0)
            {
                MessageBox.Show("There are no student records currently loaded to export.", "Empty Grid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"Student_Records_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.Title = "Save Student Database Export";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Triggers the background builder loop using the selected target path location
                    ExportGridToCSV(dgvStudents, sfd.FileName);
                }
            }
        }
    }
}
