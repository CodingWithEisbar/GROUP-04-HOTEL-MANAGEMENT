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
    public partial class fLeTanKiemtraKhuyenmai : Form
    {
        BindingSource promoList = new BindingSource();
        public fLeTanKiemtraKhuyenmai()
        {
            
            InitializeComponent();
            string roomNum = txbRoomNumber.Text;
            dataGridView1.DataSource = promoList;
            promoList.DataSource = PhongDAO.Instance.getRoomPromotion(roomNum);
            richTextBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NOIDUNG", true, DataSourceUpdateMode.Never));
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            string roomNum = txbRoomNumber.Text;
            promoList.DataSource = PhongDAO.Instance.getRoomPromotion(roomNum);

        }
    }
}
