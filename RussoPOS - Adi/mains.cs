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
    public partial class mains : Form
    {
        public mains()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adirj\OneDrive\Documents\RussoDB.mdf;Integrated Security=True;Connect Timeout=30");
        int count1 = 11;
        int count2 = 11;
        int count3 = 11;
        int count4 = 11;
        int count5 = 11;
        int count6 = 11;
        int count7 = 11;
        int count8 = 11;
        int count9 = 11;



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
            SqlCommand cmd = new SqlCommand($"insert into Basket (FoodID, name, cost) select Food.FoodID, Food.name, Food.cost from Food where Food.FoodID = {foodid};", con);
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

        private void spaghetti_Click(object sender, EventArgs e)    
        {
            count1 -= 1;
            if (count1 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("8");
                Decrementer("8");
            }
        }
        private void chknpasta_Click(object sender, EventArgs e)
        {
            count2 -= 1;
            if (count2 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("9");
                Decrementer("9");
            }
        }

        private void steak_Click(object sender, EventArgs e)
        {
            count3 -= 1;
            if (count3 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("10");
                Decrementer("10");
            }
        }

        private void lasagne_Click(object sender, EventArgs e)
        {
            count4 -= 1;
            if (count4 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("11");
                Decrementer("11");
            }
        }

        private void cacciatore_Click(object sender, EventArgs e)
        {
            count5 -= 1;
            if (count5 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("12");
                Decrementer("12");
            }
        }

        private void meatpizza_Click(object sender, EventArgs e)
        {
            count6 -= 1;
            if (count6 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("13");
                Decrementer("13");
            }
        }

        private void cheesepizza_Click(object sender, EventArgs e)
        {
            count7 -= 1;
            if (count7 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("14");
                Decrementer("14");
            }
        }

        private void specialpizza_Click(object sender, EventArgs e)
        {
            count8 -= 1;
            if (count8 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("15");
                Decrementer("15");
            }
        }

        private void seafoodpasta_Click(object sender, EventArgs e)
        {
            count9 -= 1;
            if (count9 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("16");
                Decrementer("16");
            }
        }




    }
}
