using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT_HK3
{
    class PhucHoi
    {
        private Stack<string> myStack = new Stack<string>();
        private string DataTruocKhiSua = "";

        //-------------MÔN HỌC ------------------------
        public string GetDataTruocKhiSua()
        {
            return this.DataTruocKhiSua;
        }
        public void PushStack_ThemMH(string newMaMH)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOITHEMMH] '" + newMaMH + "'");
        }
        public void PushStack_XoaMH(string maMH, string tenMH)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOIXOAMH] '" + maMH + "', N'" + tenMH + "'");
        }
        public void Save_OldMH(string oldTenMH)
        {
            DataTruocKhiSua = oldTenMH;
        }

        public void PushStack_SuaMH(string MaMH, string newTenMH)
        {
            myStack.Push("exec[dbo].[SP_PHUCHOISUAMH] '" + MaMH + "', N'" + newTenMH + "', N'" + DataTruocKhiSua + "'");
        }

        // ------------Giáo viên--------------
        public void PushStack_ThemGV(string newMaGV)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOITHEMGV] '" + newMaGV + "'");
        }
        public void PushStack_XoaGV(string maGV, string HoGV, string TenGV, string HocVi, string MaKH)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOIXOAGV] '" + maGV + "', N'" + HoGV + "', N'" + TenGV + "', N'" + HocVi + "', '" + MaKH + "'");
        }
        public void Save_OldGV(string oldHoGV, string oldTenGV, string oldHocVi, string oldMaKH)
        {
            DataTruocKhiSua = oldHoGV + "-" + oldTenGV + "-" + oldHocVi + "-" + oldMaKH;
        }
        public void PushStack_SuaGV(string MaGV)
        {
            string[] arr = DataTruocKhiSua.Split('-');
            myStack.Push("exec[dbo].[SP_PHUCHOISUAGV] '" + MaGV + "', N'" + arr[0] + "', N'" + arr[1] + "', N'" + arr[2] + "', '" + arr[3] + "'");
        }

        // ----------------------sinh viên----------------------
        public void PushStack_ThemSV(string newMaSV)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOITHEMSV] '" + newMaSV + "'");
        }

        public void PushStack_XoaSV(string maSV, string ho, string ten, string ngaySinh, string diaChi, string maLop)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOIXOASV] '" + maSV + "', N'" + ho + "', N'" + ten + "', '" + ngaySinh + "', N'" + diaChi + "', '" + maLop + "'");
        }

        public void Save_OldSV(string oldHo, string oldTen, string oldNgaySinh, string oldDiaChi, string oldMaLop)
        {
            DataTruocKhiSua = oldHo + "-" + oldTen + "-" + oldNgaySinh + "-" + oldDiaChi + "-" + oldMaLop;
        }

        public void PushStack_SuaSV(string MaSV)
        {
            string[] arr = DataTruocKhiSua.Split('-');
            myStack.Push("exec[dbo].[SP_PHUCHOISUASV] '" + MaSV + "', N'" + arr[0] + "', N'" + arr[1] + "', '" + arr[2] + "', N'" + arr[3] + "', '" + arr[4] + "'");
        }
        public string PopStack()
        {
            if (myStack.Count == 0)
            {
                return "Đã phục hồi hết các thao tác, không thể phục hồi được nữa!";
            }
            string sql = myStack.Pop();
            Program.ExecSqlNonQuery(sql);
            return "success";
        }
    }

}
