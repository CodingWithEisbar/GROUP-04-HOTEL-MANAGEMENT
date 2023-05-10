using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class TinhTrangPhongDAO
    {
        private static TinhTrangPhongDAO instance;
        public static TinhTrangPhongDAO Instance
        {
            get { if (instance == null) instance = new TinhTrangPhongDAO(); return instance; }
            private set { instance = value; }
        }
        private TinhTrangPhongDAO() { }
        public DataTable getRoomReturnStatus(string roomNumber)
        {
            if (roomNumber == "*")
                return DataProvider.Instance.ExecuteQuery("SELECT TP.MABAOCAO AS N'Mã báo cáo', TP.MAPHONG AS N'Số phòng', MAKH AS N'Mã khách hàng', TP.NGAYLAP AS N'Ngày ghi nhận', BG.TENVATDUNG AS N'Vật dụng hư hại', TP.NOIDUNG AS N'Mô tả', TP.THANHTIEN AS N'Tiền bồi thường' FROM TINHTRANGTRAPHONG TP, BANGGIAVATDUNG BG WHERE TP.MAVATDUNGHUDAI = BG.MAVATDUNG");
            return DataProvider.Instance.ExecuteQuery("SELECT TP.MABAOCAO AS N'Mã báo cáo', TP.MAPHONG AS N'Số phòng', MAKH AS N'Mã khách hàng', TP.NGAYLAP AS N'Ngày ghi nhận', BG.TENVATDUNG AS N'Vật dụng hư hại', TP.NOIDUNG AS N'Mô tả', TP.THANHTIEN AS N'Tiền bồi thường' FROM TINHTRANGTRAPHONG TP, BANGGIAVATDUNG BG WHERE TP.MAVATDUNGHUDAI = BG.MAVATDUNG AND TP.MAPHONG = '" + roomNumber +"'");
        }
    }
}
