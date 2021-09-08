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
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {

        Int32 vitri;
        private string maCoSo = "";
        private string maKhoa = "";
        private bool isDangThem = false;
        private bool isDangSua = false;

        public FormKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
           
            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DS.KHOA);

            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            maCoSo = txtMaCoSo.Text.Trim();
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled= false;
            txtMaCoSo.ReadOnly = txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = true;

            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
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
                maCoSo = txtMaCoSo.Text.Trim();
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsKhoa.Position;
            gcKhoa.Enabled = false;
            bdsKhoa.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled= true;
            txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = false;
            txtMaCoSo.Text = maCoSo;
            txtMaCoSo.ReadOnly = true;
            txtMaKhoa.Focus();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsKhoa.Count == 0)
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Không có khoa nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else if (bdsGiaoVien.Count != 0)
            {
                MessageBox.Show("Khoa đã có giáo viên, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else if (bdsLop.Count != 0)
            {
                MessageBox.Show("Khoa đã có lớp, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKhoa = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                    bdsKhoa.RemoveCurrent();
                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Update(this.DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.KhoaTableAdapter.Fill(this.DS.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", maKhoa);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            isDangSua = true;
            txtMaKhoa.ReadOnly = true;
            txtTenKhoa.ReadOnly = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
            txtTenKhoa.Focus();
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }
            else
            {

                string strTimMaKhoa = "exec SP_KTTRUNGMAKH'" + txtMaKhoa.Text.Trim() + "'";
                string strTimTenKhoa = "exec SP_KTTRUNGTENKH'" + txtTenKhoa.Text.Trim() + "'";

                if (isDangThem == true)
                {
                    if (Program.ExecSqlNonQuery(strTimMaKhoa) == 1)
                    {
                        txtMaKhoa.Focus();
                        return;
                    }

                    if (Program.ExecSqlNonQuery(strTimTenKhoa) == 1)
                    {
                        txtTenKhoa.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsKhoa.EndEdit();
                            bdsKhoa.ResetCurrentItem();
                            this.KhoaTableAdapter.Update(this.DS.KHOA);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi khoa. " + a.Message, "", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcKhoa.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = true;
                        isDangThem = false;
                    }
                }
                else if (isDangSua == true)
                {
                    if (Program.ExecSqlNonQuery(strTimTenKhoa) == 1)
                    {
                        txtTenKhoa.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsKhoa.EndEdit();
                            bdsKhoa.ResetCurrentItem();
                            this.KhoaTableAdapter.Update(this.DS.KHOA);
                            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);

                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi khoa. " + a.Message, "", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcKhoa.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtTenKhoa.ReadOnly = true;
                        isDangSua = false;
                    }
                }

            }
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcKhoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(isDangSua)
            {
                txtTenKhoa.Text = "";
                txtTenKhoa.Focus();
            }
            else if(isDangThem)
            {
                txtMaKhoa.Text= txtTenKhoa.Text = "";
                txtTenKhoa.Focus();
            }
           
        }
    }
}