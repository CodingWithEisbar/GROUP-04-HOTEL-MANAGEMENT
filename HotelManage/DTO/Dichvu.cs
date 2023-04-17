using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DTO
{
    class Dichvu
    {
        public Dichvu(DataRow row)
        {
            this.Madv = row["MADICHVU"].ToString();
            this.Tendv = row["TENDICHVU"].ToString();
            this.Mota = row["MOTA"].ToString();
            this.Giatien = Convert.ToDouble(row["GIATIEN"]);
        }

        private string madv;
        public string Madv
        {
            get { return madv; }
            set { madv = value; }
        }
        private string tendv;
        public string Tendv
        {
            get { return tendv; }
            set { tendv = value; }


        }
        private double giatien;
        public double Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }

        private string mota;
        public string Mota
        {
            get { return mota; }
            set { mota = value; }

        }
    }
}