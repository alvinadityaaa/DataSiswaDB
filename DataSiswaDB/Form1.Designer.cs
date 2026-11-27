namespace DataSiswaDB
{
    partial class Form1
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
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.txtNIS = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbKelas = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnSimpanNilai = new System.Windows.Forms.Button();
            this.dgvNilai = new System.Windows.Forms.DataGridView();
            this.lblMatPel = new System.Windows.Forms.Label();
            this.lblNilai = new System.Windows.Forms.Label();
            this.cbMatpel = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnHapusNilai = new System.Windows.Forms.Button();
            this.btnBatalNilai = new System.Windows.Forms.Button();
            this.txtIdNilai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Location = new System.Drawing.Point(12, 9);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(29, 16);
            this.lblNIS.TabIndex = 0;
            this.lblNIS.Text = "NIS";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 59);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(12, 111);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(41, 16);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas";
            this.lblKelas.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNIS
            // 
            this.txtNIS.Location = new System.Drawing.Point(84, 9);
            this.txtNIS.MaxLength = 10;
            this.txtNIS.Name = "txtNIS";
            this.txtNIS.Size = new System.Drawing.Size(172, 22);
            this.txtNIS.TabIndex = 3;
            this.txtNIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIS_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(84, 59);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(172, 22);
            this.txtNama.TabIndex = 4;
            // 
            // cbKelas
            // 
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.Items.AddRange(new object[] {
            "X RPL 1",
            "X RPL 2",
            "XI RPL 1",
            "XI RPL 2",
            "XII RPL 1",
            "XII RPL 2"});
            this.cbKelas.Location = new System.Drawing.Point(84, 111);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(172, 24);
            this.cbKelas.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(15, 169);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(78, 28);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Location = new System.Drawing.Point(15, 216);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowHeadersWidth = 51;
            this.dgvSiswa.RowTemplate.Height = 24;
            this.dgvSiswa.Size = new System.Drawing.Size(746, 150);
            this.dgvSiswa.TabIndex = 7;
            this.dgvSiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiswa_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(383, 384);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: 0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(134, 475);
            this.txtNilai.MaxLength = 3;
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(121, 22);
            this.txtNilai.TabIndex = 10;
            this.txtNilai.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSimpanNilai
            // 
            this.btnSimpanNilai.Location = new System.Drawing.Point(18, 517);
            this.btnSimpanNilai.Name = "btnSimpanNilai";
            this.btnSimpanNilai.Size = new System.Drawing.Size(104, 27);
            this.btnSimpanNilai.TabIndex = 11;
            this.btnSimpanNilai.Text = "Simpan Nilai";
            this.btnSimpanNilai.UseVisualStyleBackColor = true;
            this.btnSimpanNilai.Click += new System.EventHandler(this.btnSimpanNilai_Click);
            // 
            // dgvNilai
            // 
            this.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilai.Location = new System.Drawing.Point(15, 569);
            this.dgvNilai.Name = "dgvNilai";
            this.dgvNilai.RowHeadersWidth = 51;
            this.dgvNilai.RowTemplate.Height = 24;
            this.dgvNilai.Size = new System.Drawing.Size(563, 170);
            this.dgvNilai.TabIndex = 12;
            this.dgvNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNilai_Cellclick);
            this.dgvNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNilai_CellContentClick);
            this.dgvNilai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNilai_CellFormatting);
            // 
            // lblMatPel
            // 
            this.lblMatPel.AutoSize = true;
            this.lblMatPel.Location = new System.Drawing.Point(12, 432);
            this.lblMatPel.Name = "lblMatPel";
            this.lblMatPel.Size = new System.Drawing.Size(98, 16);
            this.lblMatPel.TabIndex = 13;
            this.lblMatPel.Text = "Mata Pelajaran";
            // 
            // lblNilai
            // 
            this.lblNilai.AutoSize = true;
            this.lblNilai.Location = new System.Drawing.Point(12, 475);
            this.lblNilai.Name = "lblNilai";
            this.lblNilai.Size = new System.Drawing.Size(34, 16);
            this.lblNilai.TabIndex = 14;
            this.lblNilai.Text = "Nilai";
            // 
            // cbMatpel
            // 
            this.cbMatpel.FormattingEnabled = true;
            this.cbMatpel.Items.AddRange(new object[] {
            "Matematika",
            "IPA"});
            this.cbMatpel.Location = new System.Drawing.Point(134, 429);
            this.cbMatpel.Name = "cbMatpel";
            this.cbMatpel.Size = new System.Drawing.Size(121, 24);
            this.cbMatpel.TabIndex = 15;
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Location = new System.Drawing.Point(116, 169);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(81, 28);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(216, 169);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(81, 28);
            this.btnBatal.TabIndex = 17;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(221, 742);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Siap";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(346, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 22);
            this.txtId.TabIndex = 20;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnHapusNilai
            // 
            this.btnHapusNilai.Location = new System.Drawing.Point(134, 517);
            this.btnHapusNilai.Name = "btnHapusNilai";
            this.btnHapusNilai.Size = new System.Drawing.Size(104, 27);
            this.btnHapusNilai.TabIndex = 21;
            this.btnHapusNilai.Text = "Hapus";
            this.btnHapusNilai.UseVisualStyleBackColor = true;
            this.btnHapusNilai.Click += new System.EventHandler(this.btnHapusNilai_Click);
            // 
            // btnBatalNilai
            // 
            this.btnBatalNilai.Location = new System.Drawing.Point(258, 517);
            this.btnBatalNilai.Name = "btnBatalNilai";
            this.btnBatalNilai.Size = new System.Drawing.Size(104, 27);
            this.btnBatalNilai.TabIndex = 22;
            this.btnBatalNilai.Text = "Batal";
            this.btnBatalNilai.UseVisualStyleBackColor = true;
            this.btnBatalNilai.Click += new System.EventHandler(this.btnBatalNilai_Click);
            // 
            // txtIdNilai
            // 
            this.txtIdNilai.Location = new System.Drawing.Point(346, 429);
            this.txtIdNilai.Name = "txtIdNilai";
            this.txtIdNilai.Size = new System.Drawing.Size(171, 22);
            this.txtIdNilai.TabIndex = 23;
            this.txtIdNilai.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 791);
            this.Controls.Add(this.txtIdNilai);
            this.Controls.Add(this.btnBatalNilai);
            this.Controls.Add(this.btnHapusNilai);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.cbMatpel);
            this.Controls.Add(this.lblNilai);
            this.Controls.Add(this.lblMatPel);
            this.Controls.Add(this.dgvNilai);
            this.Controls.Add(this.btnSimpanNilai);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvSiswa);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cbKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIS);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox txtNIS;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbKelas;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnSimpanNilai;
        private System.Windows.Forms.DataGridView dgvNilai;
        private System.Windows.Forms.Label lblMatPel;
        private System.Windows.Forms.Label lblNilai;
        private System.Windows.Forms.ComboBox cbMatpel;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnHapusNilai;
        private System.Windows.Forms.Button btnBatalNilai;
        private System.Windows.Forms.TextBox txtIdNilai;
    }
}

