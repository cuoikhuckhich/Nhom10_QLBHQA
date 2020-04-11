namespace QuanLyBanQuanAO
{
    partial class Mua
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
            this.txtMaMua = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenMua = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaMua
            // 
            this.txtMaMua.AutoSize = true;
            this.txtMaMua.Location = new System.Drawing.Point(84, 39);
            this.txtMaMua.Name = "txtMaMua";
            this.txtMaMua.Size = new System.Drawing.Size(66, 20);
            this.txtMaMua.TabIndex = 0;
            this.txtMaMua.Text = "Mã Mùa";
            this.txtMaMua.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // txtTenMua
            // 
            this.txtTenMua.AutoSize = true;
            this.txtTenMua.Location = new System.Drawing.Point(376, 42);
            this.txtTenMua.Name = "txtTenMua";
            this.txtTenMua.Size = new System.Drawing.Size(71, 20);
            this.txtTenMua.TabIndex = 2;
            this.txtTenMua.Text = "Tên Mùa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMua,
            this.TenMau});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(803, 259);
            this.dataGridView1.TabIndex = 4;
            // 
            // MaMua
            // 
            this.MaMua.DataPropertyName = "MaMua";
            this.MaMua.HeaderText = "Mã Mùa";
            this.MaMua.MinimumWidth = 8;
            this.MaMua.Name = "MaMua";
            this.MaMua.Width = 150;
            // 
            // TenMau
            // 
            this.TenMau.DataPropertyName = "TenMua";
            this.TenMau.HeaderText = "Tên Màu";
            this.TenMau.MinimumWidth = 8;
            this.TenMau.Name = "TenMau";
            this.TenMau.Width = 150;
            // 
            // Mua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTenMua);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMaMua);
            this.Name = "Mua";
            this.Text = "Mua";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMaMua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTenMua;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMau;
    }
}