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
    public partial class basket : Form
    {
        public basket()
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

        private void deleter()
        {
            try
            {
                string Key = basket_tbl.SelectedRows[0].Cells[0].Value.ToString();
                key_txt.Text = Key;
            }catch(Exception ex)
            {
                MessageBox.Show("An error occured, please try again");
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"Delete from basket where ItemID = {key_txt.Text};", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (System.Exception Ex)
            {
                MessageBox.Show("An error occured");
            };
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

        private void displayer()
        {
            con.Open();
            string query = "Select * from basket;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable baskettbl = new DataTable();
            adapter.Fill(baskettbl);
            basket_tbl.DataSource = baskettbl;
            con.Close();
            
        }

        private void display_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleter();
            this.basketTableAdapter1.Fill(this.russoDBDataSet1.Basket);
            total_items.Text = $"Total items: {(basket_tbl.Rows.Count).ToString()}";
            string items = (basket_tbl.Rows.Count).ToString();
            label1.Text = items;
            cost_displayer();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from basket;", con);
            cmd.ExecuteNonQuery();
            con.Close();
            reseeder();
            this.basketTableAdapter1.Fill(this.russoDBDataSet1.Basket);
            total_items.Text = $"Total items: {(basket_tbl.Rows.Count).ToString()}";
            string items = (basket_tbl.Rows.Count).ToString();
            label1.Text = items;
            cost_displayer();
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            hint.Visible = true;
        }

        private void cost_displayer()
        {
            decimal total = 0;
            int discount = 0;
            double multiplier = 1;
            for (int i = 0; i < basket_tbl.Rows.Count; ++i)
            {
                total += Convert.ToDecimal(basket_tbl.Rows[i].Cells[3].Value);

            }
            total = Math.Round(total, 2);
            cost.Text = $"Sub total: £{total.ToString()}";
            if (total > 50)
            {
                discount = 10;
                multiplier = 0.9;
            }

            if (total > 100)
            {
                discount = 20;
                multiplier = 0.8;

            }

            discount_txt.Text = $"Discount: {discount.ToString()} %";
            decimal final = (decimal)multiplier * total;
            final = Math.Round(final, 2);
            final_txt.Text = $"Final price: £{final.ToString()}";
            final1.Text = final.ToString() ;
            string discount1 = (discount.ToString() + "%") ;
            discount_lbl.Text = discount1.ToString();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            string price = final1.Text;
            string no_item = label1.Text;
            string discounts = discount_lbl.Text;
            if (price == "0" && no_item == "0" && discounts == "0%")
            {
                MessageBox.Show("Please order something before paying!");
                return;
            }
            payment gamewindow = new payment(price, no_item, discounts);
            gamewindow.Show();
            this.Hide();
        }

        private void basket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'russoDBDataSet1.Basket' table. You can move, or remove it, as needed.
            this.basketTableAdapter1.Fill(this.russoDBDataSet1.Basket);
            // TODO: This line of code loads data into the 'russoDBDataSet.Basket' table. You can move, or remove it, as needed.
            

            total_items.Text = $"Total items: {(basket_tbl.Rows.Count).ToString()}";
            string items = (basket_tbl.Rows.Count).ToString();
            label1.Text = items;
            cost_displayer();
            con.Open();
            con.Close();

        }
    }
}
