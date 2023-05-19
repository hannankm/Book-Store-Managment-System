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

    
    public partial class UserControl2 : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP6VPIQ\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True ");

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select qty from Book where bid='" + textBox7.Text + "'", con);
            int qty = Convert.ToInt32(numericUpDown2.Value);
            SqlCommand cmd = new SqlCommand("update Book set title = "+"' ,quantity = '-=numericUpDown2.Value ' where bid='" + textBox7.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
