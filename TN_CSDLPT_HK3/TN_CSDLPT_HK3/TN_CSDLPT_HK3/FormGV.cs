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
    public partial class FormGV : DevExpress.XtraEditors.XtraForm
    {
        Int32 vitri;
        private PhucHoi phucHoi = new PhucHoi();
        private bool isDangThem = false;
        private bool isDangSua = false;
        private string tenKH = "";
        private string maKH = "";
        private DataTable dt = new DataTable();
        public FormGV()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
            this.BoDeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BoDeTableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);

           

            dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
            cmbMaKhoa.DataSource = dt;
            cmbMaKhoa.DisplayMember = "TENKH";
            cmbMaKhoa.ValueMember = "MAKH";
            cmbMaKhoa.SelectedIndex = 0;

            maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
            this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TEN_COSO";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnRefresh.Enabled=false;
            txtMaGV.ReadOnly = txtMaKH.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = true;

            if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
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
                this.BoDeTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BoDeTableAdapter.Fill(this.DS.BODE);
                // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.GVDKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
                this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);

                dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
                cmbMaKhoa.DataSource = dt;
                cmbMaKhoa.DisplayMember = "TENKH";
                cmbMaKhoa.ValueMember = "MAKH";
                cmbMaKhoa.SelectedIndex = 0;

                maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
                this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";


            }
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKhoa.SelectedValue != null)
            {
                maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
                tenKH = cmbMaKhoa.GetItemText(cmbMaKhoa.SelectedItem);
                txtMaKH.Text = cmbMaKhoa.SelectedValue.ToString().Trim();
                //index = cmbMaKhoa.SelectedIndex;
            }
            this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";
            cmbMaKhoa.Text = tenKH;
            btnXoa.Enabled = false;
            if (bdsGiaoVien.Count != 0)
                btnXoa.Enabled = true;
            return;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            txtMaGV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = false;
            isDangThem = true;
            vitri = bdsGiaoVien.Position;
            gcGV.Enabled = false;
            bdsGiaoVien.AddNew();
            txtMaKH.Text = maKH;
            btnThem.Enabled  = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled= true;
            txtMaGV.Focus();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiaoVien.CancelEdit();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcGV.Enabled = true;
            isDangThem = isDangSua = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            if (bdsGiaoVien.Count == 0)
            {
                MessageBox.Show("Không có giáo viên nào để xóa!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else if (bdsGVDK.Count != 0)
            {
                MessageBox.Show("Giáo viên đã đăng ký lịch thi, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else if (bdsBoDe.Count != 0)
            {
                MessageBox.Show("Giáo viên đã có câu hỏi trong bộ đề, không được xoá!\n", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGV = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGV"].ToString();
                    phucHoi.PushStack_XoaGV(maGV, txtHo.Text.Trim(), txtTen.Text.Trim(), txtDiaChi.Text.Trim(), txtMaKH.Text.Trim());
                    bdsGiaoVien.RemoveCurrent();
                    this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiaoVienTableAdapter.Update(this.DS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);
                    bdsGiaoVien.Position = bdsGiaoVien.Find("MAGV", maGV);
                    return;
                }
            }
            if (bdsGiaoVien.Count == 0)
                btnXoa.Enabled = false;
           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;
            txtMaGV.ReadOnly = true;
            phucHoi.Save_OldGV(txtHo.Text.Trim(), txtTen.Text.Trim(), txtDiaChi.Text.Trim(), txtMaKH.Text.Trim());
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
            txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = false;
            txtHo.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã GV không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

          
                if (isDangThem == true)
                {

                    string SP_TRUNGMAGV = "exec SP_TRUNGMAGV'" + txtMaGV.Text.Trim() + "'";
                    if (Program.ExecSqlNonQuery(SP_TRUNGMAGV) == 1)
                    {
                        txtMaGV.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsGiaoVien.EndEdit();
                            bdsGiaoVien.ResetCurrentItem();
                            this.GiaoVienTableAdapter.Update(this.DS.GIAOVIEN);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                            phucHoi.PushStack_ThemGV(txtMaGV.Text.Trim());
                    }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi giáo viên. " + a.Message, "", MessageBoxButtons.OK);
                            bdsGiaoVien.CancelEdit();
                            
                    }
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = gcGV.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaGV.ReadOnly = true;
                        isDangThem = false;
                    }
                }
                else if(isDangSua == true)
                {
                    try
                    {
                        bdsGiaoVien.EndEdit();
                        bdsGiaoVien.ResetCurrentItem();
                        this.GiaoVienTableAdapter.Update(this.DS.GIAOVIEN);
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Lỗi ghi giáo viên. " + a.Message, "", MessageBoxButtons.OK);
                        bdsGiaoVien.CancelEdit();
                }
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcGV.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;
                    isDangSua = false;
                }
                    txtHo.ReadOnly = txtTen.ReadOnly = txtDiaChi.ReadOnly = true;
        }

    

        private void btnPhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(isDangThem)
            {
                txtMaGV.Text  = txtTen.Text = txtHo.Text = txtDiaChi.Text = "";
                txtMaGV.Focus();
            }
            else if(isDangSua)
            {
                txtHo.Text = txtTen.Text = txtDiaChi.Text = "";
                txtHo.Focus();
            }
        }
    }
}