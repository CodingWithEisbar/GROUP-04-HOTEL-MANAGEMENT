using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class TourDuLichDAO
    {
        private static TourDuLichDAO instance;
        public static TourDuLichDAO Instance
        {
            get { if (instance == null) instance = new TourDuLichDAO(); return instance; }
            private set { instance = value; }
        }
        private TourDuLichDAO()
        {

        }
        public DataTable getTourList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM TOURDULICH");
        }
    }
}
