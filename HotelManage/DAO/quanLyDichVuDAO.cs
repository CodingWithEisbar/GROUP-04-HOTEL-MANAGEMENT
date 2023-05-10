using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class QuanLyDichVuDAO
    {
        private static QuanLyDichVuDAO instance;
        public static QuanLyDichVuDAO Instance
        {
            get { if (instance == null) instance = new QuanLyDichVuDAO(); return instance; }
            private set { instance = value; }

        }
        private QuanLyDichVuDAO() { }
        public DataTable getServiceList(string name)
        {
            // Xem danh sách các khách hàng và dịch vụ mà họ sử dụng
            if(name == "*")
                return DataProvider.Instance.ExecuteQuery("SELECT DV.TENDICHVU AS N'Tên dịch vụ', DV.GIATIEN AS N'Giá tiền', KH.TENKH AS N'Tên khách hàng' FROM DICHVU DV, PHIEU PH, PHIEUDANGKYDICHVU PHDV, KHACHHANG KH WHERE KH.MAKH = PH.MAKH AND PHDV.MAPHIEU = PH.MAPHIEU AND PHDV.DICHVUSUDUNG = DV.MADICHVU");
            return DataProvider.Instance.ExecuteQuery("SELECT DV.TENDICHVU AS N'Tên dịch vụ', DV.GIATIEN AS N'Giá tiền', KH.TENKH AS N'Tên khách hàng' FROM DICHVU DV, PHIEU PH, PHIEUDANGKYDICHVU PHDV, KHACHHANG KH WHERE KH.MAKH = PH.MAKH AND PHDV.MAPHIEU = PH.MAPHIEU AND PHDV.DICHVUSUDUNG = DV.MADICHVU AND KH.TENKH = N'" + name + "'");
        }
        
    }
}
