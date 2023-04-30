using HotelManage.DAO;
using HotelManage.DTO;
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
    public partial class KiemTraTinhTrangPhong : Form
    {
        private string status;
        public KiemTraTinhTrangPhong()
        {
            InitializeComponent();
        }
        void loadStatus()
        {

            List<phong> listroom = phongDAO.Instance.checkStatus(maPhongTextBox.Text);
            foreach(phong Item in listroom)
            {
                this.status = Item.Trangthaivs.ToString();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadStatus(); 
            string thongbao = "Phòng trong trạng thái " + this.status;
            MessageBox.Show(thongbao, "Notification");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
