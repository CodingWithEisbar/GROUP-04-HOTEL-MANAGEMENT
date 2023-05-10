using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DTO
{
    class HoaDon
    {
        public HoaDon(DataRow row) 
        { 
            this.MaHoaDon = row["MAHD"].ToString();
            this.MaKH = row["MAKH"].ToString();
            this.TongTien = row["TONGTIEN"].ToString() ;
        }

        private string mahoadon;
        public string MaHoaDon
        {
            get { return mahoadon; }   
            set { mahoadon = value; }   
        }

        private string makh;
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }

        private string tongtien;
        public string TongTien
        {
            get { return tongtien; } 
            set { tongtien = value; }    
        }
    }
}
