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

namespace QLyBanHangQuanAo
{
    public partial class FrmMau : Form
    {
        DataTable tblMau;
        public FrmMau()
        {
            InitializeComponent();
        }

        private void FrmMau_Load(object sender, EventArgs e)
        {
            txtMamau.Enabled = false;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql = "Select * from Mau";
            tblMau = Class.Functions.GetDataToTable(sql);
            DataGridView_Mau.DataSource = tblMau;
        }

        private void DataGridView_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMamau.Text = DataGridView_Mau.CurrentRow.Cells["Mamau"].Value.ToString();
            txtTenmau.Text = DataGridView_Mau.CurrentRow.Cells["Tenmau"].Value.ToString();
            txtMamau.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamau.Text = "";
            txtTenmau.Text = "";
            txtMamau.Enabled = true;
        }
        private void resetvalue()
        {
            txtMamau.Text = "";
            txtTenmau.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenmau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên Màu ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmau.Focus();
                return;
            }
            sql = "UPDATE Mau SET Mamau=N'" + txtMamau.Text.Trim() + "',Tenmau=N'" + txtTenmau.Text.Trim() + "' Where (Mamau=N'" + txtMamau.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Ma Màu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamau.Focus();
                return;
            }
            if (txtTenmau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ten màu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmau.Focus();
                return;
            }
            sql = "select Mamau from Mau Where Mamau=N'" + txtMamau.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã màu đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamau.Focus();
                txtMamau.Text = "";
                return;
            }
            sql = "insert into Mau values('" + txtMamau.Text + "','" + txtTenmau.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Mau Where Mamau=N'" + txtMamau.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
