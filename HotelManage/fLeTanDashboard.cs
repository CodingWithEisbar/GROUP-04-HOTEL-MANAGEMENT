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
    public partial class fLeTanDashboard : Form
    {
        public fLeTanDashboard()
        {
            InitializeComponent();
        }

        private void kiểmTraKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLeTanKiemtraKhuyenmai f = new fLeTanKiemtraKhuyenmai();
            f.ShowDialog();
        }

        private void bảngGiáDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLeTanBangGiaDichvu f = new fLeTanBangGiaDichvu();
            f.ShowDialog();
        }

        private void TourDulichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLeTanTourDuLich f = new fLeTanTourDuLich();
            f.ShowDialog();
        }

        private void tạoPhiếuSửDụngDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fLeTanTaoPhieuSuDungDichVu f = new fLeTanTaoPhieuSuDungDichVu();
            f.ShowDialog();
        }

        private void tạoPhiếuĐăngKýTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLeTanTaoPhieuDangKyTourDuLich f = new fLeTanTaoPhieuDangKyTourDuLich();
            f.ShowDialog();
        }

        private void checkOutMenuItem_Click(object sender, EventArgs e)
        {
            fCheckOut f = new fCheckOut();
            f.ShowDialog();
        }
    }
}
