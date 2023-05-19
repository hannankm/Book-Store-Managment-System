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
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP6VPIQ\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True ");

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            
            da.InsertCommand = new SqlCommand("insert into Book Values (@bid, @title, @author, @category, @quantity, @price) ", con);
            da.InsertCommand.Parameters.Add("@bid", SqlDbType.VarChar).Value =textBox6.Text;
            da.InsertCommand.Parameters.Add("@title", SqlDbType.VarChar).Value =textBox7.Text;
            da.InsertCommand.Parameters.Add("@author", SqlDbType.VarChar).Value = textBox8.Text;
            da.InsertCommand.Parameters.Add("@category", SqlDbType.VarChar).Value = comboBox2.SelectedItem.ToString();
            da.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = numericUpDown2.Value;
            da.InsertCommand.Parameters.Add("@price", SqlDbType.Money).Value = textBox5.Text;
            da.InsertCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Date inserted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text= "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            numericUpDown2.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select * from Book", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            
        }

        //display
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select * from Book where bid='"+textBox1.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select * from Book where bid='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();

            DialogResult d = MessageBox.Show("Do you want to delete?", "Confirmation",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Book where bid ='" +
                textBox2.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book deleted successfully");
            }
            
        }
        //search
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            da.SelectCommand = new SqlCommand("Select * from Book where bid='" + textBox4.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
            
        }

        //update
        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Book set title = '" + textBox9.Text
            + "' ,author = '" + textBox10.Text + "' ,quantity = '" + numericUpDown1.Value + "' ,category = '" + comboBox1.SelectedItem.ToString() + "' ,PRICE = '" + textBox3.Text + " ' where bid='" + textBox4.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book updated successfully");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
