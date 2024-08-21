using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DB_V2
{
    public partial class CustomerCars : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public CustomerCars()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select Customers.Customer_ID , Customers.C_Name , Cars.Manufacture From Customers " +
                "JOIN Cars ON Customers.Customer_ID = Cars.Customer_ID Order By Customers.C_Name;", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
