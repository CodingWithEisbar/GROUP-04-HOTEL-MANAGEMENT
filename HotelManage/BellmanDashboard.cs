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
    public partial class BellmanDashboard : Form
    {
        public BellmanDashboard()
        {
            InitializeComponent();
        }

        private void đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFormdangkithongtinvanchuyenhanhli f = new fFormdangkithongtinvanchuyenhanhli();
            f.ShowDialog();

        }

        private void kiểmTraTìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemTraTinhTrangPhong f = new KiemTraTinhTrangPhong();
            f.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachDichvu f = new DanhSachDichvu();
            f.ShowDialog();
        }
    }
}
