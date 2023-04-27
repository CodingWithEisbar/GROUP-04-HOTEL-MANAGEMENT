using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DTO
{
    class TourDuLich
    {
        private string matour;
        public string Matour
        {
            get { return matour; }
            set { matour = value; }
        }

        private string diadiem;
        public string Diadiem
        {
            get { return diadiem; }
            set { diadiem = value; }
        }


        private string mota;
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        private string tgkhoihanh;
        public string TGkhoihanh
        {
            get { return tgkhoihanh; }
            set { tgkhoihanh = value; }
        }

        private string dvluhanh;
        public string DVluhanh
        {
            get { return dvluhanh; }
            set { dvluhanh = value; }
        }
        public TourDuLich(DataRow row)
        {
            this.Matour = row["MATOUR"].ToString();
            this.Mota = row["MOTA"].ToString();
            this.Diadiem = row["DIADIEM"].ToString();
            this.TGkhoihanh = row["THOIGIANKHOIHANH"].ToString();
            this.DVluhanh = row["DONVILUHANH"].ToString();
        }
    }
}
