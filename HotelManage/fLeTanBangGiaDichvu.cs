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
    public partial class fLeTanBangGiaDichvu : Form
    {
        BindingSource ServList = new BindingSource();
        public fLeTanBangGiaDichvu()
        {
            InitializeComponent();
            dataGridView1.DataSource = ServList;
            ServList.DataSource = DichvuDAO.Instance.getServiceList();
            txbServName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TENDICHVU", true, DataSourceUpdateMode.Never));
            txbServPrice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GIATIEN", true, DataSourceUpdateMode.Never));
            richtxbServDetails.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MOTA", true, DataSourceUpdateMode.Never));
        }
    }
}
