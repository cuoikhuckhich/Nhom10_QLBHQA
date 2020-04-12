using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLyBanHangQuanAo.Class;
using System.Windows.Forms;


namespace QLyBanHangQuanAo
{
    public partial class FrmHDNhap : Form
    {
        DataTable tblNhap;
        public FrmHDNhap()
        {
            InitializeComponent();
        }

        private void FrmHDNhap_Load(object sender, EventArgs e)
        {
            txtSoHDNhap.Enabled = false;
            loadDataToGridView();
        }
        private void resetvalues()
        {
            
            txtMaNCC.Text = "";
            txtMaNV.Text = "";
            txtNgayNhap.Text = "";
            txtSoHDNhap.Text = "";
            txtTongTien.Text = "";
        }
        private void loadDataToGridView()
        {
            string sql = "Select * From HoaDonNhap";
            tblNhap = Class.Functions.GetDataToTable(sql);
            dataGridView_HDNhap.DataSource = tblNhap;
            
        }

        private void dataGridView_HDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridView_HDNhap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtMaNV.Text = dataGridView_HDNhap.CurrentRow.Cells["MaNV"].Value.ToString();
            txtNgayNhap.Text = dataGridView_HDNhap.CurrentRow.Cells["Ngaynhap"].Value.ToString();
            txtSoHDNhap.Text = dataGridView_HDNhap.CurrentRow.Cells["SoHDN"].Value.ToString();
            txtTongTien.Text = dataGridView_HDNhap.CurrentRow.Cells["TongTien"].Value.ToString();
            txtSoHDNhap.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtMaNV.Text = "";
            txtNgayNhap.Text = "";
            txtSoHDNhap.Text = "";
            txtTongTien.Text = "";
            txtSoHDNhap.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HoaDonNhap where soHDN'" + txtSoHDNhap.Text + "'";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoHDNhap.Enabled = true;
            string sql = "update HoaDonNhap set soHDN'" +txtSoHDNhap +"'MaNV'" + txtMaNV.Text + "',MaNCC='" + txtMaNCC.Text + "'Ngaynhap'" + txtNgayNhap + "'TongTien'" + txtTongTien + "'where (soHDN'" + txtSoHDNhap.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoHDNhap .Text =="")
            {
                MessageBox.Show("Bạn cần nhập soHDN");
                txtSoHDNhap.Focus();
                return;
            }
            if (txtMaNCC .Text =="")
            {
                MessageBox.Show("Bạn cần nhập mã NCC");
                txtMaNCC.Focus();
                return;
            }
            if (txtMaNV .Text =="")
            {
                MessageBox.Show("Bạn cần nhập mã NV");
                txtMaNV.Focus();
                return;
            }
            if (txtNgayNhap .Text =="")
            {
                MessageBox.Show("bạn cần nhập ngày nhập hàng");
                txtNgayNhap.Focus();
                return;
            }
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("bạn cần nhập tổng tiền");
                txtTongTien.Focus();
                return;
            }
            string sql = "insert into HoaDonNhap values(' " + txtMaNCC.Text + "','" + txtMaNV.Text + "','" + txtNgayNhap.Text + "','" + txtTongTien.Text + "','" + txtSoHDNhap.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }
       
    }
}
