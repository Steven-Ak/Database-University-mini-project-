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


namespace Project_DB_V2
{
    public partial class Customers : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_MaintainenceDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.car_MaintainenceDataSet.Customers);
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Customers Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            disp_data();
            MessageBox.Show("Record Inserted Successfully");
        }
        public void disp_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customers";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Customers Set Branch_ID = '" + textBox2.Text + "' , C_Name = '" + textBox3.Text + "' , C_Phone = '" + textBox4.Text + "' where Customer_ID = '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();

            disp_data();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Customers where Customer_ID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();

            disp_data();
            MessageBox.Show("Record Deleted Successfully");
        }
        void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cleardata();
        }
    }
}
