using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class dichvuvanvhuyenhanhliDAO
    {

        private static dichvuvanvhuyenhanhliDAO instance;
        public static dichvuvanvhuyenhanhliDAO Instance
        {
            get { if (instance == null) instance = new dichvuvanvhuyenhanhliDAO(); return instance; }
            private set { instance = value; }

        }
        private dichvuvanvhuyenhanhliDAO() {
        
        }
        public void Signin(string solong, string sophong)
        {

            string query = "dbo.USP_dangkithongtivanchuyen " + solong + "," + "'" + sophong + "'";

            DataProvider.Instance.ExcutenonQuery(query);

        }
    
    }
}
