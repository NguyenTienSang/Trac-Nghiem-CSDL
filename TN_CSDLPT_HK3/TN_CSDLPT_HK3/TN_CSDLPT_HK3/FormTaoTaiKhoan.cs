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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {

        private string TenGV = "";
        private string user = "";
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);

            if (Program.mGroup == "TRUONG")
            {
                cmbGroup.Items.Add("TRUONG");
            }
            else if (Program.mGroup == "COSO")
            {
                cmbGroup.Items.Add("COSO");
                cmbGroup.Items.Add("GIANGVIEN");
            }

            cmbGroup.SelectedIndex = 0;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string sql = "EXEC SP_TAOTAIKHOAN '" + txtLogin.Text.Trim() + "', '" + txtPassword.Text.Trim() + "', '" + user + "', '" + cmbGroup.SelectedItem.ToString().Trim() + "'";
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            }
           
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            //grcDSGV.Visible = true;
            user = gvGiaoVien.GetRowCellValue(gvGiaoVien.FocusedRowHandle, "MAGV").ToString().Trim();
        }

        private void btnChon_Leave(object sender, EventArgs e)
        {
            txtUser.Text = user;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvGiaoVien_Click(object sender, EventArgs e)
        {
            //TenGV = gvGiaoVien.GetRowCellValue(gvGiaoVien.FocusedRowHandle, "TEN").ToString();
            user = gvGiaoVien.GetRowCellValue(gvGiaoVien.FocusedRowHandle, "MAGV").ToString();
            txtUser.Text = user;
        }
    }
}