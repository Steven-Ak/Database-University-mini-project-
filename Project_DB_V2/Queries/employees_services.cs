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
    public partial class employees_services : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public employees_services()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select Employees.Emp_Id,Employees.E_Name,Services.S_Type from Employees JOIN Works_On ON Employees.Emp_Id=Works_On.Emp_Id " +
               "jOIN Services ON Works_On.Service_ID = Services.Service_ID;", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
