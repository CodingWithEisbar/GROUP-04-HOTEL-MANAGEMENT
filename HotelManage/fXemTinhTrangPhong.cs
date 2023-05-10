using HotelManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManage
{
    public partial class fXemTinhTrangPhong : Form
    {
        BindingSource roomReturnStatus = new BindingSource();
        public fXemTinhTrangPhong()
        {
            InitializeComponent();
            string roomID = roomIDTextbox.Text;
            tinhTrangPhongDataGridView.DataSource = roomReturnStatus;
            roomReturnStatus.DataSource = PhongDAO.Instance.getRoomReturnStatus(roomID);
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string roomID = roomIDTextbox.Text;
            roomReturnStatus.DataSource = PhongDAO.Instance.getRoomReturnStatus(roomID);
        }
    }
}
