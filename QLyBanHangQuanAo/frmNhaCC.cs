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
    public partial class frmNhaCC : Form
    {
        DataTable tblNCC;
        public frmNhaCC()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from NhaCungCap";
            tblNCC = Class.Functions.GetDataToTable(sql);
            DataGridView_NCC.DataSource = tblNCC;
        }
        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            loadDataGridView();
        }

        private void DataGridView_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNCC.Text = DataGridView_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = DataGridView_NCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = DataGridView_NCC.CurrentRow.Cells["Diachi"].Value.ToString();
            txtDienThoai.Text = DataGridView_NCC.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaNCC.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaNCC.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = " UPDATE NhaCungCap SET MaNCC=N'" + txtMaNCC.Text.Trim() + "',TenNCC =N'" + txtTenNCC.Text.Trim() + "',DiaChi =N'" + txtDiaChi.Text.Trim() +
                   "' ,DienThoai =N'" + txtDienThoai.Text.Trim() + "' Where (MaNCC=N'" + txtMaNCC.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhaCungCap Where MaNCC=N'" + txtMaNCC.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }

            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }
            sql = "SELECT MaNCC FROM NhaCungCap WHERE MaNCC=N'" + txtMaNCC.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã tồn tại, bạn phải chọn mã nhà cung cấp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            sql = "insert into NhaCungCap(MaNCC,TenNCC,Diachi,DienThoai) values(N'" + txtMaNCC.Text.Trim() + "',N'" + txtTenNCC.Text.Trim()
                + "',N'" + txtDiaChi.Text.Trim() + "',N'" + txtDienThoai.Text.Trim() + "')";

            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalues();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
