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
using System.Xml.Linq;

namespace RussoPOS___Adi
{
    public partial class payment : Form
    {
        

        public payment()
        {
            InitializeComponent();
        }
        public payment(string value, string value2, string value3)
        {
            InitializeComponent();
            string value1 = value;
            label5.Text = value1;
            label6.Text = value2;
            label7.Text = value3;
        }


        public string Value { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adirj\OneDrive\Documents\RussoDB.mdf;Integrated Security=True;Connect Timeout=30");



        private void Reset(string dbname)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete from {dbname}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void reseeder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbcc checkident('Basket', RESEED, 0)", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            mainscreen gamewindow = new mainscreen();
            gamewindow.Show();
            this.Hide();
        }

        private void basket_Click(object sender, EventArgs e)
        {
            basket gamewindow = new basket();
            gamewindow.Show();
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Reset("Basket");
            reseeder();
            Application.Exit();

        }

        private void orders_Click(object sender, EventArgs e)
        {
            orders gamewindow = new orders();
            gamewindow.Show();
            this.Hide();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            string custname = name.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand($"Insert into customer(name) values('{custname}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            string price = label5.Text;
            string no_item = label6.Text;
            string discounts = label7.Text;
            if (custname == "")
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            payment2 gamewindow = new payment2(price, no_item, discounts, custname);
            gamewindow.Show();
            this.Hide();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }
    }
}
