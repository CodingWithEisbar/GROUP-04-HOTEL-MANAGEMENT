using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Checkin
{
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(inputText))
            {
                // Create connection to SQL Server
                SqlConnection connection = new SqlConnection("Data Source=LAMDDT-LAPTOP;Initial Catalog=QLKHACHSAN;Integrated Security=True");

                // Create command for stored procedure
                SqlCommand command = new SqlCommand("GetTHONGTINDATPHONGById", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Create adapter for result set
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Create datatable to hold result set
                DataTable dataTable = new DataTable();

                // Fill datatable with data from adapter
                adapter.Fill(dataTable);

                // Bind datatable to datagridview
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                string madat = inputText;
                // Create connection to SQL Server
                SqlConnection connection = new SqlConnection("Data Source=LAMDDT-LAPTOP;Initial Catalog=QLKHACHSAN;Integrated Security=True");

                // Create command for stored procedure
                SqlCommand command = new SqlCommand("GetTHONGTINDATPHONGById", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for stored procedure
                command.Parameters.AddWithValue("@MADAT", madat);

                // Create adapter for result set
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Create datatable to hold result set
                DataTable dataTable = new DataTable();

                // Fill datatable with data from adapter
                adapter.Fill(dataTable);

                // Bind datatable to datagridview
                dataGridView1.DataSource = dataTable;
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputText = textBox2.Text.Trim();
            string makh = inputText;
            // Create connection to SQL Server
            SqlConnection connection = new SqlConnection("Data Source=LAMDDT-LAPTOP;Initial Catalog=QLKHACHSAN;Integrated Security=True");

            // Create command for stored procedure
            SqlCommand command = new SqlCommand("usp_GetKhachHangByMAKH", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Add parameters for stored procedure
            command.Parameters.AddWithValue("@MAKH", makh);

            // Create adapter for result set
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create datatable to hold result set
            DataTable dataTable = new DataTable();

            // Fill datatable with data from adapter
            adapter.Fill(dataTable);

            // Bind datatable to datagridview
            dataGridView3.DataSource = dataTable;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.Trim();
            string madat = inputText;
            // Create connection to SQL Server
            SqlConnection connection = new SqlConnection("Data Source=LAMDDT-LAPTOP;Initial Catalog=QLKHACHSAN;Integrated Security=True");

            // Create command for stored procedure to update the data
            SqlCommand commandUpdate = new SqlCommand("usp_UpdateThongTinDatPhong", connection);
            commandUpdate.CommandType = CommandType.StoredProcedure;
            commandUpdate.Parameters.AddWithValue("@MADAT", madat);

            // Execute the command to update the data
            connection.Open();
            int rowsAffected = commandUpdate.ExecuteNonQuery();
            connection.Close();

            // Create command for stored procedure to get the updated data
            SqlCommand commandGetData = new SqlCommand("GetTHONGTINDATPHONGById", connection);
            commandGetData.CommandType = CommandType.StoredProcedure;
            commandGetData.Parameters.AddWithValue("@MADAT", madat);

            // Create adapter for result set
            SqlDataAdapter adapter = new SqlDataAdapter(commandGetData);

            // Create datatable to hold result set
            DataTable dataTable = new DataTable();

            // Fill datatable with data from adapter
            adapter.Fill(dataTable);

            // Bind datatable to datagridview
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Create connection to SQL Server
            SqlConnection connection = new SqlConnection("Data Source=LAMDDT-LAPTOP;Initial Catalog=QLKHACHSAN;Integrated Security=True");

            // Create command for stored procedure
            SqlCommand command = new SqlCommand("usp_GetAllKhuyenMaiTheoPhong", connection);
            command.CommandType = CommandType.StoredProcedure;

            

            // Create adapter for result set
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create datatable to hold result set
            DataTable dataTable = new DataTable();

            // Fill datatable with data from adapter
            adapter.Fill(dataTable);

            // Bind datatable to datagridview
            dataGridView2.DataSource = dataTable;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
