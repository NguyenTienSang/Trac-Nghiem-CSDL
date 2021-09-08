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
    public partial class FormChonLop : DevExpress.XtraEditors.XtraForm
    {
        public FormChonLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (FormDSDK.maLop == "")
            {
                MessageBox.Show("Chưa chọn lớp !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormDSDK.maLop = "";
            this.Close();
        }

        private void gvLop_Click(object sender, EventArgs e)
        {
            FormDSDK.maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString().Trim();
        }
    }
}