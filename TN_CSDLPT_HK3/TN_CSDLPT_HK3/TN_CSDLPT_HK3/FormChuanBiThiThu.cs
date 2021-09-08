using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TN_CSDLPT_HK3
{
    public partial class FormChuanBiThiThu : DevExpress.XtraEditors.XtraForm
    {
        public FormChuanBiThiThu()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChuanBiThiThu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            FormThiThu.maMH = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MAMH").ToString().Trim();
            FormThiThu.TrinhDo = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "TRINHDO").ToString().Trim();
            FormThiThu.Lan = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "LAN").ToString());
            FormThiThu.maLop = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MALOP").ToString().Trim();
            FormThiThu.ngayThi = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "NGAYTHI").ToString().Trim();
            FormThiThu.thoiGian = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "THOIGIAN").ToString());
            FormThiThu.soCau = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "SOCAUTHI").ToString());

            Program.frmThiThu = new FormThiThu();
            Program.frmThiThu.Activate();
            Program.frmThiThu.Show();
            this.Visible = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmMain = new btnXemDSDKTHI();
            Program.frmMain.Activate();
            Program.frmMain.Show();
            Program.frmMain.MAGV.Text = "Mã GV: " + Program.username;
            Program.frmMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmMain.NHOM.Text = "Nhóm: " + Program.mGroup;
            this.Visible = false;
        }

        private void gvThi_Click(object sender, EventArgs e)
        {
            FormThi.maMH = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MAMH").ToString().Trim();
            FormThi.TrinhDo = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "TRINHDO").ToString().Trim();
            FormThi.Lan = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "LAN").ToString());
            FormThi.maLop = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MALOP").ToString().Trim();
            FormThi.ngayThi = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "NGAYTHI").ToString().Trim();
            FormThi.thoiGian = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "THOIGIAN").ToString());
            FormThi.soCau = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "SOCAUTHI").ToString());
        }
    }
}