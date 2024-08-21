﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_DB_V2
{
    public partial class Tools : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        public Tools()
        {
            InitializeComponent();
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_MaintainenceDataSet.Tools' table. You can move, or remove it, as needed.
            this.toolsTableAdapter.Fill(this.car_MaintainenceDataSet.Tools);
            disp_data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Tools Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
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
            cmd.CommandText = "select * from Tools";
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
            cmd.CommandText = "Update Tools Set T_Discreption = '" + textBox2.Text + "' , Quantity_Avaliable = '" + textBox3.Text +"' , Branch_ID = '" + textBox4.Text + "' where Tool_ID = '" + textBox1.Text + "' ";
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
            cmd.CommandText = "Delete from Tools where Tool_ID = '" + textBox1.Text + "'";
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
