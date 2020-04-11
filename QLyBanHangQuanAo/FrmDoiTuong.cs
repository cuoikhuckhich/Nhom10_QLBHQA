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
    public partial class FrmDoiTuong : Form
    {
        DataTable tblDT;

        public FrmDoiTuong()
        {
            InitializeComponent();
        }

        private void FrmDoiTuong_Load(object sender, EventArgs e)
        {
            txtMadoituong.Enabled = false;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql = "Select * from DoiTuong";
            tblDT = Class.Functions.GetDataToTable(sql);
            DataGridView_DoiTuong.DataSource = tblDT;
        }

        private void DataGridView_DoiTuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_DoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMadoituong.Text = DataGridView_DoiTuong.CurrentRow.Cells["Madoituong"].Value.ToString();
            txtTendoituong.Text = DataGridView_DoiTuong.CurrentRow.Cells["Tendoituong"].Value.ToString();
            txtMadoituong.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMadoituong.Text = "";
            txtTendoituong.Text = "";
            txtMadoituong.Enabled = true;
        }
        private void resetvalue()
        {
            txtMadoituong.Text = "";
            txtTendoituong.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTendoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên đối tượng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendoituong.Focus();
                return;
            }
            sql = "UPDATE DoiTuong SET Madoituong=N'" + txtMadoituong.Text.Trim() + "',Tendoituong=N'" + txtTendoituong.Text.Trim() + "' Where (Madoituong=N'" + txtMadoituong.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Ma đối tượng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadoituong.Focus();
                return;
            }
            if (txtTendoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ten đối tượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendoituong.Focus();
                return;
            }
            sql = "select Madoituong from DoiTuong Where Madoituong=N'" + txtMadoituong.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đối tượng  đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadoituong.Focus();
                txtMadoituong.Text = "";
                return;
            }
            sql = "insert into DoiTuong values('" + txtMadoituong.Text + "','" + txtTendoituong.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE DoiTuong Where Madoituong=N'" + txtMadoituong.Text + "'";
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
