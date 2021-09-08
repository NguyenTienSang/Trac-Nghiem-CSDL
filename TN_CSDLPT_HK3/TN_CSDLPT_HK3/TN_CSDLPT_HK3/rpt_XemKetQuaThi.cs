using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class rpt_XemKetQuaThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_XemKetQuaThi(string MaSV, string MaMH, int Lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = Lan;
            this.sqlDataSource1.Fill();
        }
    }

}
