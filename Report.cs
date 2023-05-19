using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP6VPIQ\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True ");

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select * from Book where quantity<=10", con);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
           
            da.SelectCommand = new SqlCommand("Select * from Book where quantity>=50", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
