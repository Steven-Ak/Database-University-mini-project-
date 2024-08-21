using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DB_V2
{
    public partial class Form1 : Form
    {
        //fields
        private Button curbutton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
       
        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnclose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        public string LabelText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void ActivateBtn(object btnsender)
        {
            if (btnsender != null) 
            { 
                if(curbutton != (Button) btnsender) 
                {
                    DeactivateBtn();
                    
                    curbutton = (Button) btnsender;
                    curbutton.BackColor = Color.FromArgb(0, 150, 136);
                    curbutton.ForeColor = Color.White;
                    curbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(0, 150, 136), -0.3);
                    btnclose.Visible = true;


                }
            }
        }
        private void DeactivateBtn()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }


        private void Reset()
        {
            DeactivateBtn();
            label1.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            curbutton = null;
            btnclose.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees() { TopLevel = false , TopMost = true};
            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = employees;
            panelDesktop.Controls.Add(employees);
            employees.FormBorderStyle = FormBorderStyle.None;
            employees.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(employees);
            panelDesktop.Tag = employees;
            employees.BringToFront();
            employees.Show();
            label1.Text = employees.Text;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Branches branches = new Branches() { TopLevel = false, TopMost = true };

            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = branches;
            panelDesktop.Controls.Add(branches);
            branches.FormBorderStyle = FormBorderStyle.None;
            branches.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(branches);
            panelDesktop.Tag = branches;
            branches.BringToFront();
            branches.Show();
            label1.Text = branches.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Customers customers = new Customers() { TopLevel = false, TopMost = true };

            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = customers;
            panelDesktop.Controls.Add(customers);
            customers.FormBorderStyle = FormBorderStyle.None;
            customers.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(customers);
            panelDesktop.Tag = customers;
            customers.BringToFront();
            customers.Show();
            label1.Text = customers.Text;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = cars;
            panelDesktop.Controls.Add(cars);
            cars.FormBorderStyle = FormBorderStyle.None;
            cars.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(cars);
            panelDesktop.Tag = cars;
            cars.BringToFront();
            cars.Show();
            label1.Text = cars.Text;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Services services = new Services() { TopLevel = false, TopMost = true };
            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = services;
            panelDesktop.Controls.Add(services);
            services.FormBorderStyle = FormBorderStyle.None;
            services.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(services);
            panelDesktop.Tag = services;
            services.BringToFront();
            services.Show();
            label1.Text = services.Text;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools() { TopLevel = false, TopMost = true };
            
            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = tools;
            panelDesktop.Controls.Add(tools);
            tools.FormBorderStyle = FormBorderStyle.None;
            tools.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(tools);
            panelDesktop.Tag = tools;
            tools.BringToFront();
            tools.Show();
            label1.Text = tools.Text;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports() { TopLevel = false, TopMost = true };

            if (activeForm != null)
                activeForm.Close();

            ActivateBtn(sender);
            activeForm = reports;
            panelDesktop.Controls.Add(reports);
            reports.FormBorderStyle = FormBorderStyle.None;
            reports.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(reports);
            panelDesktop.Tag = reports;
            reports.BringToFront();
            reports.Show();
            label1.Text = reports.Text;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCloseW_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)           
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries() { TopLevel = false, TopMost = true };
            

            ActivateBtn(sender);
            if (activeForm != null)
                activeForm.Close();
            activeForm = queries;
            panelDesktop.Controls.Add(queries);
            queries.FormBorderStyle = FormBorderStyle.None;
            queries.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(queries);
            panelDesktop.Tag = queries;
            queries.BringToFront();
            queries.Show();
            label1.Text = queries.Text;
        }
    }
}
