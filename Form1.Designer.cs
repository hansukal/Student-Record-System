namespace Student_Record_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            roundedGroupBox1 = new RoundedGroupBox();
            txtPhone = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            txtStudentID = new TextBox();
            label10 = new Label();
            cmbYear = new ComboBox();
            label9 = new Label();
            txtFullName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            dtpDOB = new DateTimePicker();
            cmbCourse = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            cmbGender = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new RoundedButton();
            btnUpdate = new RoundedButton();
            btnDelete = new RoundedButton();
            btnRefresh = new RoundedButton();
            dgvStudents = new DataGridView();
            roundedGroupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // roundedGroupBox1
            // 
            roundedGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedGroupBox1.BackColor = Color.Transparent;
            roundedGroupBox1.BorderColor = Color.FromArgb(74, 0, 0);
            roundedGroupBox1.BorderThickness = 2;
            roundedGroupBox1.Controls.Add(txtPhone);
            roundedGroupBox1.Controls.Add(label11);
            roundedGroupBox1.Controls.Add(txtEmail);
            roundedGroupBox1.Controls.Add(txtStudentID);
            roundedGroupBox1.Controls.Add(label10);
            roundedGroupBox1.Controls.Add(cmbYear);
            roundedGroupBox1.Controls.Add(label9);
            roundedGroupBox1.Controls.Add(txtFullName);
            roundedGroupBox1.Controls.Add(label4);
            roundedGroupBox1.Controls.Add(label5);
            roundedGroupBox1.Controls.Add(label8);
            roundedGroupBox1.Controls.Add(dtpDOB);
            roundedGroupBox1.Controls.Add(cmbCourse);
            roundedGroupBox1.Controls.Add(label7);
            roundedGroupBox1.Controls.Add(label6);
            roundedGroupBox1.Controls.Add(cmbGender);
            roundedGroupBox1.CornerRadius = 15;
            roundedGroupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roundedGroupBox1.ForeColor = Color.White;
            roundedGroupBox1.HeaderTextColor = Color.Maroon;
            roundedGroupBox1.HeaderTextPaddingLeft = 35;
            roundedGroupBox1.Location = new Point(32, 143);
            roundedGroupBox1.Name = "roundedGroupBox1";
            roundedGroupBox1.Size = new Size(1579, 314);
            roundedGroupBox1.TabIndex = 0;
            roundedGroupBox1.TabStop = false;
            roundedGroupBox1.Text = "Student Details";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPhone.ForeColor = Color.Maroon;
            txtPhone.Location = new Point(982, 258);
            txtPhone.MaximumSize = new Size(200, 31);
            txtPhone.MaxLength = 13;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 31);
            txtPhone.TabIndex = 17;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyDown += txtPhone_KeyDown;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(89, 53);
            label11.Margin = new Padding(23, 10, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(140, 31);
            label11.TabIndex = 5;
            label11.Text = "Student ID :";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Maroon;
            txtEmail.Location = new Point(982, 193);
            txtEmail.MaximumSize = new Size(374, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 31);
            txtEmail.TabIndex = 16;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtStudentID.ForeColor = Color.Maroon;
            txtStudentID.Location = new Point(254, 53);
            txtStudentID.Margin = new Padding(3, 10, 3, 3);
            txtStudentID.MaximumSize = new Size(230, 31);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "ex. 2024-00174-SM-0";
            txtStudentID.ShortcutsEnabled = false;
            txtStudentID.Size = new Size(230, 31);
            txtStudentID.TabIndex = 3;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            txtStudentID.KeyDown += txtStudentID_KeyDown;
            txtStudentID.KeyPress += txtStudentID_KeyPress;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(839, 257);
            label10.Margin = new Padding(60, 0, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 31);
            label10.TabIndex = 15;
            label10.Text = "Phone :";
            // 
            // cmbYear
            // 
            cmbYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbYear.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4" });
            cmbYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbYear.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbYear.ForeColor = Color.Maroon;
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbYear.Location = new Point(982, 123);
            cmbYear.MaximumSize = new Size(150, 0);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(96, 36);
            cmbYear.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(848, 189);
            label9.Margin = new Padding(60, 0, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 31);
            label9.TabIndex = 14;
            label9.Text = "Email :";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFullName.ForeColor = Color.Maroon;
            txtFullName.Location = new Point(254, 115);
            txtFullName.Margin = new Padding(3, 10, 3, 3);
            txtFullName.MaximumSize = new Size(400, 31);
            txtFullName.MaxLength = 30;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 31);
            txtFullName.TabIndex = 5;
            txtFullName.TextChanged += txtFullName_TextChanged;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(94, 116);
            label4.Margin = new Padding(23, 10, 3, 3);
            label4.Name = "label4";
            label4.Size = new Size(135, 31);
            label4.TabIndex = 4;
            label4.Text = "Full Name :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(63, 179);
            label5.Margin = new Padding(23, 10, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(166, 31);
            label5.TabIndex = 6;
            label5.Text = "Date of Birth :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(862, 121);
            label8.Margin = new Padding(60, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 31);
            label8.TabIndex = 12;
            label8.Text = "Year :";
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDOB.CalendarForeColor = Color.Maroon;
            dtpDOB.CalendarTitleForeColor = Color.Maroon;
            dtpDOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(254, 177);
            dtpDOB.Margin = new Padding(3, 10, 3, 3);
            dtpDOB.MaximumSize = new Size(350, 34);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(350, 34);
            dtpDOB.TabIndex = 7;
            // 
            // cmbCourse
            // 
            cmbCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourse.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCourse.FlatStyle = FlatStyle.Flat;
            cmbCourse.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbCourse.ForeColor = Color.Maroon;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "BSA - Bachelor of Science in Accountancy", "BSCpE - Bachelor of Science in Computer Engineering", "BSIT - Bachelor of Science in Information Technology", "BSENTREP - Bachelor of Science in Entrepreneurship", "BSHM - Bachelor of Science in Hospitality Management (BSHM)", "BSEDEN - Bachelor of Secondary Education major in English", "BSEDMT - Bachelor of Secondary Education major in Mathematics", "DOMT - Diploma in Office Management Technology" });
            cmbCourse.Location = new Point(982, 53);
            cmbCourse.Margin = new Padding(3, 10, 3, 3);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(567, 39);
            cmbCourse.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(834, 53);
            label7.Margin = new Padding(60, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 10;
            label7.Text = "Course :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(165, 242);
            label6.Margin = new Padding(23, 10, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(64, 31);
            label6.TabIndex = 8;
            label6.Text = "Sex :";
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbGender.ForeColor = Color.Maroon;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(254, 242);
            cmbGender.Margin = new Padding(3, 10, 3, 3);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(186, 36);
            cmbGender.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 128);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_management__2_;
            pictureBox1.Location = new Point(41, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 67);
            label2.Name = "label2";
            label2.Size = new Size(474, 31);
            label2.TabIndex = 1;
            label2.Text = "Student Identity and Demographics Registry";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 22);
            label1.Name = "label1";
            label1.Size = new Size(465, 45);
            label1.TabIndex = 0;
            label1.Text = "STUDENT RECORD CENTRAL";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Maroon;
            btnAdd.BorderColor = Color.Transparent;
            btnAdd.BorderThickness = 1;
            btnAdd.BottomLeftRadius = 15;
            btnAdd.BottomRightRadius = 15;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverColor = Color.FromArgb(160, 0, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(1651, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(30, 0, 0, 0);
            btnAdd.PressedColor = Color.FromArgb(60, 0, 0);
            btnAdd.Size = new Size(217, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add    ";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.TopLeftRadius = 15;
            btnAdd.TopRightRadius = 15;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Maroon;
            btnUpdate.BorderColor = Color.FromArgb(74, 0, 0);
            btnUpdate.BorderThickness = 1;
            btnUpdate.BottomLeftRadius = 15;
            btnUpdate.BottomRightRadius = 15;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.HoverColor = Color.FromArgb(160, 0, 0);
            btnUpdate.Image = Properties.Resources.pencil__1_;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(1651, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(30, 0, 0, 0);
            btnUpdate.PressedColor = Color.FromArgb(60, 0, 0);
            btnUpdate.Size = new Size(217, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update   ";
            btnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdate.TopLeftRadius = 15;
            btnUpdate.TopRightRadius = 15;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Maroon;
            btnDelete.BorderColor = Color.FromArgb(74, 0, 0);
            btnDelete.BorderThickness = 1;
            btnDelete.BottomLeftRadius = 15;
            btnDelete.BottomRightRadius = 15;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverColor = Color.FromArgb(160, 0, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(1651, 323);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(30, 0, 0, 0);
            btnDelete.PressedColor = Color.FromArgb(60, 0, 0);
            btnDelete.Size = new Size(217, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete   ";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.TopLeftRadius = 15;
            btnDelete.TopRightRadius = 15;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Maroon;
            btnRefresh.BorderColor = Color.FromArgb(74, 0, 0);
            btnRefresh.BorderThickness = 1;
            btnRefresh.BottomLeftRadius = 15;
            btnRefresh.BottomRightRadius = 15;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverColor = Color.FromArgb(160, 0, 0);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1651, 406);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(30, 0, 0, 0);
            btnRefresh.PressedColor = Color.FromArgb(60, 0, 0);
            btnRefresh.Size = new Size(217, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh   ";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.TopLeftRadius = 15;
            btnRefresh.TopRightRadius = 15;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(32, 491);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1836, 517);
            dgvStudents.TabIndex = 6;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgvStudents);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(roundedGroupBox1);
            MinimumSize = new Size(1024, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Record System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Shown += Form1_Shown;
            TextChanged += Form1_TextChanged;
            roundedGroupBox1.ResumeLayout(false);
            roundedGroupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedGroupBox roundedGroupBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private RoundedButton btnAdd;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private Label label4;
        private DateTimePicker dtpDOB;
        private Label label5;
        private ComboBox cmbGender;
        private Label label6;
        private ComboBox cmbCourse;
        private Label label7;
        private TextBox txtEmail;
        private Label label10;
        private Label label9;
        private ComboBox cmbYear;
        private Label label8;
        private TextBox txtPhone;
        private Label label11;
        private RoundedButton btnUpdate;
        private RoundedButton btnDelete;
        private RoundedButton btnRefresh;
        private DataGridView dgvStudents;
    }
}
