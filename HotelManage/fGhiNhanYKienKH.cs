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
    public partial class fGhiNhanYKienKH : Form
    {
        public fGhiNhanYKienKH()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn quý khách đã đóng góp ý kiến cho chúng tôi", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
