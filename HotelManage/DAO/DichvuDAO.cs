using HotelManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.DAO
{
    class DichvuDAO
    {
        private static DichvuDAO instance;
        public static DichvuDAO Instance
        {
            get { if (instance == null) instance = new DichvuDAO(); return instance; }
            private set { instance = value; }

        }
        private DichvuDAO() { }
        public DataTable getServiceList()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM DICHVU");
        }
        public List<Dichvu> laydanhsachdichvu()
        {
            List<Dichvu> tablelist = new List<Dichvu>();
            string query = "dbo.USP_laydanhsachdichvu" ;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                Dichvu table = new Dichvu(item);
                tablelist.Add(table);
            }
            return tablelist;
        }


    }

}

