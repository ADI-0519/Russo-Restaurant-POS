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
using System.Drawing.Printing;

namespace RussoPOS___Adi
{
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

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

        private void starters_img_Click(object sender, EventArgs e)
        {
            starters gamewindow = new starters();
            gamewindow.Show();
            this.Hide();

        }

        private void mains_img_Click(object sender, EventArgs e)
        {
            mains gamewindow = new mains();
            gamewindow.Show();
            this.Hide();

        }

        private void desserts_img_Click(object sender, EventArgs e)
        {
            desserts gamewindow = new desserts();
            gamewindow.Show();
            this.Hide();

        }

        private void drinks_img_Click(object sender, EventArgs e)
        {
            drinks gamewindow = new drinks();
            gamewindow.Show();
            this.Hide();

        }

        private void home_Click(object sender, EventArgs e)
        {

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
    }
}
