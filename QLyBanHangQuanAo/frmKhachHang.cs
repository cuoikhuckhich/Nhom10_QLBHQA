using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyBanHangQuanAo.Class;

namespace QLyBanHangQuanAo
{
    public partial class frmKhachHang : Form
    {
        DataTable tblKH;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from KhachHang";
            tblKH = Class.Functions.GetDataToTable(sql);
            DataGridView_KhachHang.DataSource = tblKH;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //nút lưu
        {
            string sql;
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }

            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }
            sql = "SELECT MaKhach FROM KhachHang WHERE MaKhach=N'" + txtMaKH.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải chọn mã khách hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                txtMaKH.Text = "";
                return;
            }
            sql = "insert into KhachHang(Makhach,Tenkhach,Diachi,Dienthoai) values('" + txtMaKH.Text.Trim() + "','" + txtTenKH.Text.Trim()
                + "','" + txtDiaChi.Text.Trim() + "','" + txtDienThoai.Text.Trim() + "')";

            Class.Functions.RunSql(sql);
            loadDataGridView();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            loadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaKH.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = " UPDATE KhachHang SET Makhach=N'" + txtMaKH.Text.Trim() + "',Tenkhach =N'" + txtTenKH.Text.Trim() + "',Diachi =N'" + txtDiaChi.Text.Trim() +
                   "' ,Dienthoai=N'" + txtDienThoai.Text.Trim() + "' Where (Makhach=N'" + txtMaKH.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE KhachHang Where MaKhach=N'" + txtMaKH.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = DataGridView_KhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = DataGridView_KhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = DataGridView_KhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = DataGridView_KhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaKH.Enabled = false;
        }
    }
}
