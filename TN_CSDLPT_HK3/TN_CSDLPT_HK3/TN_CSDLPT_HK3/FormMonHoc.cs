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
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        Int32 vitri;
        private PhucHoi phucHoi = new PhucHoi();
        private string maMonHoc = "";
        private bool isDangThem = false;
        private bool isDangSua = false;
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
            this.BoDeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BoDeTableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }
            btnPhucHoi.Enabled =  btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled= false;
            txtMaMonHoc.ReadOnly = txtTenMonHoc.ReadOnly = true;
            maMonHoc = txtMaMonHoc.Text.Trim();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsMonHoc.Position;
            gcMonHoc.Enabled = false;
            bdsMonHoc.AddNew();
            txtMaMonHoc.ReadOnly = txtTenMonHoc.ReadOnly = false;
            btnThem.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
            txtMaMonHoc.Focus();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsMonHoc.Count == 0)
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Không có môn học nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsBoDe.Count != 0)
                {
                    MessageBox.Show("Môn học đã có câu hỏi trong bộ đề, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                //else if (bds_GVDK.Count != 0)
                //{
                //    MessageBox.Show("Môn học đã có giáo viên đăng ký thi, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                //}
                //else if (bds_BangDiem.Count != 0)
                //{
                //    MessageBox.Show("Môn học đã có bảng điểm, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                //}
                if (MessageBox.Show("Bạn có muốn xóa môn học " + txtTenMonHoc.Text.Trim() + " có mã môn là : " + txtMaMonHoc.Text.Trim() + " không ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maMonHoc = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                        bdsMonHoc.RemoveCurrent();
                        this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.MonHocTableAdapter.Update(this.DS.MONHOC);
                        phucHoi.PushStack_XoaMH(txtMaMonHoc.Text, txtTenMonHoc.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo ", MessageBoxButtons.OK);
                        this.MonHocTableAdapter.Fill(this.DS.MONHOC);
                        bdsMonHoc.Position = bdsMonHoc.Find("MAKH", maMonHoc);
                        return;
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtTenMonHoc.Focus();
            txtMaMonHoc.ReadOnly = true;
            txtTenMonHoc.ReadOnly = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcMonHoc.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
            isDangSua = true;
            isDangThem = false;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaMonHoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return;
            }
            if (txtTenMonHoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
                return;
            }
            else
            {
                string strTimMaMonHoc = "exec SP_KTTRUNGMAMONHOC'" + txtMaMonHoc.Text.Trim() + "'";
                string strTimTenMonHoc = "exec SP_KTTRUNGTENMONHOC'" + txtTenMonHoc.Text.Trim() + "'";

                if (isDangThem == true)
                {
                    if (Program.ExecSqlNonQuery(strTimMaMonHoc) == 1)
                    {
                        phucHoi.PushStack_ThemMH(txtMaMonHoc.Text);
                        txtMaMonHoc.Focus();
                        return;
                    }
                    else if (Program.ExecSqlNonQuery(strTimTenMonHoc) == 1)
                    {
                        txtTenMonHoc.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsMonHoc.EndEdit();
                            bdsMonHoc.ResetCurrentItem();
                            this.MonHocTableAdapter.Update(this.DS.MONHOC);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi môn học. " + a.Message, "", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = gcMonHoc.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaMonHoc.ReadOnly = txtTenMonHoc.ReadOnly = true;
                        isDangThem = false;
                    }
                }
                else if (isDangSua == true)
                {
                    if (Program.ExecSqlNonQuery(strTimTenMonHoc) == 1)
                    {
                        txtTenMonHoc.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsMonHoc.EndEdit();
                            bdsMonHoc.ResetCurrentItem();
                            this.MonHocTableAdapter.Update(this.DS.MONHOC);
                            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                            phucHoi.PushStack_SuaMH(txtMaMonHoc.Text, txtTenMonHoc.Text);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi lớp. " + a.Message, "", MessageBoxButtons.OK);
                        }

                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = gcMonHoc.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaMonHoc.ReadOnly = txtTenMonHoc.ReadOnly = true;
                        isDangSua = false;
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            btnThem.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcMonHoc.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable Môn học
                this.MonHocTableAdapter.Fill(this.DS.MONHOC);
                this.BoDeTableAdapter.Fill(this.DS.BODE);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(isDangThem)
            {
                txtMaMonHoc.Text = txtTenMonHoc.Text = "";
                txtMaMonHoc.Focus();
            }
            else if(isDangSua)
            {
                txtTenMonHoc.Text = "";
                txtTenMonHoc.Focus();
            }
        }
    }
}