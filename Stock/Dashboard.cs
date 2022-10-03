using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Dashboard : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;
        private DataTable datatable = new DataTable();


        private string server;
        private string database;
        private string username;
        private string password;
        private string query;


        public Dashboard()
        {
            InitializeComponent();
            server = "localhost";
            database = "stockmanagement";
            username = "root";
            password = "password";
            string connectionString;
            connectionString = "server=" + server + ";" + "database=" +
                               database + ";" + "username=" + username + ";" + "password=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            countCategory();
            countCustomers();
            countSuppliers();
            getMax();
            latestOrder();
            bestCustomer();
        }

        private void countCategory()
        {
            try
            {
                connection.Open();

                query = "select count(*) from category";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblCategories.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        private void countCustomers()
        {
            try
            {
                connection.Open();

                query = "select count(*) from customer";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblCustomers.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        private void countSuppliers()
        {
            try
            {
                connection.Open();

                query = "select count(*) from supplier";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblSuppliers.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }


        private void lblCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void lblStocks_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void getMax()
        {
            try
            {
                connection.Open();

                query = "select Max(Total_Price) from orders";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblMaxOrder.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void latestOrder()
        {
            try
            {
                connection.Open();

                query = "select Max(date) from orders";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblLatestOrder.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        private void bestCustomer()   //// ????????????????????????
        {
            try
            {
                connection.Open();

                query = "select customer.name from customer join orders on customer.id = orders.ORDER_ID where orders.Total_Price=(select max(Total_Price) from orders)";         // Data Adapter  ,Fill ,
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                datatable = new DataTable();

                adapter.Fill(datatable);
                lblBestCustomer.Text = datatable.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }



        }


    }
}
