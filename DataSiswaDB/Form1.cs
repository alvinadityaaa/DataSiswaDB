using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSiswaDB
{
    public partial class Form1 : Form
    {
        string connStr = "Data Source=siswa.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatabase();
            LoadData();
            LoadNilai();
        }

        private void InitDatabase()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS Siswa (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    NIS         TEXT NOT NULL,
                    Nama        TEXT NOT NULL,
                    Kelas       TEXT,
                    TglDaftar   TEXT
                )";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string sqlScores = @"CREATE TABLE IF NOT EXISTS Nilai (
                    SiswaId     INTEGER,
                    MatPel      TEXT,
                    Nilai       INTEGER
                )";

                using (var cmd = new SQLiteCommand(sqlScores, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string trimmedNis = txtNIS.Text.Trim();

                if (txtId.Text != "")
                {
                    using (var conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();

                        string sqlUpdate = @"UPDATE Siswa SET
                            NIS=@nis, Nama=@nama, Kelas=@kelas
                            WHERE Id=@id";

                        using (var cmd = new SQLiteCommand(sqlUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtId.Text);
                            cmd.Parameters.AddWithValue("@nis", trimmedNis);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                            cmd.Parameters.AddWithValue("@kelas", cbKelas.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    lblStatus.Text = "Updated: " + txtNama.Text;
                    LoadData();
                    LoadNilai();
                    ClearForm();
                    return;
                }

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM Siswa WHERE NIS=@nis";
                    using (var cmd = new SQLiteCommand(checkSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nis", trimmedNis);

                        int sameNisCount = (int)(long)cmd.ExecuteScalar();

                        if (sameNisCount > 0)
                        {
                            MessageBox.Show("This NIS is already registered!");
                            return;
                        }
                    }

                    string sql = @"INSERT INTO Siswa (NIS, Nama, Kelas, TglDaftar)
                                   VALUES (@nis, @nama, @kelas, @tgl)";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nis", trimmedNis);
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@kelas", cbKelas.Text);
                        cmd.Parameters.AddWithValue("@tgl", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }
                }

                lblStatus.Text = "Saved: " + txtNama.Text;

                txtNIS.Clear();
                txtNama.Clear();
                cbKelas.SelectedIndex = -1;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void LoadData()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT * FROM Siswa ORDER BY Id DESC";

                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSiswa.DataSource = dt;
                }

                using (var countCmd = new SQLiteCommand("SELECT COUNT(*) FROM Siswa", conn))
                {
                    int total = Convert.ToInt32(countCmd.ExecuteScalar());
                    lblTotal.Text = "Total: " + total;
                }
            }
        }

        private void LoadNilai()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT n.rowid AS NilaiId, s.Nama, n.Matpel, n.Nilai
                               FROM Siswa s
                               JOIN Nilai n ON n.SiswaId = s.Id
                               ORDER BY n.Matpel, s.Nama";

                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNilai.DataSource = dt;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSimpanNilai_Click(object sender, EventArgs e)
        {
            try
            {
                int scoreNumber;
                if (!int.TryParse(txtNilai.Text, out scoreNumber) || scoreNumber < 0 || scoreNumber > 100)
                {
                    MessageBox.Show("Score must be a number from 0 to 100!");
                    return;
                }

                if (txtIdNilai.Text != "")
                {
                    using (var conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();

                        string sqlUpdate = "UPDATE Nilai SET Matpel=@mp, Nilai=@nilai WHERE rowid=@id";
                        using (var cmd = new SQLiteCommand(sqlUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@mp", cbMatpel.Text);
                            cmd.Parameters.AddWithValue("@nilai", txtNilai.Text);
                            cmd.Parameters.AddWithValue("@id", txtIdNilai.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadNilai();
                    ClearNilai();
                    lblStatus.Text = "Score updated.";
                    return;
                }

                if (dgvSiswa.CurrentRow == null || dgvSiswa.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please click a student in the table first!");
                    return;
                }

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string sql = "INSERT INTO Nilai (SiswaId, Matpel, Nilai) VALUES (@sid, @mp, @nilai)";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", dgvSiswa.CurrentRow.Cells["Id"].Value);
                        cmd.Parameters.AddWithValue("@mp", cbMatpel.Text);
                        cmd.Parameters.AddWithValue("@nilai", txtNilai.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                cbMatpel.SelectedIndex = -1;
                txtNilai.Clear();
                LoadNilai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Please select the data you want to delete",
                        "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Delete student '{txtNama.Text}'?\n" +
                    "This cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string sql = "DELETE FROM Siswa WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
                LoadNilai();
                ClearForm();
                lblStatus.Text = "Student deleted successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSiswa.Rows[e.RowIndex];

            txtId.Text = row.Cells["Id"].Value?.ToString();
            txtNIS.Text = row.Cells["NIS"].Value?.ToString();
            txtNama.Text = row.Cells["Nama"].Value?.ToString();
            cbKelas.Text = row.Cells["Kelas"].Value?.ToString();

            btnSimpan.Text = "Update";
            btnHapus.Enabled = true;
        }

        private void ClearForm()
        {
            txtId.Text = txtNIS.Text = txtNama.Text = "";
            cbKelas.SelectedIndex = -1;
            btnSimpan.Text = "Save";
            btnHapus.Enabled = false;
        }

        private void ClearNilai()
        {
            txtIdNilai.Clear();
            cbMatpel.SelectedIndex = -1;
            txtNilai.Clear();
            btnSimpanNilai.Text = "Save Score";
        }

        private void dgvNilai_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNilai.Rows[e.RowIndex];

            txtIdNilai.Text = row.Cells["NilaiId"].Value?.ToString();
            cbMatpel.Text = row.Cells["MatPel"].Value?.ToString();
            txtNilai.Text = row.Cells["Nilai"].Value?.ToString();
            btnSimpanNilai.Text = "Update Score";
        }

        private void btnHapusNilai_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdNilai.Text))
                {
                    MessageBox.Show("Please select the data you want to delete",
                        "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show(
                    "Delete this score?\n" +
                    "This cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string sql = "DELETE FROM Nilai WHERE rowid = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtIdNilai.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadNilai();
                ClearNilai();
                lblStatus.Text = "Score deleted.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBatalNilai_Click(object sender, EventArgs e)
        {
            ClearNilai();
        }

        private void dgvNilai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvNilai.Columns[e.ColumnIndex].Name != "Nilai") return;

            int score;
            if (!int.TryParse(e.Value?.ToString(), out score)) return;

            if (score >= 80)
                e.CellStyle.BackColor = Color.LightGreen;
            else if (score >= 70)
                e.CellStyle.BackColor = Color.Yellow;
            else
                e.CellStyle.BackColor = Color.LightCoral;
        }

        private void txtNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}