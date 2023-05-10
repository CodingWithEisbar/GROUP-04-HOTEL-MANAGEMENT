using HotelManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class DanhSachNhaXeDAO
    {
        private static DanhSachNhaXeDAO instance;
        public static DanhSachNhaXeDAO Instance
        {
            get { if (instance == null) instance = new DanhSachNhaXeDAO(); return instance; }
            private set { instance = value; }
        }

        private DanhSachNhaXeDAO() { }
        public DataTable getStationList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MANHAXE AS N'Mã nhà xe', TENNHAXE AS N'Tên nhà xe', SODT AS N'Số điện thoại' FROM DANHSACHNHAXE");
        }

        public List<DanhSachNhaXe> layDanhSachDichVu() 
        {
            List<DanhSachNhaXe> danhSachNhaXe = new List<DanhSachNhaXe>();
            string sql_query = "dbo.USP_LayDanhSachNhaXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql_query);

            foreach (DataRow item in data.Rows) 
            {
                DanhSachNhaXe table = new DanhSachNhaXe(item);
                danhSachNhaXe.Add(table);  

            }

            return danhSachNhaXe;
        }
    }
}
