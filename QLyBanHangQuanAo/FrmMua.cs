using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyBanHangQuanAo
{
    public partial class FrmMua : Form
    {
        DataTable tblMua;
        public FrmMua()
        {
            InitializeComponent();
        }

        private void FrmMua_Load(object sender, EventArgs e)
        {
            txtMamua.Enabled = false;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql = "Select * from Mua";
            tblMua = Class.Functions.GetDataToTable(sql);
            DataGridView_Mua.DataSource = tblMua;
        }

        private void DataGridView_Mua_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMamua.Text = DataGridView_Mua.CurrentRow.Cells["Mamua"].Value.ToString();
            txtTenmua.Text = DataGridView_Mua.CurrentRow.Cells["Tenmua"].Value.ToString();
            txtMamua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamua.Text = "";
            txtTenmua.Text = "";
            txtMamua.Enabled = true;
        }
        private void resetvalue()
        {
            txtMamua.Text = "";
            txtTenmua.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMua.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenmua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên mùa ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmua.Focus();
                return;
            }
            sql = "UPDATE Mua SET Mamua=N'" + txtMamua.Text.Trim() + "',Tenmua=N'" + txtTenmua.Text.Trim() + "' Where (Mamua=N'" + txtMamua.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Mã mùa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamua.Focus();
                return;
            }
            if (txtTenmua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ten mùa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmua.Focus();
                return;
            }
            sql = "select Mamua from Mua Where Mamua=N'" + txtMamua.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Mùa  đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamua.Focus();
                txtMamua.Text = "";
                return;
            }
            sql = "insert into Mua values('" + txtMamua.Text + "','" + txtTenmua.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMua.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Mua Where Mamua=N'" + txtMamua.Text + "'";
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
