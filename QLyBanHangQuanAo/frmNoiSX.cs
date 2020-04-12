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
    public partial class frmNoiSX : Form
    {
        DataTable tblNSX;

        public frmNoiSX()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtMaNSX.Text = "";
            txtTenNSX.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from NoiSanXuat";
            tblNSX = Class.Functions.GetDataToTable(sql);
            DataGridView_NoiSX.DataSource = tblNSX;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNSX.Text = "";
            txtTenNSX.Text = "";
            txtMaNSX.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NoiSanXuat Where MaNSX=N'" + txtMaNSX.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
            }

        }

        private void frmNoiSX_Load(object sender, EventArgs e)
        {
            txtMaNSX.Enabled = false;
            loadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NoiSanXuat SET MaNSX='" + txtMaNSX.Text + "',TenNSX='" + txtTenNSX.Text + "' Where (MaNSX='" + txtMaNSX.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập mã nhà sản xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNSX.Focus();
                return;
            }
            if (txtTenNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên nhà sản xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNSX.Focus();
                return;
            }
            sql = "select MaNSX from NoiSanXuat Where MaNSX=N'" + txtMaNSX.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã NSX đã có, bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNSX.Focus();
                txtMaNSX.Text = "";
                return;
            }
            sql = "insert into NoiSanXuat values('" + txtMaNSX.Text + "','" + txtTenNSX.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNSX.Text = DataGridView_NoiSX.CurrentRow.Cells["MaNSX"].Value.ToString();
            txtTenNSX.Text = DataGridView_NoiSX.CurrentRow.Cells["TenNSX"].Value.ToString();
            txtMaNSX.Enabled = false;
        }
    }
}
