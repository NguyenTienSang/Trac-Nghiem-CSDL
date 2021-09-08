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
    public partial class FormDSDK : DevExpress.XtraEditors.XtraForm
    {

        Int32 vitri;
        public static string maMH = "";
        public static string maLop = "";
        private bool isDangThem = false;
        private bool isDangSua = false;
        public FormDSDK()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormDSDK_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            txtMaMH.ReadOnly = txtMaLop.ReadOnly = true;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            txtMaGV.ReadOnly = true;
            btnMH.Enabled = btnLop.Enabled  = btnRefresh.Enabled= false;

            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                //gcDSDK.Enabled = false;
            }
            gcInfo.Visible = false;

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                cmbTrinhDo.SelectedIndex = 1; cmbTrinhDo.SelectedIndex = 0;
                cmbLan.SelectedIndex = 1; cmbLan.SelectedIndex = 0;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsGVDK.Position;
            gcDSDK.Enabled = false;
            bdsGVDK.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled =btnRefresh.Enabled = true;
            btnMH.Enabled = btnLop.Enabled = true;


            cmbTrinhDo.SelectedIndex = cmbLan.SelectedIndex = 1;
            cmbTrinhDo.SelectedIndex = cmbLan.SelectedIndex = 0;

            dptNgayThi.DateTime = DateTime.Now;

            SpinSoCauThi.Value = SpinTG.Value = 10;
            txtMaGV.Text = Program.username;
            txtMaMH.Focus();
        }

     

        private void btnMH_Click(object sender, EventArgs e)
        {
            //txtMaMH.Text = "";
            //FormChonMonHoc f = new FormChonMonHoc();
            //f.Show();
            gcInfo.Visible = true;
            gcMonHoc.Visible = true;
            gcLop.Visible = false;
            gcMonHoc.Dock = DockStyle.Fill;
        }

        private void btnMH_Leave(object sender, EventArgs e)
        {
            txtMaMH.Text = maMH;
            if (!txtMaMH.Focused)
            {
                txtMaMH.Focus();
            }
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            gcInfo.Visible = true;
            gcMonHoc.Visible = false;
            gcLop.Visible = true;
            gcLop.Dock = DockStyle.Fill;
        }

        private void btnLop_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã lớp : " + maLop, "Thông báo", MessageBoxButtons.OK);
            txtMaLop.Text = maLop;
            if (!txtMaLop.Focused)
            {
                txtMaLop.Focus();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count == 0)
            {
                MessageBox.Show("Không có lịch thi để xóa!", "Thông báo", MessageBoxButtons.OK);
                btnXoa.Enabled = false;
            }


            string strKtLichDaThi = "exec SP_KTLICHDATHI'" + txtMaMH.Text + "', N'" + txtMaLop.Text + "', " + cmbLan.Text + "";

            if (Program.ExecSqlNonQuery(strKtLichDaThi) == 1)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa lịch thi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        bdsGVDK.RemoveCurrent();
                        this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.GVDKTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa mục giáo viên đăng ký. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                        return;
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnMH.Enabled = btnLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled= btnRefresh.Enabled = true;
            isDangSua = true;
        }


        private int SoSanhNgayThi(string date1, string date2) //ktra theo thu tu: nam -> thang -> ngay
        {
            string[] s1 = date1.Split('/'); //format là  mm/dd/yyyy
            string[] s2 = date2.Split('/');//Thời gian hiện tại
            //So sánh năm
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }

            //nếu như đã đầy đủ thông tin
            //----ktra tính ngày thi và ngày hiện tại-----start
            string inputDate = dptNgayThi.Text;
            string ngayHienTai = DateTime.Now.ToShortDateString();
            if (SoSanhNgayThi(inputDate, ngayHienTai) == -1)
            {
                MessageBox.Show("Ngày thi phải lớn hơn hoặc bằng ngày hiện tại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            //----ktra ngày thi và ngày hiện tại-----end

            //------ktra thông tin đăng ký------start(đã lập hay chưa, nếu là dky lần 2 thì ktra thêm đã thi lần 1 chưa, ngày lần 2 có lớn hơn ngày lần 1 ko) 

         
            if(isDangThem == true)
            {

                string strKTLapLichThi;
                strKTLapLichThi = "EXEC SP_KTLAPLICHTHI N'" + txtMaMH.Text.Trim() + "', N'" + txtMaLop.Text.Trim() + "', " + cmbLan.SelectedItem.ToString().Trim() + ", '" + inputDate + "'";
                if (Program.ExecSqlNonQuery(strKTLapLichThi) == 1)
                {
                    return;
                }
                //------ktra thông tin đăng ký------end

                try
                {
                    string sqlLapDeThi = "EXEC SP_LAPLICHTHI N'" + txtMaMH.Text.Trim() + "', N'" + cmbTrinhDo.Text.Trim() + "', " + SpinSoCauThi.Text.Trim() + "";

                    if (Program.ExecSqlNonQuery(sqlLapDeThi) == 0)
                    {
                        bdsGVDK.EndEdit();
                        bdsGVDK.ResetCurrentItem();
                        this.GVDKTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);

                        btnMH.Enabled = btnLop.Enabled = false;
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        isDangThem = false;
                        gcDSDK.Enabled = true;
                        gcMonHoc.Visible = false;
                        gcLop.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi đăng ký thi\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                }
            }
            else if(isDangSua == true)
            {


                try
                {
                    bdsGVDK.EndEdit();
                    bdsGVDK.ResetCurrentItem();
                    this.GVDKTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Lỗi ghi đăng ký thi\n" + a.Message, "", MessageBoxButtons.OK);
                }
               

                btnMH.Enabled = btnLop.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                isDangSua = false;
                gcDSDK.Enabled = true;
                gcMonHoc.Visible = false;
                gcLop.Visible = false;
            }
           
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.CancelEdit();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            isDangThem = isDangSua = false;
            gcDSDK.Enabled = true;
        }



        private void gcMonHoc_Click_1(object sender, EventArgs e)
        {
            txtMaMH.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString();
            //MessageBox.Show("", txtMaMH.Text, MessageBoxButtons.OK);
        }

        private void gcLop_Click_1(object sender, EventArgs e)
        {
            txtMaLop.Text = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString();
           // MessageBox.Show("", txtMaLop.Text, MessageBoxButtons.OK);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(isDangThem)
            {
                txtMaMH.Text = txtMaLop.Text = "";
                SpinTG.Value = SpinSoCauThi.Value = 20;
                cmbLan.SelectedIndex = 0;
                cmbTrinhDo.SelectedIndex = 0;
                dptNgayThi.Text = DateTime.Now.ToShortDateString();
      
            }
            else if(isDangSua)
            {
                SpinTG.Value = SpinSoCauThi.Value = 20;
                cmbLan.SelectedIndex = 0;
                cmbTrinhDo.SelectedIndex = 0;
                dptNgayThi.Text = DateTime.Now.ToShortDateString();
            }
          
        }
    }
}