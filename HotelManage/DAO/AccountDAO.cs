using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class AccountDAO
    {

        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }

        }
        private AccountDAO() { }
        public bool Login(String username, string password,string role)
        {
            string query = "select * from dbo.TAIKHOAN where USERNAME='" + username + "'AND  PASS= '" + password + "'AND VAITRO='"+role+"'  ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
 

    }

}

