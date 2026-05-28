using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Student_Record_System
{
    public partial class FormRecycleBin : Form
    {
        private string connString = "server=localhost;port=3306;username=root;password=sql123;database=StudentRecordDB";
        public FormRecycleBin()
        {
            InitializeComponent();
            ApplyGridStyles();
            LoadTrashRecords();
        }
        private void LoadTrashRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    // Pulls only rows flagged as 'Archived'
                    string query = "SELECT student_id AS 'Student ID', full_name AS 'Full Name', course AS 'Course', year_level AS 'Year' " +
                                   "FROM students WHERE status = 'Archived'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvDeletedStudents.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading trash: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDeletedStudents.SelectedRows.Count == 0) return;

            string studentId = dgvDeletedStudents.SelectedRows[0].Cells["Student ID"].Value.ToString();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    // Flip status back to Active
                    string query = "UPDATE students SET status = 'Active' WHERE student_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record successfully restored!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTrashRecords();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnPermanentDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeletedStudents.SelectedRows.Count == 0) return;

            string studentId = dgvDeletedStudents.SelectedRows[0].Cells["Student ID"].Value.ToString();

            DialogResult confirm = MessageBox.Show("This action cannot be undone. Permanently delete this student record?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        // Delete row completely from database storage
                        string query = "DELETE FROM students WHERE student_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", studentId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Record permanently wiped out.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTrashRecords();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void ApplyGridStyles()
        {
            dgvDeletedStudents.EnableHeadersVisualStyles = false;
            dgvDeletedStudents.ReadOnly = true;
            dgvDeletedStudents.RowHeadersVisible = false;
            dgvDeletedStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeletedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeletedStudents.BackgroundColor = Color.White;
            dgvDeletedStudents.BorderStyle = BorderStyle.None;

            // Header Styling (Matching Maroon Layout System)
            dgvDeletedStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 0, 0);
            dgvDeletedStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDeletedStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDeletedStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDeletedStudents.ColumnHeadersHeight = 35;
        }
    }
}
