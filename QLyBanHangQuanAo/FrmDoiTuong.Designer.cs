namespace QLyBanHangQuanAo
{
    partial class FrmDoiTuong
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadoituong = new System.Windows.Forms.TextBox();
            this.txtTendoituong = new System.Windows.Forms.TextBox();
            this.DataGridView_DoiTuong = new System.Windows.Forms.DataGridView();
            this.Madoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DoiTuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(62, 382);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(188, 382);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(328, 382);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(476, 382);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(645, 382);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Đối Tượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Đối Tượng";
            // 
            // txtMadoituong
            // 
            this.txtMadoituong.Location = new System.Drawing.Point(115, 67);
            this.txtMadoituong.Name = "txtMadoituong";
            this.txtMadoituong.Size = new System.Drawing.Size(133, 20);
            this.txtMadoituong.TabIndex = 7;
            // 
            // txtTendoituong
            // 
            this.txtTendoituong.Location = new System.Drawing.Point(115, 129);
            this.txtTendoituong.Name = "txtTendoituong";
            this.txtTendoituong.Size = new System.Drawing.Size(133, 20);
            this.txtTendoituong.TabIndex = 8;
            // 
            // DataGridView_DoiTuong
            // 
            this.DataGridView_DoiTuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DoiTuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Madoituong,
            this.Tendoituong});
            this.DataGridView_DoiTuong.Location = new System.Drawing.Point(77, 186);
            this.DataGridView_DoiTuong.Name = "DataGridView_DoiTuong";
            this.DataGridView_DoiTuong.Size = new System.Drawing.Size(249, 156);
            this.DataGridView_DoiTuong.TabIndex = 9;
            this.DataGridView_DoiTuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_DoiTuong_CellClick);
            this.DataGridView_DoiTuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_DoiTuong_CellContentClick);
            // 
            // Madoituong
            // 
            this.Madoituong.DataPropertyName = "Madoituong";
            this.Madoituong.HeaderText = "Mã Đối Tượng";
            this.Madoituong.Name = "Madoituong";
            // 
            // Tendoituong
            // 
            this.Tendoituong.DataPropertyName = "Tendoituong";
            this.Tendoituong.HeaderText = "Tên Đối Tượng";
            this.Tendoituong.Name = "Tendoituong";
            // 
            // FrmDoiTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_DoiTuong);
            this.Controls.Add(this.txtTendoituong);
            this.Controls.Add(this.txtMadoituong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmDoiTuong";
            this.Text = "FrmDoiTuong";
            this.Load += new System.EventHandler(this.FrmDoiTuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DoiTuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadoituong;
        private System.Windows.Forms.TextBox txtTendoituong;
        private System.Windows.Forms.DataGridView DataGridView_DoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madoituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendoituong;
    }
}