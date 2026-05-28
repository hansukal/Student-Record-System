namespace Student_Record_System
{
    partial class FormRecycleBin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecycleBin));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvDeletedStudents = new DataGridView();
            btnRestore = new RoundedButton();
            btnPermanentDelete = new RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedStudents).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1002, 122);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 66);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 3;
            label2.Text = "Recycle Bin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 21);
            label1.Name = "label1";
            label1.Size = new Size(465, 45);
            label1.TabIndex = 2;
            label1.Text = "STUDENT RECORD CENTRAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvDeletedStudents
            // 
            dgvDeletedStudents.BackgroundColor = Color.White;
            dgvDeletedStudents.BorderStyle = BorderStyle.None;
            dgvDeletedStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedStudents.Location = new Point(12, 192);
            dgvDeletedStudents.Name = "dgvDeletedStudents";
            dgvDeletedStudents.RowHeadersWidth = 51;
            dgvDeletedStudents.Size = new Size(978, 385);
            dgvDeletedStudents.TabIndex = 1;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.BackColor = Color.Maroon;
            btnRestore.BorderColor = Color.FromArgb(74, 0, 0);
            btnRestore.BorderThickness = 1;
            btnRestore.BottomLeftRadius = 15;
            btnRestore.BottomRightRadius = 15;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnRestore.ForeColor = Color.White;
            btnRestore.HoverColor = Color.FromArgb(160, 0, 0);
            btnRestore.Image = Properties.Resources.pencil__1_;
            btnRestore.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestore.Location = new Point(12, 130);
            btnRestore.Name = "btnRestore";
            btnRestore.Padding = new Padding(30, 0, 0, 0);
            btnRestore.PressedColor = Color.FromArgb(60, 0, 0);
            btnRestore.Size = new Size(217, 50);
            btnRestore.TabIndex = 4;
            btnRestore.Text = "Restore   ";
            btnRestore.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRestore.TopLeftRadius = 15;
            btnRestore.TopRightRadius = 15;
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnPermanentDelete
            // 
            btnPermanentDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPermanentDelete.BackColor = Color.Maroon;
            btnPermanentDelete.BorderColor = Color.FromArgb(74, 0, 0);
            btnPermanentDelete.BorderThickness = 1;
            btnPermanentDelete.BottomLeftRadius = 15;
            btnPermanentDelete.BottomRightRadius = 15;
            btnPermanentDelete.FlatAppearance.BorderSize = 0;
            btnPermanentDelete.FlatStyle = FlatStyle.Flat;
            btnPermanentDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnPermanentDelete.ForeColor = Color.White;
            btnPermanentDelete.HoverColor = Color.FromArgb(160, 0, 0);
            btnPermanentDelete.Image = Properties.Resources.pencil__1_;
            btnPermanentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnPermanentDelete.Location = new Point(256, 130);
            btnPermanentDelete.Name = "btnPermanentDelete";
            btnPermanentDelete.Padding = new Padding(30, 0, 0, 0);
            btnPermanentDelete.PressedColor = Color.FromArgb(60, 0, 0);
            btnPermanentDelete.Size = new Size(278, 50);
            btnPermanentDelete.TabIndex = 5;
            btnPermanentDelete.Text = "Permanent Delete   ";
            btnPermanentDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPermanentDelete.TopLeftRadius = 15;
            btnPermanentDelete.TopRightRadius = 15;
            btnPermanentDelete.UseVisualStyleBackColor = false;
            btnPermanentDelete.Click += btnPermanentDelete_Click;
            // 
            // FormRecycleBin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 589);
            Controls.Add(btnPermanentDelete);
            Controls.Add(btnRestore);
            Controls.Add(dgvDeletedStudents);
            Controls.Add(panel1);
            Name = "FormRecycleBin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRecycleBin";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvDeletedStudents;
        private RoundedButton btnRestore;
        private RoundedButton btnPermanentDelete;
    }
}