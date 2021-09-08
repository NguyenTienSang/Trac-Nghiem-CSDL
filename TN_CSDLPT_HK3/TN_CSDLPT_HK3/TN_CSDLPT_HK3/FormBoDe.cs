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
    public partial class FormBoDe : DevExpress.XtraEditors.XtraForm
    {
        Int32 vitri;
        private string maMonHoc = "";
        private bool isDangThem = false;
        private bool isDangSua = false;
        public FormBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.CT_BAITHI' table. You can move, or remove it, as needed.
            this.CT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_BAITHITableAdapter.Fill(this.DS.CT_BAITHI);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaoVienTableAdapter.Fill(this.DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.BoDeableAdapter.Connection.ConnectionString = Program.connstr;
            this.BoDeableAdapter.Fill(this.DS.BODE);

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled=false;
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }
            if(Program.mGroup == "GIANGVIEN")
            {
                bdsBoDe.Filter = "MAGV = '" + Program.username + "'";
            }
            txtMaGV.ReadOnly =  txtMaMH.ReadOnly = txtMaCauHoi.ReadOnly = txtNoiDung.ReadOnly = txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = true;

            cmbTenMH.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = false;
            maMonHoc = txtMaMH.Text;

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsBoDe.Position;
            gcBoDe.Enabled = false;
            bdsBoDe.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnRefresh.Enabled = true;
            txtMaGV.ReadOnly =  txtMaMH.ReadOnly = true;
            txtNoiDung.ReadOnly = txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = false;
            cmbTenMH.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = true;
            cmbTenMH.SelectedIndex = cmbTrinhDo.SelectedIndex = cmbDapAn.SelectedIndex = 1;
            cmbTenMH.SelectedIndex = cmbTrinhDo.SelectedIndex = cmbDapAn.SelectedIndex = 0;
            txtMaGV.Text = Program.username;
            txtNoiDung.Focus();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN")
            {
                if (Program.username != txtMaGV.Text)
                {
                    MessageBox.Show("Bạn không được hiệu chỉnh câu hỏi của người khác!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            if (bdsBoDe.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else if (bdsCT_BAITHI.Count != 0)
            {
                MessageBox.Show("Câu hỏi đã có trong chi tiết bài thi, không được xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            DialogResult ds = MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi:  " + txtMaCauHoi.Text + "  không?", "", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                try
                {
                    bdsBoDe.RemoveCurrent();
                    this.BoDeableAdapter.Update(this.DS.BODE);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi trong bộ đề!", "Thông báo", MessageBoxButtons.OK);
                }
                if (bdsBoDe.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
            }
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMH.SelectedValue != null)
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN")
            {
                if ((Program.username).Trim() != txtMaGV.Text.Trim())
                {
                    MessageBox.Show("Bạn không được hiệu chỉnh câu hỏi của người khác!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
            }
            isDangSua = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;

            cmbTenMH.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = btnRefresh.Enabled = true;

            txtMaGV.ReadOnly = txtMaMH.ReadOnly = txtMaCauHoi.ReadOnly = true;
      

            txtNoiDung.ReadOnly = txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = false;

            txtNoiDung.Focus();
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào đầy đủ nội dung đáp án!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //Nếu như đã nhập thông tin
            else
            {
                

                if (isDangThem == true)
                {
                    string strTimMaBoDe = "exec SP_TIMMABODE";
                    Program.myReader = Program.ExecSqlDataReader(strTimMaBoDe);
                    Program.myReader.Read();
                    txtMaCauHoi.Text = Program.myReader.GetInt32(0).ToString();
                    Program.myReader.Close();
                    try
                        {
                            bdsBoDe.EndEdit();
                            bdsBoDe.ResetCurrentItem();
                            this.BoDeableAdapter.Update(this.DS.BODE);
                            MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Lỗi ghi bộ đề\n" + a.Message, "Lỗi", MessageBoxButtons.OK);
                        }
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcBoDe.Enabled = true;
                        btnGhi.Enabled = btnHuy.Enabled = false;
                        txtMaGV.ReadOnly = txtMaMH.ReadOnly = txtMaCauHoi.ReadOnly = txtNoiDung.ReadOnly = txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = true;
                        isDangThem = false;

                }
                else if (isDangSua == true)
                {
                    try
                    {
                        bdsBoDe.EndEdit();
                        bdsBoDe.ResetCurrentItem();
                        this.BoDeableAdapter.Update(this.DS.BODE);
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Lỗi ghi sinh viên " + a.Message, "", MessageBoxButtons.OK);
                    }
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gcBoDe.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;
                    txtNoiDung.ReadOnly = txtA.ReadOnly = txtB.ReadOnly = txtC.ReadOnly = txtD.ReadOnly = true;
                    isDangSua = false;
                }
            }
        }
        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsBoDe.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled =btnRefresh.Enabled= false;
            isDangThem = isDangSua = false;
            gcBoDe.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(isDangThem)
            {
                 txtNoiDung.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = "";
                cmbDapAn.SelectedIndex = 0;
                txtNoiDung.Focus();
            }
            else if(isDangSua)
            {
               txtNoiDung.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text =  "";
                cmbDapAn.SelectedIndex = 0;
                txtNoiDung.Focus();
            }
        }
    }
}