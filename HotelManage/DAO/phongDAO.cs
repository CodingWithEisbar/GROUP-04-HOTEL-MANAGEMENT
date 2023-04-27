using HotelManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class phongDAO
    {
        private static phongDAO instance;
        public static phongDAO Instance
        {
            get { if (instance == null) instance = new phongDAO(); return instance; }
            private set { instance = value; }

        }
        private phongDAO() { }
        public DataTable getRoomPromotion(string roomNumber)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM KHUYENMAITHEOPHONG WHERE SOPHONG = '" + roomNumber + "'");
        }
        public List<phong> checkStatus(string sophong)
        {
            List<phong> tablelist = new List<phong>();
            string query = "dbo.USP_kiemtratinhtrangvesinh " + "'" + sophong + "'" ;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                phong table = new phong(item);
                tablelist.Add(table);
            }
            return tablelist;
        }


    }
}
