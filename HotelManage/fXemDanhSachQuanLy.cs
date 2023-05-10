using HotelManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManage
{
    public partial class fXemDanhSachQuanLy : Form
    {
        BindingSource ServiceUsingList = new BindingSource();

        public fXemDanhSachQuanLy()
        {
            InitializeComponent();
            string name = customerNameTextbox.Text;
            danhSachQuanLyDataGridView.DataSource = ServiceUsingList;
            ServiceUsingList.DataSource = QuanLyDichVuDAO.Instance.getServiceList(name);

        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextbox.Text;
            ServiceUsingList.DataSource = QuanLyDichVuDAO.Instance.getServiceList(customerName);
        }
    }
    
}
