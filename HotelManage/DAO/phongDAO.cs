using HotelManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }

        }
        private PhongDAO() { }
        public DataTable getRoomPromotion(string roomNumber)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KHUYENMAITHEOPHONG WHERE SOPHONG = '" + roomNumber + "'");
        }

        public DataTable getRoomReturnStatus(string roomNumber)
        {
            if (roomNumber == "*")
                return DataProvider.Instance.ExecuteQuery("SELECT SOPHONG AS N'Số phòng', LOAIPHONG AS N'Loại phòng', TINHTRANGLT AS N'Tình trạng lưu trú', TRANGTHAIVS AS N'Trạng thái vệ sinh' FROM PHONG");
            return DataProvider.Instance.ExecuteQuery("SELECT SOPHONG AS N'Số phòng', LOAIPHONG AS N'Loại phòng', TINHTRANGLT AS N'Tình trạng lưu trú', TRANGTHAIVS AS N'Trạng thái vệ sinh' FROM PHONG WHERE SOPHONG = '" + roomNumber + "'");
        }

        public List<phong> checkStatus(string sophong)
        {
            List<phong> tablelist = new List<phong>();
            string query = "dbo.USP_kiemtratinhtrangvesinh " + "'" + sophong + "'" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                phong table = new phong(item);
                tablelist.Add(table);
            }
            return tablelist;
        }


    }
}
