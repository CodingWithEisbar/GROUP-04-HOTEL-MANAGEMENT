using HotelManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManage
{
    public partial class fGoiXe : Form
    {
        BindingSource stationList = new BindingSource();  
        public fGoiXe()
        {
            InitializeComponent();
            nhaXeDataGridView.DataSource = stationList;
            stationList.DataSource = DanhSachNhaXeDAO.Instance.getStationList();
        }

        private void callTaxiButt_Click(object sender, EventArgs e)
        {
            fGoiDienThoaiChoNhaXe f = new fGoiDienThoaiChoNhaXe();
            f.ShowDialog();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
