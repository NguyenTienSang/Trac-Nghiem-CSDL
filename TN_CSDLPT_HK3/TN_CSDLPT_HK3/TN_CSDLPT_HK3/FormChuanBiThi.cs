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
    public partial class FormChuanBiThi : DevExpress.XtraEditors.XtraForm
    {
        public FormChuanBiThi()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
       

        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            bdsGVDK.Filter = "MALOP = '" + Program.svMalop + "'";
            //MessageBox.Show("Ngày thi : "+ DateTime.Now.ToShortDateString())
            //bdsGVDK.Filter = "NGAYTHI = '" + DateTime.Now.ToShortDateString() + "' AND MALOP = '" + Program.svMalop.Trim() + "'";
            
            //gvThi.FocusedRowHandle = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Program.frmThaoTacSV = new FormThaoTacSV();
            Program.frmThaoTacSV.Activate();
            Program.frmThaoTacSV.Show();
            Program.frmThaoTacSV.MASV.Text = "Mã sinh viên: " + Program.username;
            Program.frmThaoTacSV.HOTEN.Text = "Họ tên sinh viên: " + Program.mHoten;
            Program.frmThaoTacSV.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.frmThaoTacSV.MALOP.Text = "Mã lớp: " + Program.svMalop;
            Program.frmThaoTacSV.TENLOP.Text = "Tên lớp: " + Program.svTenlop;
            this.Visible = false;
        }


        private int SoSanhNgayThi(string date1, string date2) //ktra theo thu tu: nam -> thang -> ngay
        {
            string[] s1 = date1.Split('/'); //format là  mm/dd/yyyy
            string[] s2 = date2.Split('/');//Thời gian hiện tại
            //So sánh năm
            //MessageBox.Show("năm 1 : "+ s1[2]+ " năm 2 : "+ s2[2], "Lỗi", MessageBoxButtons.OK);
            if (int.Parse(s1[2]) > int.Parse(s2[2]))
            {
                return 1;
            }
            else if (int.Parse(s1[2]) < int.Parse(s2[2]))
            {
                return -1;
            }
            else
            {
                //So sánh tháng
                if (int.Parse(s1[0]) > int.Parse(s2[0]))
                {
                    return 1;
                }
                else if (int.Parse(s1[0]) < int.Parse(s2[0]))
                {
                    return -1;
                }
                else
                {
                    //So sánh ngày
                    if (int.Parse(s1[1]) > int.Parse(s2[1]))
                    {
                        return 1;
                    }
                    else if (int.Parse(s1[1]) < int.Parse(s2[1]))
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public static string FormatDate(string date)
        {
            string[] t = date.Split(' ');
            string[] datenew = t[0].Split('/');
            return datenew[0] + '/' + datenew[1] + '/' + datenew[2];
        }
        private void btnThi_Click(object sender, EventArgs e)
        {

            string NgayThi = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "NGAYTHI").ToString().Trim();
            if (SoSanhNgayThi(FormatDate(NgayThi), DateTime.Now.ToString("MM/dd/yyyy")) == -1)
                {
                MessageBox.Show("Môn này đã quá hạn", "", MessageBoxButtons.OK);
                return;
            }
            else if (SoSanhNgayThi(FormatDate(NgayThi), DateTime.Now.ToString("MM/dd/yyyy")) == 1)
            {
                MessageBox.Show("Môn này chưa tới ngày thi", "", MessageBoxButtons.OK);
                return;
            }
            //string NgayThi2 =  Program.FormatDate(NgayThi);
            //MessageBox.Show("", "Ngày thi : " + NgayThi2, MessageBoxButtons.OK);

            FormThi.maMH = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MAMH").ToString().Trim();
            FormThi.TrinhDo = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "TRINHDO").ToString().Trim();
            FormThi.Lan = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "LAN").ToString());
            FormThi.maLop = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "MALOP").ToString().Trim();
            FormThi.ngayThi = gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "NGAYTHI").ToString().Trim();
            FormThi.thoiGian = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "THOIGIAN").ToString());
            FormThi.soCau = Int32.Parse(gvThi.GetRowCellValue(gvThi.FocusedRowHandle, "SOCAUTHI").ToString());

            

            //Program.frmThi = new FormThi();
            //Program.frmThi.Activate();
            //Program.frmThi.Show();
            //this.Visible = false;

            Form frm = this.CheckExists(typeof(FormThi));
            if (frm != null) frm.Activate();
            else
            {
                FormThi f = new FormThi();
                f.MdiParent = Program.frmThaoTacSV;
                f.Show();

            }



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