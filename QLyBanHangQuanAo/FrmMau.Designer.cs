namespace QLyBanHangQuanAo
{
    partial class FrmMau
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
            this.txtMamau = new System.Windows.Forms.TextBox();
            this.txtTenmau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_Mau = new System.Windows.Forms.DataGridView();
            this.Mamau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMamau
            // 
            this.txtMamau.Location = new System.Drawing.Point(124, 58);
            this.txtMamau.Name = "txtMamau";
            this.txtMamau.Size = new System.Drawing.Size(176, 20);
            this.txtMamau.TabIndex = 0;
            // 
            // txtTenmau
            // 
            this.txtTenmau.Location = new System.Drawing.Point(124, 112);
            this.txtTenmau.Name = "txtTenmau";
            this.txtTenmau.Size = new System.Drawing.Size(176, 20);
            this.txtTenmau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Màu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Màu";
            // 
            // DataGridView_Mau
            // 
            this.DataGridView_Mau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Mau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamau,
            this.Tenmau});
            this.DataGridView_Mau.Location = new System.Drawing.Point(49, 169);
            this.DataGridView_Mau.Name = "DataGridView_Mau";
            this.DataGridView_Mau.Size = new System.Drawing.Size(416, 145);
            this.DataGridView_Mau.TabIndex = 4;
            this.DataGridView_Mau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Mau_CellClick);
            // 
            // Mamau
            // 
            this.Mamau.DataPropertyName = "Mamau";
            this.Mamau.HeaderText = "Mã Màu";
            this.Mamau.Name = "Mamau";
            // 
            // Tenmau
            // 
            this.Tenmau.DataPropertyName = "Tenmau";
            this.Tenmau.HeaderText = "Tên Màu";
            this.Tenmau.Name = "Tenmau";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 366);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(658, 366);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(530, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 31);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(385, 366);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 31);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(219, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 31);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView_Mau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenmau);
            this.Controls.Add(this.txtMamau);
            this.Name = "FrmMau";
            this.Text = "FrmMau";
            this.Load += new System.EventHandler(this.FrmMau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMamau;
        private System.Windows.Forms.TextBox txtTenmau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}