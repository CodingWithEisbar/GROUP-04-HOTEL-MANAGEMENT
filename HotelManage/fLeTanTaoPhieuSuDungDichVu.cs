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
    public partial class fLeTanTaoPhieuSuDungDichVu : Form
    {
        BindingSource clientList = new BindingSource();
        public fLeTanTaoPhieuSuDungDichVu()
        {
            InitializeComponent();
            string name = txbClientName.Text;
            dataGridView1.DataSource = clientList;
            clientList.DataSource = KhachhangDAO.Instance.getClientInFormation(name);
            txbClientID.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MAKH", true, DataSourceUpdateMode.Never));

        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            string name = txbClientName.Text;
            clientList.DataSource = KhachhangDAO.Instance.getClientInFormation(name);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ID = txbClientID.Text;
            string CreateDate = txbCreatedDate.Text;
            string Service = cbbService.Text;
            if (PhieuSuDungDVDAO.Instance.TaoPhieuSudungDichVu(ID, CreateDate, Service))
            {
                MessageBox.Show("Đã tạo phiếu thành công");
            }
            else { 
                MessageBox.Show("Tạo thất bại");
            }
        }
    }
}
