using HotelManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private HoaDonDAO() { }
        public DataTable getInvoiceList (string name)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT HD.MAHD AS N'Mã hóa đơn', KH.TENKH AS N'Tên khách hàng', HD.TONGTIEN AS N'Tổng tiền'  FROM HOADON HD, KHACHHANG KH WHERE KH.MAKH = HD.MAKH AND KH.TENKH = N'" + name + "'");
        }
        
    }
  
}
