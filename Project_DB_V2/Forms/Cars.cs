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
    public partial class Cars : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_MaintainenceDataSet1.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter1.Fill(this.car_MaintainenceDataSet1.Cars);
            // TODO: This line of code loads data into the 'car_MaintainenceDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.car_MaintainenceDataSet.Cars);
            disp_data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Cars Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
            cmd.CommandText = "select * from Cars";
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
            cmd.CommandText = "Update Cars Set Branch_ID = '" + textBox2.Text + "' , Manufacture = '" + textBox3.Text + "' , Customer_ID = '" + textBox4.Text + "' , Model = '" + textBox5.Text + "' where Car_ID = '" + textBox1.Text + "' ";
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
            cmd.CommandText = "Delete from Cars where Car_ID = '" + textBox1.Text + "'";
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
            textBox5.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cleardata();
        }
    }
}
