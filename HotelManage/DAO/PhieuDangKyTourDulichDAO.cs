using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class PhieuDangKyTourDulichDAO
    {
        private static PhieuDangKyTourDulichDAO instance;
        public static PhieuDangKyTourDulichDAO Instance
        {
            get { if (instance == null) instance = new PhieuDangKyTourDulichDAO(); return instance; }
            private set { instance = value; }

        }
        private PhieuDangKyTourDulichDAO()
        {

        }
        public bool TaoPhieuDangKyTourDuLich(string makh, string matour, string numOpeople, string transport, string specialOrder, string CreateDate)
        {
            string query = "EXEC  USP_TaoPhieuDangKyTour @MAKH , @MATOUR , @SONGUOITHAMGIA , @HINHTHUCDICHUYEN , @YEUCAUDACBIET , @NGAYLAP ";
            int result = DataProvider.Instance.ExcutenonQuery(query, new object[] { makh, matour, numOpeople, transport, specialOrder, CreateDate });
            return result > 0;
        }
    }
}
