using Microsoft.Data.SqlClient;
using System.Data;

namespace FoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string constring = @"Server=WIN-VD08C7OPT8H\SQLEXPRESS; Database=FoodAppDB; Trusted_Connection=true; Encrypt=false;";

        SqlConnection connection = new SqlConnection(constring);
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "SELECT * FROM MenuTab";
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = @"INSERT INTO OrderTab(No, FoodName, Porsion, Description)
                          VALUES(@no,@fname, @porsion, @description )";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@no", textBox3.Text);
            command.Parameters.AddWithValue("@fname", textBox1.Text);
            command.Parameters.AddWithValue("@porsion", textBox2.Text);
            command.Parameters.AddWithValue("@description", richTextBox1.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Sifaris qebul olundu");
            connection.Close();
        }
    }
}