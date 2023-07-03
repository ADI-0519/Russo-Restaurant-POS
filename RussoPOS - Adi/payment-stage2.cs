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

namespace RussoPOS___Adi
{
    public partial class payment2 : Form
    {


        public payment2()
        {
            InitializeComponent();
            
        }

        public payment2(string value, string value1, string value3, string value4)
        {
            InitializeComponent();
            string price = value;
            cost.Text = $"{price}";
            string items = value1;
            items_txt.Text = items;
            string discounts = value3;
            discount_txt.Text = discounts;
            string name = value4;
            name_txt.Text = name;

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adirj\OneDrive\Documents\RussoDB.mdf;Integrated Security=True;Connect Timeout=30");
        public string value { get;set; }

        private void payment2_Load(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(cost.Text);
            cost1.Text = price.ToString();
        }

        private void orderer()
        {
            con.Open();
            decimal price = Convert.ToDecimal(cost1.Text);
            int items = Convert.ToInt32(items_txt.Text);
            string discounts = discount_txt.Text;
            string name = name_txt.Text;
            string Query = $"Insert into Orders(Name, [Number of items], discounts, Cost,[Date and Time] ) values ('{name}',{items},'{discounts}',{price},'{date_txt.Text}')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void getDate()
        {
            DateTime a = DateTime.Now;
            date_txt.Text = a.ToString();
        }

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

        private void change()
        {
            try
            {
                decimal entered = Convert.ToDecimal(amount.Text);
                decimal price = Convert.ToDecimal(cost.Text);
                if (entered > price)
                {
                    decimal extrachange = entered - price;
                    label9.Text = $"Change given: £{extrachange.ToString()}";
                    cost.Text = "0";
                    MessageBox.Show("Order successful");
                    orderer();
                    orders gamewindow = new orders();
                    gamewindow.Show();
                    this.Hide();
                    Reset("Basket");
                    reseeder();

                }

                else if (entered < price)
                {
                    decimal amountdue = price - entered;
                    cost.Text = $"{amountdue}";

                }

                else if (price == entered)
                {
                    label9.Text = $"Change given: £0";
                    cost.Text = "0";
                    MessageBox.Show("Order successful");
                    orderer();
                    orders gamewindow = new orders();
                    gamewindow.Show();
                    this.Hide();
                    Reset("Basket");
                    reseeder();
                }
                else
                {
                    MessageBox.Show("An error occured, try again");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured");
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Reset("Basket");
            reseeder();
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            getDate();
            change();
        }

        private void paid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order successful");
            getDate();
            orderer();
            orders gamewindow = new orders();
            gamewindow.Show();
            this.Hide();
            Reset("Basket");
            reseeder();
        }

        private void discount_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
