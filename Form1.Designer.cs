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
            panel9 = new Panel();
            txtPhone = new TextBox();
            panel8 = new Panel();
            cmbYear = new ComboBox();
            panel7 = new Panel();
            cmbGender = new ComboBox();
            panel6 = new Panel();
            dtpDOB = new DateTimePicker();
            panel5 = new Panel();
            txtFullName = new TextBox();
            panel4 = new Panel();
            txtEmail = new TextBox();
            panel3 = new Panel();
            txtStudentID = new TextBox();
            panel2 = new Panel();
            cmbCourse = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new RoundedButton();
            btnUpdate = new RoundedButton();
            btnDelete = new RoundedButton();
            btnRefresh = new RoundedButton();
            dgvStudents = new DataGridView();
            btnExport = new RoundedButton();
            btnOpenRecycleBin = new RoundedButton();
            pnlRecycleBin = new Panel();
            panel10 = new Panel();
            label3 = new Label();
            label12 = new Label();
            panel11 = new Panel();
            pictureBox2 = new PictureBox();
            btnCloseRecycleBin = new RoundedButton();
            btnPermanentDelete = new RoundedButton();
            btnRestore = new RoundedButton();
            dgvDeletedStudents = new DataGridView();
            roundedGroupBox1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlRecycleBin.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedStudents).BeginInit();
            SuspendLayout();
            // 
            // roundedGroupBox1
            // 
            roundedGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedGroupBox1.BackColor = Color.Transparent;
            roundedGroupBox1.BorderColor = Color.Maroon;
            roundedGroupBox1.BorderThickness = 2;
            roundedGroupBox1.Controls.Add(panel9);
            roundedGroupBox1.Controls.Add(panel8);
            roundedGroupBox1.Controls.Add(panel7);
            roundedGroupBox1.Controls.Add(panel6);
            roundedGroupBox1.Controls.Add(panel5);
            roundedGroupBox1.Controls.Add(panel4);
            roundedGroupBox1.Controls.Add(panel3);
            roundedGroupBox1.Controls.Add(panel2);
            roundedGroupBox1.Controls.Add(label11);
            roundedGroupBox1.Controls.Add(label10);
            roundedGroupBox1.Controls.Add(label9);
            roundedGroupBox1.Controls.Add(label7);
            roundedGroupBox1.Controls.Add(label4);
            roundedGroupBox1.Controls.Add(label5);
            roundedGroupBox1.Controls.Add(label8);
            roundedGroupBox1.Controls.Add(label6);
            roundedGroupBox1.CornerRadius = 15;
            roundedGroupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roundedGroupBox1.ForeColor = Color.White;
            roundedGroupBox1.HeaderTextColor = Color.Maroon;
            roundedGroupBox1.HeaderTextPaddingLeft = 35;
            roundedGroupBox1.Location = new Point(20, 143);
            roundedGroupBox1.Name = "roundedGroupBox1";
            roundedGroupBox1.Size = new Size(1858, 224);
            roundedGroupBox1.TabIndex = 0;
            roundedGroupBox1.TabStop = false;
            roundedGroupBox1.Text = "Student Details";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Maroon;
            panel9.Controls.Add(txtPhone);
            panel9.ForeColor = Color.Black;
            panel9.Location = new Point(1613, 143);
            panel9.Name = "panel9";
            panel9.Size = new Size(208, 39);
            panel9.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPhone.ForeColor = Color.Maroon;
            txtPhone.Location = new Point(4, 4);
            txtPhone.MaximumSize = new Size(200, 31);
            txtPhone.MaxLength = 13;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyDown += txtPhone_KeyDown;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Maroon;
            panel8.Controls.Add(cmbYear);
            panel8.Location = new Point(855, 143);
            panel8.Name = "panel8";
            panel8.Size = new Size(115, 39);
            panel8.TabIndex = 21;
            // 
            // cmbYear
            // 
            cmbYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbYear.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4" });
            cmbYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbYear.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbYear.ForeColor = Color.Maroon;
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbYear.Location = new Point(4, 3);
            cmbYear.MaximumSize = new Size(150, 0);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(107, 33);
            cmbYear.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Maroon;
            panel7.Controls.Add(cmbGender);
            panel7.Location = new Point(1701, 58);
            panel7.Name = "panel7";
            panel7.Size = new Size(117, 39);
            panel7.TabIndex = 21;
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbGender.ForeColor = Color.Maroon;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(4, 3);
            cmbGender.Margin = new Padding(3, 10, 3, 3);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(109, 33);
            cmbGender.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(dtpDOB);
            panel6.Location = new Point(1233, 58);
            panel6.Name = "panel6";
            panel6.Size = new Size(358, 39);
            panel6.TabIndex = 21;
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDOB.CalendarForeColor = Color.Maroon;
            dtpDOB.CalendarTitleForeColor = Color.Maroon;
            dtpDOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(4, 3);
            dtpDOB.Margin = new Padding(3, 10, 3, 3);
            dtpDOB.MaximumSize = new Size(350, 34);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(350, 34);
            dtpDOB.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Maroon;
            panel5.Controls.Add(txtFullName);
            panel5.Location = new Point(613, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(408, 39);
            panel5.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFullName.ForeColor = Color.Maroon;
            txtFullName.Location = new Point(5, 4);
            txtFullName.Margin = new Padding(3, 10, 3, 3);
            txtFullName.MaximumSize = new Size(400, 31);
            txtFullName.MaxLength = 40;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(398, 31);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += txtFullName_TextChanged;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(txtEmail);
            panel4.Location = new Point(1093, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(382, 39);
            panel4.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Maroon;
            txtEmail.Location = new Point(4, 4);
            txtEmail.MaximumSize = new Size(374, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 31);
            txtEmail.TabIndex = 100;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(txtStudentID);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(194, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 39);
            panel3.TabIndex = 19;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.White;
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtStudentID.ForeColor = Color.Maroon;
            txtStudentID.Location = new Point(4, 4);
            txtStudentID.Margin = new Padding(0);
            txtStudentID.MaximumSize = new Size(230, 31);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "ex. 2024-00174-SM-0";
            txtStudentID.ShortcutsEnabled = false;
            txtStudentID.Size = new Size(230, 31);
            txtStudentID.TabIndex = 0;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            txtStudentID.KeyDown += txtStudentID_KeyDown;
            txtStudentID.KeyPress += txtStudentID_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(cmbCourse);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(149, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 39);
            panel2.TabIndex = 18;
            // 
            // cmbCourse
            // 
            cmbCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourse.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCourse.FlatStyle = FlatStyle.Flat;
            cmbCourse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbCourse.ForeColor = Color.Maroon;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "BSA - Bachelor of Science in Accountancy", "BSCpE - Bachelor of Science in Computer Engineering", "BSIT - Bachelor of Science in Information Technology", "BSENTREP - Bachelor of Science in Entrepreneurship", "BSHM - Bachelor of Science in Hospitality Management (BSHM)", "BSEDEN - Bachelor of Secondary Education major in English", "BSEDMT - Bachelor of Secondary Education major in Mathematics", "DOMT - Diploma in Office Management Technology" });
            cmbCourse.Location = new Point(4, 3);
            cmbCourse.Margin = new Padding(10);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(588, 33);
            cmbCourse.TabIndex = 4;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(31, 62);
            label11.Margin = new Padding(23, 10, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(140, 31);
            label11.TabIndex = 5;
            label11.Text = "Student ID :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(1494, 146);
            label10.Margin = new Padding(60, 0, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 31);
            label10.TabIndex = 15;
            label10.Text = "Phone :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(989, 146);
            label9.Margin = new Padding(60, 0, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 31);
            label9.TabIndex = 14;
            label9.Text = "Email :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(31, 146);
            label7.Margin = new Padding(60, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 10;
            label7.Text = "Course :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(455, 62);
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
            label5.Location = new Point(1044, 62);
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
            label8.Location = new Point(765, 146);
            label8.Margin = new Padding(60, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 31);
            label8.TabIndex = 12;
            label8.Text = "Year :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(1614, 62);
            label6.Margin = new Padding(23, 10, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(64, 31);
            label6.TabIndex = 8;
            label6.Text = "Sex :";
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
            btnAdd.Location = new Point(20, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(30, 0, 0, 0);
            btnAdd.PressedColor = Color.FromArgb(60, 0, 0);
            btnAdd.Size = new Size(185, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Profile   ";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.TopLeftRadius = 15;
            btnAdd.TopRightRadius = 15;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Maroon;
            btnUpdate.BorderColor = Color.FromArgb(74, 0, 0);
            btnUpdate.BorderThickness = 1;
            btnUpdate.BottomLeftRadius = 15;
            btnUpdate.BottomRightRadius = 15;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.HoverColor = Color.RoyalBlue;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(230, 382);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(30, 0, 0, 0);
            btnUpdate.PressedColor = Color.FromArgb(60, 0, 0);
            btnUpdate.Size = new Size(161, 50);
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
            btnDelete.BackColor = Color.Maroon;
            btnDelete.BorderColor = Color.FromArgb(74, 0, 0);
            btnDelete.BorderThickness = 1;
            btnDelete.BottomLeftRadius = 15;
            btnDelete.BottomRightRadius = 15;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverColor = Color.DimGray;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(416, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(30, 0, 0, 0);
            btnDelete.PressedColor = Color.FromArgb(60, 0, 0);
            btnDelete.Size = new Size(161, 50);
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
            btnRefresh.BackColor = Color.Maroon;
            btnRefresh.BorderColor = Color.FromArgb(74, 0, 0);
            btnRefresh.BorderThickness = 1;
            btnRefresh.BottomLeftRadius = 15;
            btnRefresh.BottomRightRadius = 15;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverColor = Color.Blue;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(602, 382);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(30, 0, 0, 0);
            btnRefresh.PressedColor = Color.FromArgb(60, 0, 0);
            btnRefresh.Size = new Size(161, 50);
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
            dgvStudents.Location = new Point(20, 448);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1877, 560);
            dgvStudents.TabIndex = 6;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Maroon;
            btnExport.BorderColor = Color.FromArgb(74, 0, 0);
            btnExport.BorderThickness = 1;
            btnExport.BottomLeftRadius = 15;
            btnExport.BottomRightRadius = 15;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverColor = Color.Green;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(788, 382);
            btnExport.Name = "btnExport";
            btnExport.Padding = new Padding(30, 0, 0, 0);
            btnExport.PressedColor = Color.FromArgb(60, 0, 0);
            btnExport.Size = new Size(161, 50);
            btnExport.TabIndex = 7;
            btnExport.Text = "Export  ";
            btnExport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExport.TopLeftRadius = 15;
            btnExport.TopRightRadius = 15;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnOpenRecycleBin
            // 
            btnOpenRecycleBin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenRecycleBin.BackColor = Color.Maroon;
            btnOpenRecycleBin.BackgroundImageLayout = ImageLayout.None;
            btnOpenRecycleBin.BorderColor = SystemColors.Control;
            btnOpenRecycleBin.BorderThickness = 0;
            btnOpenRecycleBin.BottomLeftRadius = 15;
            btnOpenRecycleBin.BottomRightRadius = 15;
            btnOpenRecycleBin.FlatAppearance.BorderSize = 0;
            btnOpenRecycleBin.FlatStyle = FlatStyle.Flat;
            btnOpenRecycleBin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnOpenRecycleBin.ForeColor = Color.White;
            btnOpenRecycleBin.HoverColor = Color.DimGray;
            btnOpenRecycleBin.Image = (Image)resources.GetObject("btnOpenRecycleBin.Image");
            btnOpenRecycleBin.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenRecycleBin.Location = new Point(1725, 382);
            btnOpenRecycleBin.Name = "btnOpenRecycleBin";
            btnOpenRecycleBin.Padding = new Padding(30, 0, 0, 0);
            btnOpenRecycleBin.PressedColor = Color.FromArgb(60, 0, 0);
            btnOpenRecycleBin.Size = new Size(153, 50);
            btnOpenRecycleBin.TabIndex = 8;
            btnOpenRecycleBin.Text = "Trash Bin";
            btnOpenRecycleBin.TextAlign = ContentAlignment.TopCenter;
            btnOpenRecycleBin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOpenRecycleBin.TopLeftRadius = 15;
            btnOpenRecycleBin.TopRightRadius = 15;
            btnOpenRecycleBin.UseVisualStyleBackColor = false;
            btnOpenRecycleBin.Click += btnOpenRecycleBin_Click;
            // 
            // pnlRecycleBin
            // 
            pnlRecycleBin.BackColor = Color.White;
            pnlRecycleBin.BorderStyle = BorderStyle.FixedSingle;
            pnlRecycleBin.Controls.Add(panel10);
            pnlRecycleBin.Controls.Add(btnCloseRecycleBin);
            pnlRecycleBin.Controls.Add(btnPermanentDelete);
            pnlRecycleBin.Controls.Add(btnRestore);
            pnlRecycleBin.Controls.Add(dgvDeletedStudents);
            pnlRecycleBin.Location = new Point(169, 438);
            pnlRecycleBin.Name = "pnlRecycleBin";
            pnlRecycleBin.Size = new Size(800, 450);
            pnlRecycleBin.TabIndex = 9;
            pnlRecycleBin.Visible = false;
            pnlRecycleBin.MouseCaptureChanged += pnlRecycleBin_MouseCaptureChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Maroon;
            panel10.Controls.Add(label3);
            panel10.Controls.Add(label12);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(798, 124);
            panel10.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(155, 67);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 6;
            label3.Text = "Recycle Bin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(155, 22);
            label12.Name = "label12";
            label12.Size = new Size(465, 45);
            label12.TabIndex = 5;
            label12.Text = "STUDENT RECORD CENTRAL";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Maroon;
            panel11.Controls.Add(pictureBox2);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(798, 124);
            panel11.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnCloseRecycleBin
            // 
            btnCloseRecycleBin.BackColor = Color.Maroon;
            btnCloseRecycleBin.BorderColor = Color.FromArgb(74, 0, 0);
            btnCloseRecycleBin.BorderThickness = 1;
            btnCloseRecycleBin.BottomLeftRadius = 15;
            btnCloseRecycleBin.BottomRightRadius = 15;
            btnCloseRecycleBin.FlatAppearance.BorderSize = 0;
            btnCloseRecycleBin.FlatStyle = FlatStyle.Flat;
            btnCloseRecycleBin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnCloseRecycleBin.ForeColor = Color.White;
            btnCloseRecycleBin.HoverColor = Color.FromArgb(160, 0, 0);
            btnCloseRecycleBin.Image = Properties.Resources.logout__2_;
            btnCloseRecycleBin.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseRecycleBin.Location = new Point(645, 128);
            btnCloseRecycleBin.Name = "btnCloseRecycleBin";
            btnCloseRecycleBin.PressedColor = Color.FromArgb(60, 0, 0);
            btnCloseRecycleBin.Size = new Size(150, 50);
            btnCloseRecycleBin.TabIndex = 3;
            btnCloseRecycleBin.Text = "Exit     ";
            btnCloseRecycleBin.TopLeftRadius = 15;
            btnCloseRecycleBin.TopRightRadius = 15;
            btnCloseRecycleBin.UseVisualStyleBackColor = false;
            btnCloseRecycleBin.Click += btnCloseRecycleBin_Click;
            // 
            // btnPermanentDelete
            // 
            btnPermanentDelete.BackColor = Color.Maroon;
            btnPermanentDelete.BorderColor = Color.FromArgb(74, 0, 0);
            btnPermanentDelete.BorderThickness = 1;
            btnPermanentDelete.BottomLeftRadius = 15;
            btnPermanentDelete.BottomRightRadius = 15;
            btnPermanentDelete.FlatAppearance.BorderSize = 0;
            btnPermanentDelete.FlatStyle = FlatStyle.Flat;
            btnPermanentDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnPermanentDelete.ForeColor = Color.White;
            btnPermanentDelete.HoverColor = Color.FromArgb(160, 0, 0);
            btnPermanentDelete.Image = Properties.Resources.delete__4_;
            btnPermanentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnPermanentDelete.Location = new Point(165, 128);
            btnPermanentDelete.Name = "btnPermanentDelete";
            btnPermanentDelete.PressedColor = Color.FromArgb(60, 0, 0);
            btnPermanentDelete.Size = new Size(224, 50);
            btnPermanentDelete.TabIndex = 2;
            btnPermanentDelete.Text = "Permanently Delete  ";
            btnPermanentDelete.TopLeftRadius = 15;
            btnPermanentDelete.TopRightRadius = 15;
            btnPermanentDelete.UseVisualStyleBackColor = false;
            btnPermanentDelete.Click += btnPermanentDelete_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Maroon;
            btnRestore.BorderColor = Color.FromArgb(74, 0, 0);
            btnRestore.BorderThickness = 1;
            btnRestore.BottomLeftRadius = 15;
            btnRestore.BottomRightRadius = 15;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.White;
            btnRestore.HoverColor = Color.FromArgb(160, 0, 0);
            btnRestore.Image = (Image)resources.GetObject("btnRestore.Image");
            btnRestore.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestore.Location = new Point(4, 128);
            btnRestore.Name = "btnRestore";
            btnRestore.PressedColor = Color.FromArgb(60, 0, 0);
            btnRestore.Size = new Size(155, 50);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore   ";
            btnRestore.TextAlign = ContentAlignment.MiddleLeft;
            btnRestore.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestore.TopLeftRadius = 15;
            btnRestore.TopRightRadius = 15;
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // dgvDeletedStudents
            // 
            dgvDeletedStudents.BackgroundColor = Color.White;
            dgvDeletedStudents.BorderStyle = BorderStyle.None;
            dgvDeletedStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedStudents.Location = new Point(-1, 184);
            dgvDeletedStudents.Name = "dgvDeletedStudents";
            dgvDeletedStudents.RowHeadersWidth = 51;
            dgvDeletedStudents.Size = new Size(798, 263);
            dgvDeletedStudents.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlRecycleBin);
            Controls.Add(btnOpenRecycleBin);
            Controls.Add(btnExport);
            Controls.Add(dgvStudents);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(roundedGroupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Record System";
            Load += Form1_Load;
            Shown += Form1_Shown;
            roundedGroupBox1.ResumeLayout(false);
            roundedGroupBox1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlRecycleBin.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedStudents).EndInit();
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private RoundedButton btnExport;
        private RoundedButton btnOpenRecycleBin;
        private Panel pnlRecycleBin;
        private DataGridView dgvDeletedStudents;
        private Panel panel10;
        private Label label3;
        private Label label12;
        private Panel panel11;
        private PictureBox pictureBox2;
        private RoundedButton btnCloseRecycleBin;
        private RoundedButton btnPermanentDelete;
        private RoundedButton btnRestore;
    }
}
