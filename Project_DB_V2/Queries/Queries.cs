using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Project_DB_V2
{
    public partial class Queries : Form
    {
        private Form activeForm;

        public Queries()
        {
            InitializeComponent();
        }

        
        
        private void carTotalCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTotalCost carTotalCost = new CarTotalCost() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = carTotalCost;
            panelStrip.Controls.Add(carTotalCost);
            carTotalCost.FormBorderStyle = FormBorderStyle.None;
            carTotalCost.Dock = DockStyle.Fill;
            panelStrip.Controls.Add(carTotalCost);
            panelStrip.Tag = carTotalCost;
            carTotalCost.BringToFront();
            carTotalCost.Show();
            labelq.Text = "Total Cost For Each Car";
        }

        private void customerCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCars customerCars = new CustomerCars() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = customerCars;
            panelStrip.Controls.Add(customerCars);
            customerCars.FormBorderStyle = FormBorderStyle.None;
            customerCars.Dock = DockStyle.Fill;
            panelStrip.Controls.Add(customerCars);
            panelStrip.Tag = customerCars;
            customerCars.BringToFront();
            customerCars.Show();
            labelq.Text = "Cars That Each Customer Have";
        }

        private void branchEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranchEmployees branchEmployees = new BranchEmployees() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = branchEmployees;
            panelStrip.Controls.Add(branchEmployees);
            branchEmployees.FormBorderStyle = FormBorderStyle.None;
            branchEmployees.Dock = DockStyle.Fill;
            panelStrip.Controls.Add(branchEmployees);
            panelStrip.Tag = branchEmployees;
            branchEmployees.BringToFront();
            branchEmployees.Show();
            labelq.Text = "Employees That Each Branch Has";
        }

        private void employeesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees_services employees_Services = new employees_services() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();
            activeForm = employees_Services;
            panelStrip.Controls.Add(employees_Services);
            employees_Services.FormBorderStyle = FormBorderStyle.None;
            employees_Services.Dock = DockStyle.Fill;
            panelStrip.Controls.Add(employees_Services);
            panelStrip.Tag = employees_Services;
            employees_Services.BringToFront();
            employees_Services.Show();
            labelq.Text = "Services That Each Employee Does";

        }
    }
}
