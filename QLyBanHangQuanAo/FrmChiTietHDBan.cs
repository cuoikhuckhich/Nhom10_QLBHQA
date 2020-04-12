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
    public partial class FrmChiTietHDBan : Form
    {
        DataTable tblCTHDBan;
        public FrmChiTietHDBan()
        {
            InitializeComponent();
        }

        private void FrmChiTietHDBan_Load(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = false;
            loadDataToGridView();

        }
        private void loadDataToGridView()
        {
            string sql = "Select * From ChiTietHDBan";
            tblCTHDBan = Class.Functions.GetDataToTable(sql);
            dataGridView_ChiTietHDBan.DataSource = tblCTHDBan;
        }
        private void resetvalues()
        {
            txtGiamGia.Text = "";
            txtMaQuanAo.Text = "";
            txtSoHDBan.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
        private void dataGridView_ChiTietHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiamGia.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Giamgia"].Value.ToString();
            txtMaQuanAo.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Maquanao"].Value.ToString();
            txtSoHDBan.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["SoHDB"].Value.ToString();
            txtSoLuong.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Soluong"].Value.ToString();
            txtThanhTien.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Thanhtien"].Value.ToString();
            txtSoHDBan.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = "";
            txtMaQuanAo.Text = "";
            txtSoHDBan.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtSoHDBan.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ChiTietHDBan where SoHDB'" + txtSoHDBan.Text + "'";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoHDBan.Text == "")
            {
                MessageBox.Show("bạn cần nhập số HĐ Bán");
                txtSoHDBan.Focus();
                return;

            }
            if (txtMaQuanAo.Text == "")
            { MessageBox.Show("bạn cần nhập mã quần áo");
                txtMaQuanAo.Focus();
                return;
            }
            if (txtGiamGia.Text == "")
            {
                MessageBox.Show("bạn cần nhập mã giảm giá");
                txtGiamGia.Focus();
                return;

               
            }
            if ( txtSoLuong .Text == "")
            {
                MessageBox.Show("bạn cần nhập số lượng");
                txtSoLuong.Focus();
                return;

            }
            if (txtThanhTien .Text =="")
            {
                MessageBox.Show("Bạn cần nhập thành tiền");
                txtThanhTien.Focus();
                return;

            }
            string sql = " insert into ChiTietHDBan values(' " + txtSoHDBan.Text + "','" + txtMaQuanAo.Text + "','" + txtThanhTien .Text + "')" ;
            if (txtGiamGia.Text != "")
                sql = sql + ", " + txtGiamGia.Text.Trim();
            if (txtSoLuong.Text != "")
                sql = sql + "," + txtSoLuong.Text.Trim();
            sql = sql + ")";
            Class.Functions.RunSql(sql);
            
            loadDataToGridView();
            resetvalues();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = true;
            txtMaQuanAo.Enabled = true;
            string sql = "update ChiTietHDBan set soHDB= '" +txtSoHDBan +"'Soluong'"+ txtSoLuong.Text + "', Maquanao = '" + txtMaQuanAo.Text + "' Thanhtien'" + txtThanhTien.Text + "'Giamgia '" + txtGiamGia.Text + "' where (SoHDB = '" + txtSoHDBan.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
