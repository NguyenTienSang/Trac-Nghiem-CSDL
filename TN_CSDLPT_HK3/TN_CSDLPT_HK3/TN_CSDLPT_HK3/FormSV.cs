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
    public partial class FormSV : DevExpress.XtraEditors.XtraForm
    {
        string maLop = "";
        string tenLop = "";
        Int32 vitri;
        private Boolean isDangThem = false, isDangSua = false, suaLop = false;
        private PhucHoi phucHoi = new PhucHoi();
        public FormSV()
        {
            InitializeComponent();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
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
                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Fill(this.DS.LOP);

                this.SinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);
            }
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                maLop = cmbTenLop.SelectedValue.ToString().Trim();
                tenLop = cmbTenLop.GetItemText(cmbTenLop.SelectedItem);
            }
            this.bdsSV.Filter = "MALOP = '" + maLop + "'";
            cmbTenLop.Text = tenLop;
            return;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsSV.Position;
            gcSinhVien.Enabled = false;
            bdsSV.AddNew();
            txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = dtNgaySinh.ReadOnly = txtDiaChi.ReadOnly = false;
            cmbTenLop.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnPhucHoi.Enabled =  btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled =true;
            txtMaLop.Text = maLop;
            dtNgaySinh.EditValue = "";
            txtMaSV.Focus();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Int32 maSV = 0;
            if (bdsSV.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                btnXoa.Enabled = false;
            }
            //else if (bds_BangDiem.Count != 0)
            //{
            //    MessageBox.Show("Sinh viên đang có bảng điểm, không được xoá!", "Thông báo", MessageBoxButtons.OK);
            //}
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maSV = int.Parse(((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString());
                        bdsSV.RemoveCurrent();
                        this.SinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SinhVienTableAdapter.Update(this.DS.SINHVIEN);
                        phucHoi.PushStack_XoaSV(txtMaSV.Text, txtHo.Text, txtTen.Text, dtNgaySinh.Text, txtDiaChi.Text, maLop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);
                        bdsSV.Position = bdsSV.Find("MASV", maSV);
                        return;
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
             txtMaLop.ReadOnly = txtMaSV.ReadOnly = true;
            txtHo.ReadOnly = txtTen.ReadOnly = dtNgaySinh.ReadOnly = txtDiaChi.ReadOnly = false;
            txtHo.Focus();
            isDangSua = true;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (dtNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày sinh không được trống!", "Lỗi", MessageBoxButtons.OK);
                dtNgaySinh.Focus();
                return;
            }
            if(txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (!suaLop)
                txtMaLop.Text = maLop;
            try
            {


                string strTimMaSV = "exec SP_KTTRUNGMASV'" + txtMaSV.Text.Trim() + "'";

              

                if (isDangThem == true)
                {
                    if (Program.ExecSqlNonQuery(strTimMaSV) == 1)
                    {
                        txtMaSV.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsSV.EndEdit();
                            bdsSV.ResetCurrentItem();
                            this.SinhVienTableAdapter.Update(this.DS.SINHVIEN);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                            phucHoi.PushStack_ThemSV(txtMaSV.Text);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi sinh viên\n" + a.Message, "Lỗi", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcSinhVien.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = dtNgaySinh.ReadOnly = true;
                        isDangThem = false;
                    }
                   
                }
                else if (isDangSua == true)
                {
                  
                        try
                        {
                            bdsSV.EndEdit();
                            bdsSV.ResetCurrentItem();
                            this.SinhVienTableAdapter.Update(this.DS.SINHVIEN);
                            MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                            phucHoi.PushStack_SuaSV(txtMaSV.Text);

                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi sinh viên " + a.Message, "", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcSinhVien.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = dtNgaySinh.ReadOnly = true;
                        isDangSua = false;
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcSinhVien.Enabled = true;
            isDangThem = isDangSua = false;
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable sinh viên
                this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);
                if (cmbTenLop.SelectedValue != null)
                {
                    maLop = cmbTenLop.SelectedValue.ToString().Trim();
                    tenLop = cmbTenLop.GetItemText(cmbTenLop.SelectedItem);
                }
                this.bdsSV.Filter = "MALOP = '" + maLop + "'";
                cmbTenLop.Text = tenLop;
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                btnPhucHoi.Enabled = false;
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(isDangThem)
            {
                txtMaSV.Text = txtTen.Text = txtHo.Text = txtDiaChi.Text = "";
                dtNgaySinh.Text=DateTime.Now.ToShortDateString();
                txtMaSV.Focus();
            }
            else if(isDangSua)
            {
                txtTen.Text = txtHo.Text = txtDiaChi.Text = "";
                dtNgaySinh.Text = DateTime.Now.ToShortDateString();
                txtHo.Focus();
            }
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SinhVienTableAdapter.Fill(this.DS.SINHVIEN);
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled= btnRefresh.Enabled = false;
            txtMaLop.ReadOnly = txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = dtNgaySinh.ReadOnly = txtDiaChi.ReadOnly = true;
            if (cmbTenLop.SelectedValue != null)
            {
                maLop = cmbTenLop.SelectedValue.ToString().Trim();
                tenLop = cmbTenLop.GetItemText(cmbTenLop.SelectedItem);
            }
            this.bdsSV.Filter = "MALOP = '" + maLop + "'";
            cmbTenLop.Text = tenLop;
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
            }

        }
    }
}