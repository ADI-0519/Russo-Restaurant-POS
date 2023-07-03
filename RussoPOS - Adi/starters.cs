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

namespace RussoPOS___Adi
{
    public partial class starters : Form
    {
        public starters()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adirj\OneDrive\Documents\RussoDb.mdf;Integrated Security=True;Connect Timeout=30");
        int count1 = 11;
        int count2 = 11;
        int count3 = 11;
        int count4 = 11;
        int count5 = 11;
        int count6 = 11;
        int count7 = 11;

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
        private void Decrementer(string foodid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"update Food set quantity = quantity - 1 where foodID = {foodid}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Adder(string foodid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into basket (FoodID, name, cost) select Food.FoodID, Food.name, Food.cost from Food where Food.FoodID = {foodid};", con);
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


        private void Bread_Click(object sender, EventArgs e)
        {
            count1 -= 1;
            if (count1 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("1");
                Decrementer("1");
            }


        }

        private void mussels_Click(object sender, EventArgs e)
        {
            count2 -= 1;
            if (count2 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("2");
                Decrementer("2");
            }

        }

        private void bruschetta_Click(object sender, EventArgs e)
        {
            count3 -= 1;
            if (count3 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("3");
                Decrementer("3");
            }
        }

        private void antipasti_Click(object sender, EventArgs e)
        {
            count4 -= 1;
            if (count4 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("4");
                Decrementer("4");
            }
        }

        private void olives_Click(object sender, EventArgs e)
        {
            count5 -= 1;
            if (count5 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("5");
                Decrementer("5");
            }
        }

        private void aracini_Click(object sender, EventArgs e)
        {
            count6 -= 1;
            if (count6 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("6");
                Decrementer("6");
            }
        }

        private void soup_Click(object sender, EventArgs e)
        {
            count7 -= 1;
            if (count7 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("7");
                Decrementer("7");
            }
        }

    }
}
