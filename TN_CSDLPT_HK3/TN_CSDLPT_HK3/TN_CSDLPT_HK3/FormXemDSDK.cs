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
    public partial class FormXemDSDK : DevExpress.XtraEditors.XtraForm
    {
        public FormXemDSDK()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

           // MessageBox.Show("năm 1 : " + dptNgay1.Text + " năm 2 : " + dptNgay2.Text, "Lỗi", MessageBoxButtons.OK);

            if (SoSanhNgayThi(dptNgay2.Text, dptNgay1.Text) >=0)
            {
                PRT_DSDKTHI rpt = new PRT_DSDKTHI(dptNgay1.Text.Trim(), dptNgay2.Text.Trim());
                rpt.lbCoSo.Text = ((DataRowView)Program.bds_dspm[Program.mCoso])["TEN_COSO"].ToString();
                rpt.lbNgay.Text = "TỪ NGÀY " + Program.FormatDate(dptNgay1.Text.Trim()) + " ĐẾN NGÀY " + Program.FormatDate(dptNgay2.Text.Trim());

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
               
                
            }
            else
            {
                MessageBox.Show("", "Ngày thứ hai không được trước ngày thứ nhất", MessageBoxButtons.OK);
            }
           
        }
        private int SoSanhNgayThi(string date1, string date2) //ktra theo thu tu: nam -> thang -> ngay
        {
            string[] s1 = date1.Split('/'); //format là  mm/dd/yyyy
            string[] s2 = date2.Split('/');//Thời gian hiện tại
            //So sánh năm
            //MessageBox.Show("năm 1 : "+ s1[2]+ " năm 2 : "+ s2[2], "Lỗi", MessageBoxButtons.OK);
            if (int.Parse(s1[2]) > int.Parse(s2[2]))
            {
                return 1;
            }
            else if (int.Parse(s1[2]) < int.Parse(s2[2]))
            {
                return -1;
            }
            else
            {
                //So sánh tháng
                if (int.Parse(s1[0]) > int.Parse(s2[0]))
                {
                    return 1;
                }
                else if (int.Parse(s1[0]) < int.Parse(s2[0]))
                {
                    return -1;
                }
                else
                {
                    //So sánh ngày
                    if (int.Parse(s1[1]) > int.Parse(s2[1]))
                    {
                        return 1;
                    }
                    else if (int.Parse(s1[1]) < int.Parse(s2[1]))
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

    }
}