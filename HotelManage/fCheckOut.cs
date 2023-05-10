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
    public partial class fCheckOut : Form
    {
        public fCheckOut()
        {
            InitializeComponent();
        }

        private void xemDanhSachQuanLyButton_Click(object sender, EventArgs e)
        {
            fXemDanhSachQuanLy f = new fXemDanhSachQuanLy();    
            f.ShowDialog();
        }
        private void backButt_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tinhTrangPhongButton_Click(object sender, EventArgs e)
        {
            fXemTinhTrangPhong f = new fXemTinhTrangPhong();
            f.ShowDialog();
        }

        private void goiXeButton_Click(object sender, EventArgs e)
        {
            fGoiXe f = new fGoiXe();
            f.ShowDialog(); 
        }

        private void capNhatTinhTrangPhongButton_Click(object sender, EventArgs e)
        {
            fCapNhatTinhTrangPhong f = new fCapNhatTinhTrangPhong();
            f.ShowDialog();
        }

        private void ghiNhanYKienButton_Click(object sender, EventArgs e)
        {
            fGhiNhanYKienKH f = new fGhiNhanYKienKH(); 
            f.ShowDialog();
        }

        private void xemHoaDonButton_Click(object sender, EventArgs e)
        {
            fXemHoaDon f = new fXemHoaDon();
            f.ShowDialog(); 
        }
    }
}
