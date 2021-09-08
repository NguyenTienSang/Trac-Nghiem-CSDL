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
    public partial class FormThaoTacSV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormThaoTacSV()
        {
            InitializeComponent();
            btnTHI.Enabled = btnXemKetQua.Enabled = btnTraCuuDiem.Enabled = btnDangXuat.Enabled = true;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnTHI_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuanBiThi));
            if (frm != null) frm.Activate();
            else
            {
                btnTHI.Enabled = btnXemKetQua.Enabled = btnTraCuuDiem.Enabled = btnDangXuat.Enabled = false;
                FormChuanBiThi f = new FormChuanBiThi();
                f.MdiParent = this;
                f.Show();
                Program.frmChuanBiThi = new FormChuanBiThi();
                Program.frmChuanBiThi.Activate();

                Program.frmChuanBiThi.MASV.Text = "Mã sinh viên: " + Program.username;
                Program.frmChuanBiThi.HOTEN.Text = "Họ tên sinh viên: " + Program.mHoten;
                Program.frmChuanBiThi.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmChuanBiThi.MALOP.Text = "Mã lớp: " + Program.svMalop;
                Program.frmChuanBiThi.TENLOP.Text = "Tên lớp: " + Program.svTenlop;
            }
        }

        private void btnTraCuuDiem_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btnXemKetQua_ItemClick(object sender, ItemClickEventArgs e)
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
                Program.frmThaoTacSV.Close();
                FormDangNhap f = new FormDangNhap();
                //f.MdiParent = this;

                f.Show();


            }



            }
    }
}