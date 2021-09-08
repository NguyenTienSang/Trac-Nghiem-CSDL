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
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class FormBangDiem : DevExpress.XtraEditors.XtraForm
    {
        private string maLop;
        private string maMH;
        private int lan;

        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);


            gcHienThi.Visible = false;

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");
            cmbLan.SelectedIndex = 0;


        }

        private void btnChonLop_Click(object sender, EventArgs e)
        {
            gcHienThi.Visible = true;
            gcLop.Visible = true;
            gcMonHoc.Visible = false;
            gcLop.Dock = DockStyle.Fill;
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            gcHienThi.Visible = true;
            gcMonHoc.Visible = true;
            gcLop.Visible = false;
            gcMonHoc.Dock = DockStyle.Fill;
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString().Trim();
            maMH = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "MAMH").ToString().Trim();
            lan = Int32.Parse(cmbLan.SelectedItem.ToString());

            string sql = "EXEC SP_KTBangDiemNULL '" + maMH + "', " + lan + ", '" + maLop + "'";
            MessageBox.Show(sql, "", MessageBoxButtons.OK);
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                rpt_XEMBANGDIEM1 rpt = new rpt_XEMBANGDIEM1(maMH, lan, maLop);
                rpt.lbLop.Text = txtTenLop.Text;
                rpt.lbMon.Text = txtMonHoc.Text;
                rpt.lbLanThi.Text = lan.ToString();

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
                gcHienThi.Visible = false;
            }
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            txtTenLop.Text = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "TENLOP").ToString();
        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {
            txtMonHoc.Text = gvMonHoc.GetRowCellValue(gvMonHoc.FocusedRowHandle, "TENMH").ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}