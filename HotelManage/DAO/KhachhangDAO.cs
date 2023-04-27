using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class KhachhangDAO
    {
        private static KhachhangDAO instance;
        public static KhachhangDAO Instance
        {
            get { if (instance == null) instance = new KhachhangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachhangDAO()
        {

        }
        public DataTable getClientInFormation(string name)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM KHACHHANG WHERE TENKH = N'" + name + "'");
        }
    }
}
