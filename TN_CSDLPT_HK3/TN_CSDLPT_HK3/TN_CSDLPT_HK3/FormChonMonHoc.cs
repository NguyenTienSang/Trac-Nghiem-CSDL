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
    public partial class FormChonMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public FormChonMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (FormDSDK.maMH == "" &&  FormXemKetQua.maMH == "")
            {
                MessageBox.Show("Chưa chọn môn học!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //FormXemKetQua.

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormDSDK.maMH = FormXemKetQua.maMH = "";
            this.Close();
        }

        private void gvMonHoc_Click(object sender, EventArgs e)
        {
            FormDSDK.maMH = FormXemKetQua.maMH = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString().Trim();
            
        }
    }
}