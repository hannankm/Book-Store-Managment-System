using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form2 : Form
    {
        //UserControl1 manageBook = new UserControl1();
        public Form2()
        {
            InitializeComponent();
        }
        /*
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        */
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true; //manage sales
            userControl11.Visible = false; //manage books
            report1.Visible = false;
            header.Text = "Manage Sales";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            header.Text = "Manage Books";
            userControl11.Visible = true;
            userControl21.Visible = false;
            report1.Visible = false;


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            header.Text = "Book Store Management System";
            userControl11.Visible = false;
            userControl21.Visible = false;
            report1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            header.Text = "Report";
            userControl11.Visible = false;
            userControl21.Visible = false;
            report1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button6.BackColor = Color.Teal;
            Form1 f1 = new Form1();
            f1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
