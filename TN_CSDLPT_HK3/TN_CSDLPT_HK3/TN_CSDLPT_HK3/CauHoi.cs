using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT_HK3
{
    class CauHoi
    {
        private string idCauHoi;
        private string maMH;
        private string maGV;
        private string trinhDo;
        private string noiDung;
        private string a;
        private string b;
        private string c;
        private string d;
        private string dapAn;
        private string daChon;
        public CauHoi()
        {
            this.idCauHoi = "";
            this.maMH = "";
            this.maGV = "";
            this.trinhDo = "";
            this.noiDung = "";
            this.a = "";
            this.b = "";
            this.c = "";
            this.d = "";
            this.dapAn = "";
            this.daChon = "";
        }
        public string IDCauHoi { get; set; }
        public string MaMH { get; set; }
        public string MaGV { get; set; }
        public string TrinhDo { get; set; }
        public string NoiDung { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string DapAn { get; set; }
        public string DaChon { get; set; }
    }

}
