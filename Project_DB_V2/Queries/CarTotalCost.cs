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
    public partial class CarTotalCost : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public CarTotalCost()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select Cars.Car_ID,SUM(Services.Cost) AS Total_Cost from Cars JOIN CarsServicesCostRecords ON Cars.Car_ID = CarsServicesCostRecords.Car_ID JOIN services ON CarsServicesCostRecords.Service_ID = " +
              "Services.Service_ID GROUP BY Cars.Car_ID ;", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CarTotalCost_Load(object sender, EventArgs e)
        {

        }
    }
}
