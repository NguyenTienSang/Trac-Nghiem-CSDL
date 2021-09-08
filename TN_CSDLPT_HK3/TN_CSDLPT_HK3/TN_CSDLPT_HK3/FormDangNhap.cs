using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT_HK3
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.v_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.DS_DSPM.v_DS_PHANMANH);
            cmb_TENCOSO.SelectedIndex = 1;
            cmb_TENCOSO.SelectedIndex = 0;
            Program.servername = cmb_TENCOSO.SelectedValue.ToString();
        }

        private void cmb_TENCOSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TENCOSO.SelectedValue != null)
            {
                Program.servername = cmb_TENCOSO.SelectedValue.ToString();
            }
        }

        private void rdbGV_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            labelPassword.Enabled = true;
        }

        private void rdbSV_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
            labelPassword.Enabled = false;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được để trống", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            try
            {
                    if (rdbSV.Checked == false)
                    {
                        Program.mlogin = txtLogin.Text;
                        Program.password = txtPassword.Text;
                        if (Program.KetNoi() == 0) return;
                        //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);

                        Program.mCoso = cmb_TENCOSO.SelectedIndex;
                        Program.bds_dspm = bdsDSPM;
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;

                        String strLenh = "exec SP_LAYTHONGTINDANGNHAP '" + Program.mlogin + "'";
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        if (Program.myReader == null) return;

                        Program.myReader.Read();

                        Program.username = Program.myReader.GetString(0);
                        Program.mHoten = Program.myReader.GetString(1);
                        Program.mGroup = Program.myReader.GetString(2);

                        if (Convert.IsDBNull(Program.username))
                        {
                            MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại login, password", "", MessageBoxButtons.OK);
                            return;
                        }

                        Program.frmMain = new btnXemDSDKTHI();
                        Program.frmMain.Activate();
                        //Program.frmDangNhap.Hide();
                        Program.frmMain.MAGV.Text = "Mã GV: " + Program.username;
                        Program.frmMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
                        Program.frmMain.NHOM.Text = "Nhóm: " + Program.mGroup;


                        Program.frmMain.Show();
                        this.Visible = false;
                        Program.myReader.Close();
                        Program.conn.Close();
                    }
                    if (rdbSV.Checked == true)
                    {
                        txtPassword.Enabled = false;
                        Program.mlogin = "SV";
                        Program.password = "123";
                        if (Program.KetNoi() == 0) return;

                        //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
                        Program.mCoso = cmb_TENCOSO.SelectedIndex;

                        Program.bds_dspm = bdsDSPM;

                        Program.username = txtLogin.Text;
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;


                        string strLayThongTinDangNhap = "exec SP_LAYTHONGTINDANGNHAP '" + Program.mlogin + "'";
                        Program.myReader = Program.ExecSqlDataReader(strLayThongTinDangNhap);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        Program.mGroup = Program.myReader.GetString(2);//Mã nhóm
                        Program.myReader.Close();

                        string strTimTTSV = "exec SP_TIMTTSV '" + txtLogin.Text.Trim() + "'";
                        Program.myReader = Program.ExecSqlDataReader(strTimTTSV);
                        Program.myReader.Read();

                        Program.username = Program.myReader.GetString(0);//Username là mã sinh viên (Có 2 cách lấy mã sv)
                        Program.mHoten = Program.myReader.GetString(1).Trim() + " " + Program.myReader.GetString(2).Trim();
                        Program.svMalop = Program.myReader.GetString(5);
                        Program.svTenlop = Program.myReader.GetString(6);

                        Program.frmThaoTacSV = new FormThaoTacSV();
                        Program.frmThaoTacSV.Activate();

                        Program.frmThaoTacSV.MASV.Text = "Mã sinh viên: " + Program.username;
                        Program.frmThaoTacSV.HOTEN.Text = "Họ tên sinh viên: " + Program.mHoten;
                        Program.frmThaoTacSV.NHOM.Text = "Nhóm: " + Program.mGroup;
                        Program.frmThaoTacSV.MALOP.Text = "Mã lớp: " + Program.svMalop;
                        Program.frmThaoTacSV.TENLOP.Text = "Tên lớp: " + Program.svTenlop;

                        Program.frmThaoTacSV.Show();
                        this.Visible = false;
                        Program.myReader.Close();
                        Program.conn.Close();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
