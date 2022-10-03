namespace Stock
{
    partial class Dashboard
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStocks = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLatestOrder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMaxOrder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblBestCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label17.Location = new System.Drawing.Point(56, 89);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(438, 68);
            this.label17.TabIndex = 81;
            this.label17.Text = "Flower Stock Management System";
            // 
            // lblSupplier
            // 
            this.lblSupplier.BackColor = System.Drawing.Color.Gold;
            this.lblSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupplier.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupplier.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSupplier.Location = new System.Drawing.Point(415, 7);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(149, 56);
            this.lblSupplier.TabIndex = 26;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Gold;
            this.lblCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCustomer.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCustomer.Location = new System.Drawing.Point(257, 9);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(149, 56);
            this.lblCustomer.TabIndex = 25;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblStocks
            // 
            this.lblStocks.BackColor = System.Drawing.Color.Gold;
            this.lblStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStocks.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStocks.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStocks.Location = new System.Drawing.Point(5, 7);
            this.lblStocks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(115, 56);
            this.lblStocks.TabIndex = 19;
            this.lblStocks.Text = "Stocks";
            this.lblStocks.Click += new System.EventHandler(this.lblStocks_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.BackColor = System.Drawing.Color.Gold;
            this.lblOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrders.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrders.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOrders.Location = new System.Drawing.Point(573, 7);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(115, 56);
            this.lblOrders.TabIndex = 23;
            this.lblOrders.Text = "Orders";
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Gold;
            this.lblCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategory.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCategory.Location = new System.Drawing.Point(129, 7);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(133, 56);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.Gold;
            this.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDashboard.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDashboard.Location = new System.Drawing.Point(679, 7);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(167, 56);
            this.lblDashboard.TabIndex = 24;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(1, -11);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 117);
            this.label2.TabIndex = 69;
            this.label2.Text = "Black Lotus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.lblSupplier);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.lblDashboard);
            this.panel2.Controls.Add(this.lblOrders);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblStocks);
            this.panel2.Location = new System.Drawing.Point(464, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 71);
            this.panel2.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 187);
            this.panel1.TabIndex = 82;
            // 
            // lblCategories
            // 
            this.lblCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategories.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.ForeColor = System.Drawing.Color.Gold;
            this.lblCategories.Location = new System.Drawing.Point(84, 50);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(223, 106);
            this.lblCategories.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(84, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 63);
            this.label1.TabIndex = 87;
            this.label1.Text = "Catagories";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblSuppliers);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(490, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 187);
            this.panel3.TabIndex = 83;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSuppliers.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuppliers.ForeColor = System.Drawing.Color.Gold;
            this.lblSuppliers.Location = new System.Drawing.Point(69, 50);
            this.lblSuppliers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(223, 106);
            this.lblSuppliers.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(85, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 63);
            this.label3.TabIndex = 88;
            this.label3.Text = "Suppliers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblCustomers);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(909, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 187);
            this.panel4.TabIndex = 83;
            // 
            // lblCustomers
            // 
            this.lblCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCustomers.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomers.ForeColor = System.Drawing.Color.Gold;
            this.lblCustomers.Location = new System.Drawing.Point(66, 50);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(223, 106);
            this.lblCustomers.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(95, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 63);
            this.label4.TabIndex = 89;
            this.label4.Text = "Customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lblLatestOrder);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(909, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 107);
            this.panel5.TabIndex = 86;
            // 
            // lblLatestOrder
            // 
            this.lblLatestOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLatestOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLatestOrder.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLatestOrder.ForeColor = System.Drawing.Color.Gold;
            this.lblLatestOrder.Location = new System.Drawing.Point(26, 34);
            this.lblLatestOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLatestOrder.Name = "lblLatestOrder";
            this.lblLatestOrder.Size = new System.Drawing.Size(303, 58);
            this.lblLatestOrder.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(111, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 39);
            this.label7.TabIndex = 90;
            this.label7.Text = "Latest Order";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.lblMaxOrder);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(490, 418);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 103);
            this.panel6.TabIndex = 85;
            // 
            // lblMaxOrder
            // 
            this.lblMaxOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaxOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaxOrder.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxOrder.ForeColor = System.Drawing.Color.Gold;
            this.lblMaxOrder.Location = new System.Drawing.Point(57, 32);
            this.lblMaxOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaxOrder.Name = "lblMaxOrder";
            this.lblMaxOrder.Size = new System.Drawing.Size(285, 60);
            this.lblMaxOrder.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(79, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 39);
            this.label6.TabIndex = 89;
            this.label6.Text = "Maximum Order";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.lblBestCustomer);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(72, 418);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(364, 103);
            this.panel7.TabIndex = 84;
            // 
            // lblBestCustomer
            // 
            this.lblBestCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBestCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBestCustomer.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestCustomer.ForeColor = System.Drawing.Color.Gold;
            this.lblBestCustomer.Location = new System.Drawing.Point(41, 32);
            this.lblBestCustomer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBestCustomer.Name = "lblBestCustomer";
            this.lblBestCustomer.Size = new System.Drawing.Size(289, 60);
            this.lblBestCustomer.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(84, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 39);
            this.label5.TabIndex = 88;
            this.label5.Text = "Best Customer";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1339, 835);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label17;
        private Label lblSupplier;
        private Label lblCustomer;
        private Label lblStocks;
        private Label lblOrders;
        private Label lblCategory;
        private Label lblDashboard;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Label lblCategories;
        private Label label1;
        private Panel panel3;
        private Label lblSuppliers;
        private Label label3;
        private Panel panel4;
        private Label lblCustomers;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblLatestOrder;
        private Label label7;
        private Label lblMaxOrder;
        private Label label6;
        private Label lblBestCustomer;
        private Label label5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}