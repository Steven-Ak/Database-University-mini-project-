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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;
using Microsoft.Reporting.WinForms;

namespace Project_DB_V2
{
    public partial class ManagerBranchRep : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        public ManagerBranchRep()
        {
            InitializeComponent();
           
        }

        private void ManagerBranchRep_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" SELECT Employees.E_Name, Branches.Manager_ID, Branches.City, Branches.Location, Branches.Branch_ID FROM Branches INNER JOIN Employees ON Branches.Manager_ID = Employees.Emp_Id AND Branches.Branch_ID = Employees.Branch_Id", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\user\source\repos\Project_DB_V2\Project_DB_V2\Reports\ManagerBranchRep.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
