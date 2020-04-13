using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLyBanHangQuanAo
{
    public partial class frmCongViec : Form
    {
        DataTable tblCV;
        public frmCongViec()
        {
            InitializeComponent();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string sql = "Select * from CongViec";
            tblCV = Class.Functions.GetDataToTable(sql);
            DataGridView_CongViec.DataSource = tblCV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                txtMaCV.Text = "";
                txtTenCV.Text = "";
                txtMaCV.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
            }

        }
        private void resetvalue()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên công việc ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCV.Focus();
                return;
            }
            sql = "UPDATE CongViec SET MaCV='" + txtMaCV.Text + "',TenCV='" + txtTenCV.Text + "' Where (MaCV='" + txtMaCV.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE CongViec Where MaCV=N'" + txtMaCV.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập Mã công việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCV.Focus();
                return;
            }
            if (txtTenCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập Tên công việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCV.Focus();
                return;
            }
            sql = "select MaCV from CongViec Where MaCV=N'" + txtMaCV.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã CV đã có, bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCV.Focus();
                txtMaCV.Text = "";
                return;
            }
            sql = "insert into CongViec values('" + txtMaCV.Text + "','" + txtTenCV.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_CongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = DataGridView_CongViec.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = DataGridView_CongViec.CurrentRow.Cells["TenCV"].Value.ToString();
            txtMaCV.Enabled = false;

        }
    }
}
