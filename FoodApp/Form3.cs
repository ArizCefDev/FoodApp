using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private const string constring = @"Server=WIN-VD08C7OPT8H\SQLEXPRESS; Database=FoodAppDB; Trusted_Connection=true; Encrypt=false;";

        SqlConnection connection = new SqlConnection(constring);

        public void Show()
        {
            connection.Open();
            string cmd = "SELECT * FROM OrderTab";
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Show();
        }

        public void Delete(int id)
        {
            connection.Open();
            string cmd = "DELETE FROM OrderTab WHERE id=@id";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);

                Delete(id);

                Show();
            }
        }
    }
}
