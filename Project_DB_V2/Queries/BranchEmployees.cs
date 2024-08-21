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
    public partial class BranchEmployees : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MEABQQJG;Initial Catalog=Car_Maintainence;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public BranchEmployees()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select count(*) from Cars Where Manufacture ='BMW' ;" , conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BranchEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
