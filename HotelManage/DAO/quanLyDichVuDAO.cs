using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class quanLyDichVuDAO
    {
        private static quanLyDichVuDAO instance;
        public static quanLyDichVuDAO Instance
        {
            get { if (instance == null) instance = new quanLyDichVuDAO(); return instance; }
            private set { instance = value; }

        }
        private quanLyDichVuDAO() { }
        public DataTable getServiceList()
        {
            // Xem danh sách các khách hàng và dịch vụ mà họ sử dụng
            return DataProvider.Instance.ExecuteQuery("USP_QuanLyDichVuKhachHangSuDung");
        }
        
    }
}
