using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DTO
{
    class DanhSachNhaXe
    {
        public DanhSachNhaXe(DataRow row)
        {
            this.MaNhaXe = row["MANHAXE"].ToString();
            this.TenNhaXe = row["TENNHAXE"].ToString();
            this.SoDT = row["SODT"].ToString() ;
        }

        private string manhaxe;
        public string MaNhaXe
        {
            get { return manhaxe; }
            set { manhaxe = value; }
        }

        private string tennhaxe;
        public string TenNhaXe
        {
            get { return tennhaxe; }
            set { tennhaxe = value; }
        }

        private string sodt;
        public string SoDT
        {
            get { return sodt; }
            set { sodt = value; }
        }
    }
}
