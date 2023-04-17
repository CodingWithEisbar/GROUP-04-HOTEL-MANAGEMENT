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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManage
{
    public partial class DanhSachDichvu : Form
    {
        public DanhSachDichvu()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachDichvu_Load(object sender, EventArgs e)
        {
            load();
        }
        
        void load()
        {
            listView1.Items.Clear();

            List<Dichvu> lisrodr = DAO.DichvuDAO.Instance.laydanhsachdichvu();
            foreach (Dichvu item in lisrodr)
            {
                ListViewItem lvsItem = new ListViewItem(item.Madv.ToString());

                lvsItem.SubItems.Add(item.Tendv.ToString());
                lvsItem.SubItems.Add(item.Giatien.ToString());

                lvsItem.SubItems.Add(item.Mota.ToString());
                listView1.Items.Add(lvsItem);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
