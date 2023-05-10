using HotelManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManage
{
    public partial class fCapNhatTinhTrangPhong : Form
    {
        BindingSource roomStatusUpdate = new BindingSource();  
        public fCapNhatTinhTrangPhong()
        {
            InitializeComponent();
            string roomID = roomIDTextbox.Text;
            capNhatDataGridView.DataSource = roomStatusUpdate;
            roomStatusUpdate.DataSource = PhongDAO.Instance.getRoomReturnStatus(roomID);

        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string roomID = roomIDTextbox.Text;
            roomStatusUpdate.DataSource = PhongDAO.Instance.getRoomReturnStatus(roomID);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int x = capNhatDataGridView.CurrentCell.RowIndex;
            string tinhTrangLT = capNhatDataGridView.Rows[x].Cells[2].Value.ToString().Trim();
            string trangThaiVeSinh = capNhatDataGridView.Rows[x].Cells[3].Value.ToString().Trim();
            string soPhong = capNhatDataGridView.Rows[x].Cells[0].Value.ToString().Trim();
            string sql_query = "EXEC USP_Update @TINHTRANGLT = N'" + tinhTrangLT + "', @TRANGTHAIVS = N'" + trangThaiVeSinh + "', @SOPHONG = '" + soPhong + "';";
            try
            {
                DataProvider.Instance.ExecuteQuery(sql_query);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
