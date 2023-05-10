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
    public partial class fXemHoaDon : Form
    {
        BindingSource invoiceList = new BindingSource();

        public fXemHoaDon()
        {
            InitializeComponent();
            string name = customerNameTextbox.Text;
            hoaDonDataGridView.DataSource = invoiceList;
            invoiceList.DataSource = HoaDonDAO.Instance.getInvoiceList(name);
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextbox.Text;
            invoiceList.DataSource = HoaDonDAO.Instance.getInvoiceList(customerName);
        }

        private void inHoaDonButton_Click(object sender, EventArgs e)
        {
            fInHoaDon f = new fInHoaDon();
            f.ShowDialog();
        }
    }
}
