using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HotelManage
{
    public partial class fInHoaDon : Form
    {
        
        public fInHoaDon()
        {
            InitializeComponent();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy quá trình", "Hủy quá trình in", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
