using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DB_V2
{
    
    public partial class Reports : Form
    {
        private Form activeForm;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        public Reports()
        {
            InitializeComponent();
        }

     

        private void Reports_Load(object sender, EventArgs e)
        {
            
        }

        private void customerCarReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCarsRep customerCars = new CustomerCarsRep() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = customerCars;
            panel1.Controls.Add(customerCars);
            customerCars.FormBorderStyle = FormBorderStyle.None;
            customerCars.Dock = DockStyle.Fill;
            panel1.Controls.Add(customerCars);
            panel1.Tag = customerCars;
            customerCars.BringToFront();
            customerCars.Show();
            labelr.Text = "Customer Cars Report";
        }

        private void managerBranchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerBranchRep managerBranchRep = new ManagerBranchRep() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = managerBranchRep;
            panel1.Controls.Add(managerBranchRep);
            managerBranchRep.FormBorderStyle = FormBorderStyle.None;
            managerBranchRep.Dock = DockStyle.Fill;
            panel1.Controls.Add(managerBranchRep);
            panel1.Tag = managerBranchRep;
            managerBranchRep.BringToFront();
            managerBranchRep.Show();
            labelr.Text = "Manager Branch Report";
        }
    }
}
