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
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class FormXemKetQua : DevExpress.XtraEditors.XtraForm
    {

        Int32 vitri;
        public static string maMH = "", ngay = "";

        public FormXemKetQua()
        {
            InitializeComponent();

        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = "";
            gcInfo.Visible = true;
            gcMonHoc.Visible = true;
            gcSV.Visible = false;
            //gcMonHoc.Dock = DockStyle.Fill;
        }



        private void FormXemKetQua_Load(object sender, EventArgs e)
        {
            gcSV.Visible = false;
            txtMaSV.ReadOnly = txtHoTen.ReadOnly = txtMaLop.ReadOnly = txtTenLop.ReadOnly = txtMaMH.ReadOnly = true;
            if (Program.mGroup == "SINHVIEN")
            {
                DS.EnforceConstraints = false;
                this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MonHocTableAdapter.Fill(this.DS.MONHOC);
                btnChonSV.Enabled = false;
                txtMaSV.Text = Program.username;
                txtHoTen.Text = Program.mHoten;
                txtMaLop.Text = Program.svMalop;
                txtTenLop.Text = Program.svTenlop;
                cmbLan.SelectedIndex = 1;
                cmbLan.SelectedIndex = 0;
                txtMaMH.Focus();
                gcInfo.Visible = false;
            }
            else
            {
                DS.EnforceConstraints = false;
                this.SinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);

                this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MonHocTableAdapter.Fill(this.DS.MONHOC);
                cmbLan.SelectedIndex = 1;
                cmbLan.SelectedIndex = 0;
                gcInfo.Visible = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Thông tin sinh viên đang trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Môn học đang trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            string sql = "EXEC SP_KTKETQUATHINULL '" + txtMaSV.Text + "', '" + txtMaMH.Text + "', " + Int32.Parse(cmbLan.SelectedItem.ToString()) + "";


            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                rpt_XemKetQuaThi rpt = new rpt_XemKetQuaThi(txtMaSV.Text, maMH, Int32.Parse(cmbLan.SelectedItem.ToString()));
                rpt.lblLop.Text = txtTenLop.Text;
                rpt.lblHoTen.Text = txtHoTen.Text;
                rpt.lblMon.Text = txtMaMH.Text;
                rpt.lblLan.Text = cmbLan.SelectedItem.ToString();
                rpt.lblNgay.Text = ngay;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnChonSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            gcInfo.Visible = true;
            gcMonHoc.Visible = false;
            gcSV.Visible = true;
            //gcSV.Dock = DockStyle.Fill;
        }


        private void gvMonHoc_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString();
            //MessageBox.Show("MaSV: "+ txtMaSV.Text.Trim()+ " MaMH : "+ txtMaMH.Text.Trim()+" Lan :  "+ Int32.Parse(cmbLan.SelectedItem.ToString()), "Lỗi", MessageBoxButtons.OK);
            string layngay = "select Ngaythi from BangDiem Where MASV='" + txtMaSV.Text.Trim() + "'and MAMH='" + txtMaMH.Text.Trim() + "'and LAN=" + Int32.Parse(cmbLan.SelectedItem.ToString()) + "";
            //MessageBox.Show("", layngay, MessageBoxButtons.OK);
            Program.myReader = Program.ExecSqlDataReader(layngay);
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("", "Môn này chưa thi", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Read();

            ngay = Program.myReader.GetDateTime(0).ToString();

            Program.myReader.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = gvSV.GetRowCellValue(gvSV.FocusedRowHandle, "MASV").ToString();

            string strTimTTSV = "exec SP_TIMTTSV '" + txtMaSV.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strTimTTSV);
            Program.myReader.Read();
            //MessageBox.Show("Đã thêm thành công" + Program.myReader.GetString(5), "", MessageBoxButtons.OK);
            //Program.username = Program.myReader.GetString(0);//Username là mã sinh viên (Có 2 cách lấy mã sv)
            txtHoTen.Text = Program.myReader.GetString(1).Trim() + " " + Program.myReader.GetString(2).Trim();
            txtMaLop.Text = Program.myReader.GetString(5);
            txtTenLop.Text = Program.myReader.GetString(6);
            Program.myReader.Close();
            Program.conn.Close();
        }

     

        


       



    }
}