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
using QLyBanHangQuanAo.Class;

namespace QLyBanHangQuanAo
{
    public partial class frmChiTietHDNhap : Form
    {
        DataTable tblCTHDN;
        public frmChiTietHDNhap()
        {
            InitializeComponent();
        }

        private void resetvalue()
        {
            txtSoHDN.Text = "";
            txtMaquanao.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from ChiTietHDNhap";
            tblCTHDN = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCTHDN;
        }

        private void frmChiTietHDNhap_Load(object sender, EventArgs e)
        {
            txtSoHDN.Enabled = false;
            btnThem.Enabled = true;
            loadDataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetvalue();
            txtSoHDN.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtSoHDN.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoHDN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoHDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HĐ nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHDN.Focus();
                return;
            }
            if (txtMaquanao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quần áo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaquanao.Focus();
                return;
            }
            sql = "UPDATE ChiTietHDNHap SET Soluong =N'" + txtSoluong.Text.ToString() + "',Maquanao =N'" + txtMaquanao.Text.ToString() + "',Dongia =N'" + txtDongia.Text.ToString() + "',Giamgia =N'" + txtGiamgia.Text.ToString() + "',Thanhtien =N'" + txtThanhtien.Text.ToString() + "'   WHERE SoHDN=N'" + txtSoHDN.Text + "'";
            Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtSoHDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HDN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHDN.Focus();
                return;
            }
            if (txtMaquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quần áo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaquanao.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongia.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamgia.Focus();
                return;
            }
            if (txtThanhtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thành tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThanhtien.Focus();
                return;
            }
            sql = "SELECT SoHDN FROM ChiTietHDNHap WHERE SoHDN=N'" + txtSoHDN.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Số HĐN này đã có, bạn phải nhập số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHDN.Focus();
                txtSoHDN.Text = "";
                return;
            }
            sql = "INSERT INTO ChiTieHDNhap VALUES(N'" + txtSoHDN.Text + "',N'" + txtMaquanao.Text + "',N'" + txtSoluong.Text + "',N'" + txtDongia.Text + "',N'" + txtGiamgia.Text + "',N'" + txtThanhtien.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtSoHDN.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoHDN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ChiTietHDNhap Where SoHDN=N'" + txtSoHDN.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           txtMaquanao.Text = dataGridView1.CurrentRow.Cells["Maquanao"].Value.ToString();
            txtSoHDN.Text = dataGridView1.CurrentRow.Cells["SoHDN"].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongia.Text = dataGridView1.CurrentRow.Cells["Dongia"].Value.ToString();
            txtGiamgia.Text = dataGridView1.CurrentRow.Cells["Giamgia"].Value.ToString();
            txtThanhtien.Text = dataGridView1.CurrentRow.Cells["Thanhtien"].Value.ToString();
            txtSoHDN.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }

}
 
