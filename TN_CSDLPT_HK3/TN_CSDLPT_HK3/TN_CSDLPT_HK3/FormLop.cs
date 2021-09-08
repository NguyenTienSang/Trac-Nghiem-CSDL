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
    public partial class FormLop : DevExpress.XtraEditors.XtraForm
    {

        Int32 vitri;
        private string maKhoa = "";
        private string maLop = "";
        private bool isDangThem = false;
        private bool isDangSua = false;
        public FormLop()
        {
            InitializeComponent();
           // this.bdsLop.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GiaoVien_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaoVien_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);


            //bdsKhoa.Filter = "MAKH = '" + cmbKhoa.SelectedValue.ToString().Trim() + "'";
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            btnGhi.Enabled = btnHuy.Enabled = buttonRefresh.Enabled = false;
            txtMaKhoa.ReadOnly = txtMaLop.ReadOnly = txtTenLop.ReadOnly =true;
            maKhoa = txtMaKhoa.Text.Trim();

            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = buttonRefresh.Enabled= false;
                //gbInfo.Enabled = false;
            }
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
                this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhoaTableAdapter.Fill(this.DS.KHOA);
                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Fill(this.DS.LOP);
                maKhoa = txtMaKhoa.Text.Trim();
            }
        }


        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

            isDangThem = true;
            vitri = bdsLop.Position;
            gcLop.Enabled = false;
            bdsLop.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled =buttonRefresh.Enabled = true;
            txtMaKhoa.ReadOnly = true;
            txtMaLop.ReadOnly = txtTenLop.ReadOnly = false;
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
            txtMaKhoa.Text = maKhoa;
            txtMaLop.Focus();

        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Không có lớp nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsSV.Count > 0)
                {
                    MessageBox.Show("Lớp học đang có sinh viên, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                }
                else if (bdsGVDK.Count > 0)
                {
                    MessageBox.Show("Lớp học đã có giáo viên đăng ký thi, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                }
                else if (MessageBox.Show("Bạn có muốn xóa lớp học " + txtTenLop.Text.Trim() + " có mã lớp là : " + txtMaLop.Text.Trim() + " không ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                        bdsLop.RemoveCurrent();
                        this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LopTableAdapter.Update(this.DS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo ", MessageBoxButtons.OK);
                        this.LopTableAdapter.Fill(this.DS.LOP);
                        bdsLop.Position = bdsKhoa.Find("MAKH", maLop);
                        return;
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtTenLop.Focus();
            txtMaLop.ReadOnly = true;
            txtTenLop.ReadOnly = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcLop.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = buttonRefresh.Enabled=true;
            isDangSua = true;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            else
            {
                string strTimMaLop = "exec SP_KTTRUNGMALOP'" + txtMaLop.Text.Trim() + "'";
                string strTimTenLop = "exec SP_KTTRUNGTENLOP'" + txtTenLop.Text.Trim() + "'";

                if (isDangThem == true)
                {
                    if (Program.ExecSqlNonQuery(strTimMaLop) == 1)
                    {
                        txtMaLop.Focus();
                        return;
                    }
                    else if (Program.ExecSqlNonQuery(strTimTenLop) == 1)
                    {
                        txtTenLop.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsLop.EndEdit();
                            bdsLop.ResetCurrentItem();
                            this.LopTableAdapter.Update(this.DS.LOP);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi lớp. " + a.Message, "", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcLop.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaLop.ReadOnly = txtTenLop.ReadOnly = true;
                        isDangThem = false;
                    }
                }
                else if (isDangSua == true)
                {
                    if (Program.ExecSqlNonQuery(strTimTenLop) == 1)
                    {
                        txtTenLop.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsLop.EndEdit();
                            bdsLop.ResetCurrentItem();
                            this.LopTableAdapter.Update(this.DS.LOP);
                            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi lớp. " + a.Message, "", MessageBoxButtons.OK);
                        }

                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcLop.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaLop.ReadOnly = txtTenLop.ReadOnly = true;
                        isDangSua = false;
                    }
                }

            }
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcLop.Enabled = true;
            //cmbKhoa.SelectedIndex = 1;
            //cmbKhoa.SelectedIndex = 0;
            //txtMaKhoa.Text = cmbKhoa.SelectedValue.ToString().Trim();
        }

 

        private void cmbKhoa_SelectedIndexChanged_2(object sender, EventArgs e)
        {
          
            if (cmbKhoa.SelectedValue != null)
            {
                //bdsKhoa.RemoveFilter();
                //bdsKhoa.Filter = "MAKH = '" + cmbKhoa.SelectedValue.ToString().Trim() + "'";
                txtMaKhoa.Text = cmbKhoa.SelectedValue.ToString().Trim();
            }
          
        }

        private void buttonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (isDangThem)
            {
                txtMaLop.Text = txtTenLop.Text = "";
                txtMaLop.Focus();
            }
            else if(isDangSua)
            {
                txtTenLop.Text = "";
                txtTenLop.Focus();
            }

        }
    }
}