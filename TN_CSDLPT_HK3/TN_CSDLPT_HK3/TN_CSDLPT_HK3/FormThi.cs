using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;

namespace TN_CSDLPT_HK3
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {


        Dictionary<int, CauHoi> deThi = new Dictionary<int, CauHoi>();
        BindingSource bdsDethi;


        int socau;
        int soCauDung=0;
        int phut;
        int giay;
        double diem = 0.0;
        double diemMoiCau = 0.0;

        public static string maMH = "";
        public static string TrinhDo = "";
        public static int Lan;
        public static string maLop = "";
        public static string ngayThi = "";
        public static int thoiGian;
        public static int soCau;
        int index = 0;
        public FormThi()
        {
            InitializeComponent();
                setThoiGian();
                //// Remove the control box so the form will only display client area.
                this.ControlBox = false;
                DataTable dt = new DataTable();
                try
                {
                    string sql = "EXEC SP_THUCHIENTHI '" + maMH + "', '" + TrinhDo + "', " + soCau + "";

                    dt = Program.ExecSqlDataTable(sql);
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e.Message, "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                bdsDethi = new BindingSource();
                bdsDethi.DataSource = dt;
                socau = bdsDethi.Count;
                for (int i = 1; i <= socau; i++)
                {
                    rdbCauHoi.Properties.Items.Add(new RadioGroupItem(i, "" + i));
                    deThi.Add(i, LayCauHoiTuBDS(i - 1));
                }
                rdbCauHoi.SelectedIndex = 0;
                diemMoiCau = 10.0 / soCau;
            //btnXemKQ.Enabled = false;
            btnThoat.Enabled = false;
            timer.Start();


            

        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            
            lblThiTracNghiem.Text = "ĐỀ THI TRẮC NGHIỆM MÔN " + maMH.Trim();
            lblTrinhDoThi.Text = "Trình Độ " + TrinhDo.Trim();
            lblLanThi.Text = "Lần : " + Lan.ToString();
            lblNgayThi.Text = "Ngày : " + Program.FormatDate(ngayThi);
            lblThoiGianThi.Text = "Thời Gian : " + thoiGian.ToString()+" Phút";
            lblSoCauThi.Text = "Số Câu : " + soCau.ToString();
            lblHoTenThi.Text = "Họ Tên : " + Program.mHoten.Trim();
            lblMaSVThi.Text = "Mã SV : " + Program.username.Trim();
            lblMaLopThi.Text = "Mã Lớp : " + maLop.Trim();
            lblTenLopThi.Text = "Tên Lớp : " + Program.svTenlop.Trim();
            tbcMain.TabPages.Remove(tabPage2);
          
        }

        private void setThoiGian()
        {
            phut = thoiGian - 1;
            giay = 60;
        }


        private CauHoi LayCauHoiTuBDS(int vitri)
        {
            CauHoi c = new CauHoi();

            c.IDCauHoi = ((DataRowView)bdsDethi[vitri])["CAUHOI"].ToString().Trim();
            c.MaMH = ((DataRowView)bdsDethi[vitri])["MAMH"].ToString().Trim();
            c.MaGV = ((DataRowView)bdsDethi[vitri])["MAGV"].ToString().Trim();
            c.TrinhDo = ((DataRowView)bdsDethi[vitri])["TRINHDO"].ToString().Trim();
            c.NoiDung = ((DataRowView)bdsDethi[vitri])["NOIDUNG"].ToString().Trim();
            c.A = ((DataRowView)bdsDethi[vitri])["A"].ToString().Trim();
            c.B = ((DataRowView)bdsDethi[vitri])["B"].ToString().Trim();
            c.C = ((DataRowView)bdsDethi[vitri])["C"].ToString().Trim();
            c.D = ((DataRowView)bdsDethi[vitri])["D"].ToString().Trim();
            c.DapAn = ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim();
            c.DaChon = "X";

            tronDapAn(c);
            return c;
        }

        private void tronDapAn(CauHoi c)
        {
            // (1 - A, 2 - B, 3 - C, 4 - D)

            Random rand = new Random();
            List<int> randLuaChon = new List<int>();
            int temp = 0;
            for (int i = 1; i <= 4; i++)
            {
                temp = rand.Next(1, 5);
                if (!randLuaChon.Contains(temp))
                    randLuaChon.Add(temp);
                else
                    i--;
            }

            swapLuaChon("A", c.A, randLuaChon[0], c);
            swapLuaChon("B", c.B, randLuaChon[1], c);
            swapLuaChon("C", c.C, randLuaChon[2], c);
            swapLuaChon("D", c.D, randLuaChon[3], c);
        }


        private void swapLuaChon(string lc, string lcCu, int indexSwap, CauHoi c)
        {
            string temp = "";
            switch (indexSwap)
            {
                case 1: // A
                    if (c.DapAn == lc)
                        c.DapAn = "A";
                    else if (c.DapAn == "A")

                        c.DapAn = lc;
                    temp = lcCu;
                    if (c.A == lcCu)
                        c.A = c.A; // luachon cu = lua chon moi
                    else if (c.B == lcCu)
                        c.B = c.A;
                    else if (c.C == lcCu)
                        c.C = c.A;
                    else if (c.D == lcCu)
                        c.D = c.A;
                    c.A = temp;

                    break;
                case 2: // B
                    if (c.DapAn == lc)
                        c.DapAn = "B";
                    else if (c.DapAn == "B")
                        c.DapAn = lc;

                    temp = lcCu;
                    if (c.A == lcCu)
                        c.A = c.B; // luachon cu = lua chon moi
                    else if (c.B == lcCu)
                        c.B = c.B;
                    else if (c.C == lcCu)
                        c.C = c.B;
                    else if (c.D == lcCu)
                        c.D = c.B;
                    c.B = temp;

                    break;
                case 3: // C
                    if (c.DapAn == lc)
                        c.DapAn = "C";
                    else if (c.DapAn == "C")
                        c.DapAn = lc;

                    temp = lcCu;
                    if (c.A == lcCu)
                        c.A = c.C; // luachon cu = lua chon moi
                    else if (c.B == lcCu)
                        c.B = c.C;
                    else if (c.C == lcCu)
                        c.C = c.C;
                    else if (c.D == lcCu)
                        c.D = c.C;
                    c.C = temp;

                    break;
                case 4: // D
                    if (c.DapAn == lc)
                        c.DapAn = "D";
                    else if (c.DapAn == "D")
                        c.DapAn = lc;

                    temp = lcCu;
                    if (c.A == lcCu)
                        c.A = c.D; // luachon cu = lua chon moi
                    else if (c.B == lcCu)
                        c.B = c.D;
                    else if (c.C == lcCu)
                        c.C = c.D;
                    else if (c.D == lcCu)
                        c.D = c.D;
                    c.D = temp;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay == 0)
            {
                phut--;
                giay = 60;
            }
            if (phut == 0 && giay == 0)
            {
                timer.Stop();
                tinhDiem();
                //luuVaoBangDiem();
                hienThiTG();
                updateDatagrid();
                lblDiem.Text = "Điểm: " + diem;

                //btnXemKQ.Enabled = true;
                btnThoat.Enabled = true;
                btnNopBai.Enabled = false;
                //MessageBox.Show("Điểm của bạn: " + diem, "Điểm", MessageBoxButtons.OK);
            }
            hienThiTG();
        }

        private void updateDatagrid()
        {
            gvKetQua.Rows.Clear();
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(gvKetQua);
                newRow.Cells[0].Value = item.Key;
                newRow.Cells[1].Value = item.Value.DaChon;
                newRow.Cells[2].Value = item.Value.DapAn;
                gvKetQua.Rows.Add(newRow);
            }
        }

        private void hienThiTG()
        {
            if (giay < 10)
            {
                if (phut > 10)
                    lblTime.Text = phut + ":0" + giay;
                else
                    lblTime.Text = "0" + phut + ":0" + giay;
            }
            else
            {
                if (giay == 60)
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":00";
                    else
                        lblTime.Text = "0" + phut + ":00";
                }
                else
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":" + giay;
                    else
                        lblTime.Text = "0" + phut + ":" + giay;
                }
            }
        }

        private void luuVaoBangDiem()
        {
            //tinhDiem();
            DateTime NGAYTHI = DateTime.Now;
            string strInsertBangDiem = "EXEC SP_INSERT_BANGDIEM '" + Program.username.Trim() + "', '" + maMH + "', " + Lan + ", '" + ngayThi+ "', " + diem;
            Program.myReader = Program.ExecSqlDataReader(strInsertBangDiem);
            if (Program.myReader == null) return;
            Program.myReader.Close();
          
            string strInsert_CT_BaiThi;
            int i = 0;
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {

                try
                {
                    SqlCommand cmd = Program.conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_CT_BAITHI";

                    cmd.Parameters.Add(new SqlParameter("@MASV", Program.username.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@MAMH", maMH.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@LAN", Lan));
                    cmd.Parameters.Add(new SqlParameter("@CAUHOI", item.Value.IDCauHoi));
                    cmd.Parameters.Add(new SqlParameter("@STT", (i + 1)));
                    cmd.Parameters.Add(new SqlParameter("@NOIDUNG", item.Value.NoiDung.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@A", item.Value.A.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@B", item.Value.B.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@C", item.Value.C.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@D", item.Value.D.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@DAP_AN", item.Value.DapAn.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@DAP_AN_DA_CHON", item.Value.DaChon.Trim()));
                    cmd.ExecuteNonQuery();
                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("vitri " + i + " " + ex);
                }
                //strInsert_CT_BaiThi = "EXEC SP_INSERT_CT_BAITHI '" + Program.username.Trim() + "', '" + maMH.Trim() + "', " + Lan + ", " + item.Value.IDCauHoi + ", " + (i+1) + ", '"
                //    + item.Value.NoiDung.Trim() + "', '" + item.Value.A.Trim() + "', '" + item.Value.B.Trim() + "', '" + item.Value.C.Trim() + "', '" + item.Value.D.Trim()
                //    + "', '" + item.Value.DapAn.Trim() + "', '" + item.Value.DaChon.Trim() + "' ";
                //Program.myReader = Program.ExecSqlDataReader(strInsert_CT_BaiThi);
                //if (Program.myReader == null) return;
                //Program.myReader.Close();
              
            }

            Program.myReader.Close();
            Program.conn.Close();
        }

        private void tinhDiem()
        {
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {
                if (item.Value.DaChon == item.Value.DapAn)
                {
                    diem += diemMoiCau;
                    soCauDung++;
                }
            }
        }

        private void btnNopBai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phut != 0 && giay != 0)
            {
                if (MessageBox.Show("Chưa hết thời gian, bạn có chắc nộp bài không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (checkFullDA() == false)
                    {
                        if (MessageBox.Show("Chưa chọn hết đáp án, bạn có muốn nộp bài không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            tinhDiem();
                            luuVaoBangDiem();
                            tbcMain.TabPages.Remove(tabPage1);
                            tbcMain.TabPages.Add(tabPage2);
                            timer.Stop();
                            phut = 0;
                            giay = 0;
                            hienThiTG();
                            updateDatagrid();
                            lblKetQuaThi.Text = "KẾT QUẢ THI MÔN " + maMH;
                            lblHoTen.Text = "Họ Tên : " + Program.mHoten.Trim();
                            lblMaSV.Text = "Mã SV : "+ Program.username.Trim();
                            lblMaLop.Text = "Mã Lớp : "+ maLop.Trim();
                            lblTenLop.Text = "Tên Lớp : " + Program.svTenlop.Trim();
                            lblTrinhDo.Text = "Trình Độ "+ TrinhDo.Trim();
                            lblLan.Text = "Lần : " + Lan.ToString();
                            lblNgay.Text = "Ngày : "+ Program.FormatDate(ngayThi);
                            lblThoiGian.Text = "Thời Gian : "+ thoiGian.ToString()+" Phút";
                            lblSoCau.Text = "Số Câu : "+ soCau.ToString();
                            lblDiem.Text = "Số điểm đạt được : " + diem+"đ";
                            lblSoCauDung.Text = "Tổng số câu đúng : " + soCauDung + "/" + soCau;

                            //btnXemKQ.Enabled = true;
                            btnThoat.Enabled = true;
                            btnNopBai.Enabled = false;
                            tbcMain.SelectedIndex = 1;
                            //tbcMain.SelectedIndex(1).
                            //MessageBox.Show("Điểm của bạn: " + diem, "Điểm", MessageBoxButtons.OK);
                        }
                       
                    }
                    else if(checkFullDA() == true)
                    {
                        tinhDiem();
                        luuVaoBangDiem();
                        tbcMain.TabPages.Remove(tabPage1);
                        tbcMain.TabPages.Add(tabPage2);
                        timer.Stop();
                        phut = 0;
                        giay = 0;
                        hienThiTG();
                        updateDatagrid();
                        lblKetQuaThi.Text = "KẾT QUẢ THI MÔN " + maMH;
                        lblHoTen.Text = "Họ Tên : " + Program.mHoten.Trim();
                        lblMaSV.Text = "Mã SV : " + Program.username.Trim();
                        lblMaLop.Text = "Mã Lớp : " + maLop.Trim();
                        lblTenLop.Text = "Tên Lớp : " + Program.svTenlop.Trim();
                        lblTrinhDo.Text = "Trình Độ " + TrinhDo.Trim();
                        lblLan.Text = "Lần : " + Lan.ToString();
                        lblNgay.Text = "Ngày : " + Program.FormatDate(ngayThi);
                        lblThoiGian.Text = "Thời Gian : " + thoiGian.ToString()+ " Phút";
                        lblSoCau.Text = "Số Câu : " + soCau.ToString();
                        lblDiem.Text = "Số Điểm Đạt Được : " + diem + "đ";
                        lblSoCauDung.Text = "Tổng Số Câu Đúng : " + soCauDung + "/" + soCau;

                        //btnXemKQ.Enabled = true;
                        btnThoat.Enabled = true;
                        btnNopBai.Enabled = false;
                        tbcMain.SelectedIndex = 1;
                    }
                }
            }
        }

        private bool checkFullDA()
        {
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {
                if (item.Value.DaChon.Equals("X"))
                {
                    return false;
                }
            }
            return true;
        }

        private void rdbCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbDapAn.Properties.Items.Clear();
            lbCauHoi.Text = "Câu " + rdbCauHoi.EditValue.ToString() + ": " + deThi[rdbCauHoi.SelectedIndex + 1].NoiDung;
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("A", "A. " + deThi[rdbCauHoi.SelectedIndex + 1].A));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("B", "B. " + deThi[rdbCauHoi.SelectedIndex + 1].B));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("C", "C. " + deThi[rdbCauHoi.SelectedIndex + 1].C));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("D", "D. " + deThi[rdbCauHoi.SelectedIndex + 1].D));

            switch (deThi[rdbCauHoi.SelectedIndex + 1].DaChon)
            {
                case "A":
                    rdbDapAn.SelectedIndex = 0;
                    break;
                case "B":
                    rdbDapAn.SelectedIndex = 1;
                    break;
                case "C":
                    rdbDapAn.SelectedIndex = 2;
                    break;
                case "D":
                    rdbDapAn.SelectedIndex = 3;
                    break;
                case "X":
                    rdbDapAn.SelectedIndex = -1;
                    break;
            }
        }

        private void rdbDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbDapAn.SelectedIndex != -1)
                deThi[rdbCauHoi.SelectedIndex + 1].DaChon = rdbDapAn.EditValue.ToString();
            //if (!deThi[rdbCauHoi.SelectedIndex + 1].DaChon.Equals("X"))
            rdbCauHoi.Text = rdbCauHoi.EditValue.ToString() + "-" + deThi[rdbCauHoi.SelectedIndex + 1].DaChon;
            rdbCauHoi.Properties.Items.Add( new RadioGroupItem(rdbCauHoi.SelectedIndex + 1,""+ deThi[rdbCauHoi.SelectedIndex + 1].DaChon));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}