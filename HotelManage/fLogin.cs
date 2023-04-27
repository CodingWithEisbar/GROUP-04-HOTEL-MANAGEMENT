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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string role="";
            if (checkBox1.Checked) {
                role = "Bellman";
            
            }
            if (LeTanCheckBox.Checked)
            {
                role = "LT";
            }
            string username = textBox1.Text;
            string pass = textBox2.Text;
            if (login(username, pass,role))
            {
                if (checkBox1.Checked)
                {
                    BellmanDashboard f = new BellmanDashboard();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                if (LeTanCheckBox.Checked)
                {
                    fLeTanDashboard f = new fLeTanDashboard();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {


            }
        }
        bool login(string username, string pass,string role)
        {
            return AccountDAO.Instance.Login(username, pass,role);

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
