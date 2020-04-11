namespace QuanLyBanQuanAO
{
    partial class DoiTuong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDoiTuong = new System.Windows.Forms.Label();
            this.txtTenDoiTuong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTenDoiTuong);
            this.panel1.Controls.Add(this.txtMaDoiTuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtMaDoiTuong
            // 
            this.txtMaDoiTuong.AutoSize = true;
            this.txtMaDoiTuong.Location = new System.Drawing.Point(39, 32);
            this.txtMaDoiTuong.Name = "txtMaDoiTuong";
            this.txtMaDoiTuong.Size = new System.Drawing.Size(108, 20);
            this.txtMaDoiTuong.TabIndex = 0;
            this.txtMaDoiTuong.Text = "Mã Đội Tượng";
            // 
            // txtTenDoiTuong
            // 
            this.txtTenDoiTuong.AutoSize = true;
            this.txtTenDoiTuong.Location = new System.Drawing.Point(362, 32);
            this.txtTenDoiTuong.Name = "txtTenDoiTuong";
            this.txtTenDoiTuong.Size = new System.Drawing.Size(113, 20);
            this.txtTenDoiTuong.TabIndex = 1;
            this.txtTenDoiTuong.Text = "Tên Đối Tượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoiTuong,
            this.TenDoiTuong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaDoiTuong
            // 
            this.MaDoiTuong.DataPropertyName = "MaDoiTuong";
            this.MaDoiTuong.HeaderText = "Mã Đối Tượng";
            this.MaDoiTuong.MinimumWidth = 8;
            this.MaDoiTuong.Name = "MaDoiTuong";
            this.MaDoiTuong.Width = 150;
            // 
            // TenDoiTuong
            // 
            this.TenDoiTuong.DataPropertyName = "TenDoiTuong";
            this.TenDoiTuong.HeaderText = "Tên Đối Tượng";
            this.TenDoiTuong.MinimumWidth = 8;
            this.TenDoiTuong.Name = "TenDoiTuong";
            this.TenDoiTuong.Width = 150;
            // 
            // DoiTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DoiTuong";
            this.Text = "DoiTuong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTenDoiTuong;
        private System.Windows.Forms.Label txtMaDoiTuong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoiTuong;
    }
}