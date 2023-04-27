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
    public partial class fLeTanTaoPhieuDangKyTourDuLich : Form
    {
        BindingSource tourList = new BindingSource();
        BindingSource clientInform = new BindingSource();
        public fLeTanTaoPhieuDangKyTourDuLich()
        {
            InitializeComponent();
            string name = txbClientName.Text;
            dtgvClientInformation.DataSource = clientInform;
            clientInform.DataSource = KhachhangDAO.Instance.getClientInFormation(name);
            txbClientID.DataBindings.Add(new Binding("Text", dtgvClientInformation.DataSource, "MAKH", true, DataSourceUpdateMode.Never));
            dtgvTourList.DataSource = tourList;
            tourList.DataSource = TourDuLichDAO.Instance.getTourList();
            txbTourID.DataBindings.Add(new Binding("Text", dtgvTourList.DataSource, "MATOUR", true, DataSourceUpdateMode.Never));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbClientName.Text;
            clientInform.DataSource = KhachhangDAO.Instance.getClientInFormation(name);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ID = txbClientID.Text;
            string tourID = txbTourID.Text;
            string numOpeople = txbNumOfPeople.Text;
            string transp = cbbTransportation.Text;
            string special = richtxbSpecialOrder.Text;
            string Create = txbCreateDate.Text;
            if (PhieuDangKyTourDulichDAO.Instance.TaoPhieuDangKyTourDuLich(ID, tourID, numOpeople, transp, special, Create))
            {
                MessageBox.Show("Đã tạo phiếu thành công");
            }
            else
            {
                MessageBox.Show("Tạo thất bại");
            }
        }
    }
}
