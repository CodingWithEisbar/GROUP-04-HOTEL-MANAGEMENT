using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DTO
{
    class phong
    {
        public phong(string maphong,string loaiphong,string tinhtranglt, string trangthaivs, string makn)
        {

            this.Makm = makn;
            this.Loaiphong = loaiphong;
            this.SOPHONG = maphong;
            this.Tinhtranglt = tinhtranglt;
            this.Trangthaivs = trangthaivs;
            

        }
        public phong(DataRow row)
        {
            this.SOPHONG = row["SOPHONG"].ToString();
            this.Makm = row["MAKHUYENMAI"].ToString();
            this.Loaiphong = row["LOAIPHONG"].ToString();
            this.Tinhtranglt = row["TINHTRANGLT"].ToString();
            this.Trangthaivs = row["TRANGTHAIVS"].ToString();

        }
        private string makm;
        public string Makm
        {
            get { return makm; }
            set { makm = value; }
        }

        private string tinhtranglt;
        public string Tinhtranglt
        {
            get { return tinhtranglt; }
            set { tinhtranglt = value; }
        }


        private string trangthaivs;
        public string Trangthaivs
        {
            get { return trangthaivs; }
            set { trangthaivs = value; }
        }

        private string loaiphong;
        public string Loaiphong
        {
            get { return loaiphong; }
            set { loaiphong = value; }
        }

        private string sOPHONG;
        public string SOPHONG
        {
            get { return sOPHONG; }
            set { sOPHONG = value; }
        }
    }
}
