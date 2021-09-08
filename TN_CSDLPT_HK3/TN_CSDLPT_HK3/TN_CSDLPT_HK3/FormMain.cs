using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace TN_CSDLPT_HK3
{
    public partial class btnXemDSDKTHI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public btnXemDSDKTHI()
        {
            InitializeComponent();
            if (Program.mGroup == "GIANGVIEN")
            {
                btnKHOA.Enabled = btnLOP.Enabled = btnSV.Enabled = btnDSDK.Enabled = btnBANGDIEM.Enabled = btnMONHOC.Enabled
                 = btnTaoTaiKhoan.Enabled = btnGV.Enabled  = false;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN")
            {
                //btnTAOLOGIN.Enabled = false;
                return;
            }
        }

        private void btnKHOA_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FormKhoa f = new FormKhoa();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnLOP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSV));
            if (frm != null) frm.Activate();
            else
            {
                FormSV f = new FormSV();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnDSDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDSDK));
            if (frm != null) frm.Activate();
            else
            {
                FormDSDK f = new FormDSDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBANGDIEM_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormBangDiem f = new FormBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMONHOC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

       

      

        private void btnBODE_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBoDe));
            if (frm != null) frm.Activate();
            else
            {
                FormBoDe f = new FormBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

       

        private void btnGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGV));
            if (frm != null) frm.Activate();
            else
            {
                FormGV f = new FormGV();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnThiThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuanBiThiThu));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmChuanBiThiThu = new FormChuanBiThiThu();
                Program.frmChuanBiThiThu.Activate();
                Program.frmChuanBiThiThu.MAGV.Text = "Mã GV: " + Program.username;
                Program.frmChuanBiThiThu.HOTEN.Text = "Họ tên: " + Program.mHoten;
                Program.frmChuanBiThiThu.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmChuanBiThiThu.Show();
                this.Visible = false;
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.username = "";
                Program.mlogin = "";
                Program.password = "";
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }
                Program.frmMain.Close();
                FormDangNhap f = new FormDangNhap();
                //f.MdiParent = this;

                f.Show();
            }

        }

        private void btnXemDSDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemDSDK));
            if (frm != null) frm.Activate();
            else
            {
                FormXemDSDK f = new FormXemDSDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQuaThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemKetQua));
            if (frm != null) frm.Activate();
            else
            {
                FormXemKetQua f = new FormXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}