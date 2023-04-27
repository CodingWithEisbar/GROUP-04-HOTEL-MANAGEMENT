using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class PhieuSuDungDVDAO
    {
        private static PhieuSuDungDVDAO instance;
        public static PhieuSuDungDVDAO Instance
        {
            get { if (instance == null) instance = new PhieuSuDungDVDAO(); return instance; }
            private set { instance = value; }

        }
        private PhieuSuDungDVDAO()
        {

        }
        public bool TaoPhieuSudungDichVu(string makh, string ngaylap, string dichvusudung)
        {

            string query = "EXEC USP_TaoPhieuSudungDichvu @MAKH , @NGAYLAP , @DICHVUSUDUNG";
            int result = DataProvider.Instance.ExcutenonQuery(query, new object[] { makh, ngaylap, dichvusudung });
            return result > 0;
        }
    }
}
