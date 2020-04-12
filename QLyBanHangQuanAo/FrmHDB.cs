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
    public partial class FrmHDB : Form
    {
        DataTable tblHDB;
        public FrmHDB()
        {
            InitializeComponent();
        }

        private void FrmHDB_Load(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = false ;
            loadDataToGridView();
        }
        private void resetvalues()
        {
            txtSoHDBan.Text = "";
            txtMaKhach.Text = "";
            txtMaNV.Text = "";
            txtNgayBan.Text = "";
            txtTongTien.Text = "";
            
        }
        private void loadDataToGridView()
        {
            string sql = "Select * From HoaDonBan";
            tblHDB = Class.Functions.GetDataToTable(sql);
            dataGridView_HDBan.DataSource = tblHDB;
            
        }

        private void dataGridView_HDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dataGridView_HDBan.CurrentRow.Cells["Makhach"].Value.ToString();
            txtMaNV.Text = dataGridView_HDBan.CurrentRow.Cells["MaNV"].Value.ToString();
            txtNgayBan.Text = dataGridView_HDBan.CurrentRow.Cells["Ngayban"].Value.ToString();
            txtSoHDBan.Text = dataGridView_HDBan.CurrentRow.Cells["SoHDB"].Value.ToString();
            txtTongTien.Text = dataGridView_HDBan.CurrentRow.Cells["Tongtien"].Value.ToString();
            txtSoHDBan.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtSoHDBan.Text = "";
            txtMaKhach.Text = "";
            txtMaNV.Text = "";
            txtNgayBan.Text = "";
            txtTongTien.Text = "";
            txtSoHDBan.Enabled = true;
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HoaDonBan where soHDB'" + txtSoHDBan.Text + "'";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = true;
            string sql = "update HoaDonBan set SoHDB'" +txtSoHDBan .Text +"'MaNV'"+ txtMaNV.Text + "',Makhach ='" + txtMaKhach.Text + "'Ngayban'" + txtNgayBan.Text + "'Tongtien'" + txtTongTien.Text + "'where ( soHDB ='" + txtSoHDBan.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
             
           if (txtSoHDBan .Text =="")
            {
                MessageBox.Show("bạn cần nhập số HDBan");
                txtSoHDBan.Focus();
                return;
            }
            if (txtNgayBan .Text =="")
            {
                MessageBox.Show("bạn cần nhập ngày bán");
                txtNgayBan.Focus();
                return;

            }
            if (txtMaNV .Text =="")
            {
                MessageBox.Show("bạn cần nhập mã NV");
                txtMaNV.Focus();
                return;

            }
            if (txtMaKhach  .Text =="")
            {
                MessageBox.Show("bạn cần nhập mã khách");
                txtMaKhach.Focus();
                return;

            }
            if (txtTongTien .Text =="")
            {
                MessageBox.Show("Bạn cần nhập tổng tiền");
                txtTongTien.Focus();
                return;
            }
            string sql = " insert into HoaDonBan values('" + txtSoHDBan.Text + "','" + txtMaKhach.Text + "','" + txtMaNV.Text + "','" + txtNgayBan.Text + "','" + txtTongTien.Text + "')";
             Class.Functions.RunSql(sql);
            loadDataToGridView();
           
            resetvalues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            

        }
    }
}
