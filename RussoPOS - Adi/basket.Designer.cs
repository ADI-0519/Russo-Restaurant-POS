namespace RussoPOS___Adi
{
    partial class basket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basket));
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basket_tbl = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.russoDBDataSet1 = new RussoPOS___Adi.RussoDBDataSet1();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.russoDBDataSet = new RussoPOS___Adi.RussoDBDataSet();
            this.delete = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cost = new System.Windows.Forms.Label();
            this.discount_txt = new System.Windows.Forms.Label();
            this.final_txt = new System.Windows.Forms.Label();
            this.total_items = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.hint = new System.Windows.Forms.Label();
            this.basketTableAdapter = new RussoPOS___Adi.RussoDBDataSetTableAdapters.BasketTableAdapter();
            this.basketTableAdapter1 = new RussoPOS___Adi.RussoDBDataSet1TableAdapters.BasketTableAdapter();
            this.final1 = new System.Windows.Forms.Label();
            this.discount_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.key_txt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.russoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.russoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.orders);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Location = new System.Drawing.Point(957, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 70);
            this.panel2.TabIndex = 10;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.Tomato;
            this.home.Location = new System.Drawing.Point(3, 8);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(117, 48);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orders.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.ForeColor = System.Drawing.Color.Tomato;
            this.orders.Location = new System.Drawing.Point(264, 8);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(127, 48);
            this.orders.TabIndex = 2;
            this.orders.Text = "Orders";
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(126, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "Basket";
            this.label4.Click += new System.EventHandler(this.basket_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Tomato;
            this.exit.Location = new System.Drawing.Point(397, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(945, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 96);
            this.panel1.TabIndex = 9;
            // 
            // basket_tbl
            // 
            this.basket_tbl.AllowUserToAddRows = false;
            this.basket_tbl.AllowUserToDeleteRows = false;
            this.basket_tbl.AllowUserToResizeColumns = false;
            this.basket_tbl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.basket_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.basket_tbl.AutoGenerateColumns = false;
            this.basket_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basket_tbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.basket_tbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.basket_tbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basket_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basket_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.basket_tbl.ColumnHeadersHeight = 34;
            this.basket_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.basket_tbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.foodIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.basket_tbl.DataSource = this.basketBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basket_tbl.DefaultCellStyle = dataGridViewCellStyle3;
            this.basket_tbl.EnableHeadersVisualStyles = false;
            this.basket_tbl.GridColor = System.Drawing.Color.White;
            this.basket_tbl.Location = new System.Drawing.Point(525, 125);
            this.basket_tbl.Name = "basket_tbl";
            this.basket_tbl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basket_tbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.basket_tbl.RowHeadersWidth = 59;
            this.basket_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.basket_tbl.RowTemplate.Height = 28;
            this.basket_tbl.Size = new System.Drawing.Size(541, 421);
            this.basket_tbl.TabIndex = 13;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // foodIDDataGridViewTextBoxColumn
            // 
            this.foodIDDataGridViewTextBoxColumn.DataPropertyName = "FoodID";
            this.foodIDDataGridViewTextBoxColumn.HeaderText = "FoodID";
            this.foodIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.foodIDDataGridViewTextBoxColumn.Name = "foodIDDataGridViewTextBoxColumn";
            this.foodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basketBindingSource1
            // 
            this.basketBindingSource1.DataMember = "Basket";
            this.basketBindingSource1.DataSource = this.russoDBDataSet1;
            // 
            // russoDBDataSet1
            // 
            this.russoDBDataSet1.DataSetName = "RussoDBDataSet1";
            this.russoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataMember = "Basket";
            this.basketBindingSource.DataSource = this.russoDBDataSet;
            // 
            // russoDBDataSet
            // 
            this.russoDBDataSet.DataSetName = "RussoDBDataSet";
            this.russoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Tomato;
            this.delete.Location = new System.Drawing.Point(1258, 176);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 48);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.Location = new System.Drawing.Point(1248, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 76);
            this.panel5.TabIndex = 15;
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Tomato;
            this.clear.Location = new System.Drawing.Point(1258, 298);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(119, 48);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Tomato;
            this.panel6.Location = new System.Drawing.Point(1248, 283);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(139, 76);
            this.panel6.TabIndex = 17;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cost.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.ForeColor = System.Drawing.Color.Tomato;
            this.cost.Location = new System.Drawing.Point(561, 653);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(191, 48);
            this.cost.TabIndex = 18;
            this.cost.Text = "Total cost:";
            // 
            // discount_txt
            // 
            this.discount_txt.AutoSize = true;
            this.discount_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discount_txt.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_txt.ForeColor = System.Drawing.Color.Tomato;
            this.discount_txt.Location = new System.Drawing.Point(561, 721);
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(187, 48);
            this.discount_txt.TabIndex = 19;
            this.discount_txt.Text = "Discounts:";
            // 
            // final_txt
            // 
            this.final_txt.AutoSize = true;
            this.final_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.final_txt.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_txt.ForeColor = System.Drawing.Color.Tomato;
            this.final_txt.Location = new System.Drawing.Point(561, 787);
            this.final_txt.Name = "final_txt";
            this.final_txt.Size = new System.Drawing.Size(198, 48);
            this.final_txt.TabIndex = 20;
            this.final_txt.Text = "Total price";
            // 
            // total_items
            // 
            this.total_items.AutoSize = true;
            this.total_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.total_items.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_items.ForeColor = System.Drawing.Color.Tomato;
            this.total_items.Location = new System.Drawing.Point(561, 580);
            this.total_items.Name = "total_items";
            this.total_items.Size = new System.Drawing.Size(212, 48);
            this.total_items.TabIndex = 21;
            this.total_items.Text = "Total items:";
            // 
            // pay_btn
            // 
            this.pay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay_btn.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.Tomato;
            this.pay_btn.Location = new System.Drawing.Point(1222, 427);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(190, 48);
            this.pay_btn.TabIndex = 22;
            this.pay_btn.Text = "Pay Now";
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Tomato;
            this.panel7.Location = new System.Drawing.Point(1212, 412);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 76);
            this.panel7.TabIndex = 23;
            // 
            // hint
            // 
            this.hint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hint.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.ForeColor = System.Drawing.Color.Tomato;
            this.hint.Location = new System.Drawing.Point(34, 275);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(485, 195);
            this.hint.TabIndex = 24;
            this.hint.Text = "To delete a row, simply select the black box next to that row and click delete";
            this.hint.Visible = false;
            // 
            // basketTableAdapter
            // 
            this.basketTableAdapter.ClearBeforeFill = true;
            // 
            // basketTableAdapter1
            // 
            this.basketTableAdapter1.ClearBeforeFill = true;
            // 
            // final1
            // 
            this.final1.AutoSize = true;
            this.final1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.final1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final1.ForeColor = System.Drawing.Color.Tomato;
            this.final1.Location = new System.Drawing.Point(989, 773);
            this.final1.Name = "final1";
            this.final1.Size = new System.Drawing.Size(198, 48);
            this.final1.TabIndex = 25;
            this.final1.Text = "Total price";
            this.final1.Visible = false;
            // 
            // discount_lbl
            // 
            this.discount_lbl.AutoSize = true;
            this.discount_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discount_lbl.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_lbl.ForeColor = System.Drawing.Color.Tomato;
            this.discount_lbl.Location = new System.Drawing.Point(989, 721);
            this.discount_lbl.Name = "discount_lbl";
            this.discount_lbl.Size = new System.Drawing.Size(198, 48);
            this.discount_lbl.TabIndex = 26;
            this.discount_lbl.Text = "Total price";
            this.discount_lbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(1226, 721);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 48);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total price";
            this.label1.Visible = false;
            // 
            // key_txt
            // 
            this.key_txt.AutoSize = true;
            this.key_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_txt.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_txt.ForeColor = System.Drawing.Color.Tomato;
            this.key_txt.Location = new System.Drawing.Point(554, 38);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(198, 48);
            this.key_txt.TabIndex = 28;
            this.key_txt.Text = "Total price";
            this.key_txt.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 721);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 48);
            this.label3.TabIndex = 32;
            this.label3.Text = "Version 1.20";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 135);
            this.label2.TabIndex = 30;
            this.label2.Text = "Russo Italian Restaurant";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 166);
            this.panel3.TabIndex = 31;
            // 
            // basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.key_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discount_lbl);
            this.Controls.Add(this.final1);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.total_items);
            this.Controls.Add(this.final_txt);
            this.Controls.Add(this.discount_txt);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.basket_tbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "basket";
            this.Load += new System.EventHandler(this.basket_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.russoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.russoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView basket_tbl;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label discount_txt;
        private System.Windows.Forms.Label final_txt;
        private System.Windows.Forms.Label total_items;
        private System.Windows.Forms.Label pay_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label hint;
        private RussoDBDataSet russoDBDataSet;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private RussoDBDataSetTableAdapters.BasketTableAdapter basketTableAdapter;
        private RussoDBDataSet1 russoDBDataSet1;
        private System.Windows.Forms.BindingSource basketBindingSource1;
        private RussoDBDataSet1TableAdapters.BasketTableAdapter basketTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label final1;
        private System.Windows.Forms.Label discount_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label key_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}