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
    public partial class fLeTanTourDuLich : Form
    {
        BindingSource tourList = new BindingSource();
        public fLeTanTourDuLich()
        {
            InitializeComponent();
            dataGridView1.DataSource = tourList;
            tourList.DataSource = TourDuLichDAO.Instance.getTourList();
            txbTourDestination.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DIADIEM", true, DataSourceUpdateMode.Never));
            txbStartDate.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "THOIGIANKHOIHANH", true, DataSourceUpdateMode.Never));
            txbTravelUnit.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DONVILUHANH", true, DataSourceUpdateMode.Never));
            richtxbTourDetails.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MOTA", true, DataSourceUpdateMode.Never));
        }
    }
}
