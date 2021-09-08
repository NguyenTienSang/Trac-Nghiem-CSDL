using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_HK3
{
    public partial class PRT_DSDKTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public PRT_DSDKTHI(string ngay1,string ngay2)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngay1;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngay2;
            this.sqlDataSource1.Fill();
        }

    }
}
