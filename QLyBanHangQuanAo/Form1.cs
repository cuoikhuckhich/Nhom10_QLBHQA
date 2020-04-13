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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSanPham Sp = new FrmSanPham();
            Sp.MdiParent = this;
            Sp.Show();
           
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai TL = new frmTheLoai();
            TL.MdiParent = this;
            TL.Show();
        }

        private void cỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCo Fc = new FrmCo();
            Fc.MdiParent = this;
            Fc.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChatLieu cl = new FrmChatLieu();
            cl.MdiParent = this;
            cl.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Functions.Dungketnoi();
            Application.Exit();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void màuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMau m = new FrmMau();
            m.MdiParent = this;
            m.Show();
        }

        private void đốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiTuong dt = new FrmDoiTuong();
            dt.MdiParent = this;
            dt.Show();
        }

        private void mùaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMua M = new FrmMua();
            M.MdiParent = this;
            M.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDB  hDB  = new FrmHDB ();
            hDB.MdiParent = this;
            hDB.Show();
        }

        private void chiTiếtHDBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiTietHDBan  Ct = new FrmChiTietHDBan ();
            Ct.MdiParent = this;
            Ct.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDNhap  Hd = new FrmHDNhap ();
            Hd.MdiParent = this;
            Hd.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang cl = new frmKhachHang();
            cl.MdiParent = this;
            cl.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCC cl = new frmNhaCC();
            cl.MdiParent = this;
            cl.Show();
        }

        private void nơiSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoiSX cl = new frmNoiSX();
            cl.MdiParent = this;
            cl.Show();
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongViec cv = new frmCongViec();
            cv.MdiParent = this;
            cv.Show();
        }

        private void chiTiếtHDNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHDNhap ctn = new frmChiTietHDNhap();
            ctn.MdiParent = this;
            ctn.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }
    }
}
