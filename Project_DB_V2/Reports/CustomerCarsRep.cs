using Microsoft.Reporting.WinForms;
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
    
    public partial class CustomerCarsRep : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        public CustomerCarsRep()
        {
            InitializeComponent();
        }

        private void CustomerCarsRep_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Customers.Customer_ID, Customers.C_Name, Cars.Car_ID, Cars.Manufacture FROM Cars INNER JOIN Customers ON Cars.Customer_ID = Customers.Customer_ID", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1" , dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\user\source\repos\Project_DB_V2\Project_DB_V2\Reports\CustomerCarReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
           

            this.reportViewer1.RefreshReport();
        }
    }
}
