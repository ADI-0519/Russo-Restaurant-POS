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
    public partial class drinks : Form
    {
        public drinks()
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
        int count10 = 11;
        int count11 = 11;
        int count12 = 11;

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

        private void dietcoke_Click(object sender, EventArgs e)
        {
            count1 -= 1;
            if (count1 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("23");
                Decrementer("23");
            }
        }

        private void coke_Click(object sender, EventArgs e)
        {
            count2 -= 1;
            if (count2 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("24");
                Decrementer("24");
            }
        }

        private void lemonade_Click(object sender, EventArgs e)
        {
            count3 -= 1;
            if (count3 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("25");
                Decrementer("25");
            }
        }

        private void SWwine_Click(object sender, EventArgs e)
        {
            count4 -= 1;
            if (count4 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("26");
                Decrementer("26");
            }
        }

        private void LWwine_Click(object sender, EventArgs e)
        {
            count5 -= 1;
            if (count5 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("27");
                Decrementer("27");
            }
        }

        private void BWwine_Click(object sender, EventArgs e)
        {
            count6 -= 1;
            if (count6 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("28");
                Decrementer("28");
            }
        }

        private void SRwine_Click(object sender, EventArgs e)
        {
            count7 -= 1;
            if (count7 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("29");
                Decrementer("29");
            }
        }

        private void LRwine_Click(object sender, EventArgs e)
        {
            count8 -= 1;
            if (count8 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("30");
                Decrementer("30");
            }
        }

        private void BRwine_Click(object sender, EventArgs e)
        {
            count9 -= 1;
            if (count9 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("31");
                Decrementer("31");
            }
        }

        private void BRbottle_Click(object sender, EventArgs e)
        {
            count10 -= 1;
            if (count10 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("32");
                Decrementer("32");
            }
        }

        private void Brlarge_Click(object sender, EventArgs e)
        {
            count11 -= 1;
            if (count11 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("33");
                Decrementer("33");
            }
        }

        private void peroni_Click(object sender, EventArgs e)
        {
            count12 -= 1;
            if (count12 < 1)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                Adder("34");
                Decrementer("34");
            }
        }
    }
}
