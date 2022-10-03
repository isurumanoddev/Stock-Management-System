using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Stock
{
    public partial class Orders : Form
    {
        private MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;
        private DataTable datatable = new DataTable();

        private string server;
        private string database;
        private string username;
        private string password;
        private string query;
        int price;
        



        public Orders()
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

        private void lblStocks_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
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

        private void lblOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            getCategories();
            getProducts();
            uploadData();
            
        }
        private void getCategories()   //// ????????????????????????
        {
            try
            {

                connection.Open();
                query = "select name from customer";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cmbCustomer.Items.Add(dataReader.GetString(i));

                    }
                }

                dataReader.Close();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }



        }



        private void getProducts()   //// ????????????????????????
        {
            try
            {

                connection.Open();
                query = "select name from stock";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cmbProducts.Items.Add(dataReader.GetString(i));

                    }
                }

                dataReader.Close();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        private void getPrice()   //// ????????????????????????
        {
            try
            {
                var productName = cmbProducts.Text;

                connection.Open();
                query = "select * from stock where name =@name";
                
               // dataReader= command.ExecuteNonQuery();
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", productName);
                dataReader = command.ExecuteReader();
                bool isExist = dataReader.Read();
                if (isExist)
                {
                    var availableQuantity = dataReader[3].ToString();
                    price = Convert.ToInt32(dataReader[5].ToString());
                    txtPrice.Text = "Unit Price - LKR "+price+".00";
                    txtAvailable.Text = "Available - "+availableQuantity+" units";
                }


                dataReader.Close();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }



        }

        int GrandTotal = 0;
        int TotalQuantity = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text =="" && txtQuantity.Text == "" )
                {
                    MessageBox.Show("Please Select A Product");
                }
                else
                {
                    
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                   Double total= price * quantity;


                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2);

                    row.Cells[0].Value = cmbProducts.Text;
                    row.Cells[1].Value =price;
                    row.Cells[2].Value =quantity;
                    row.Cells[3].Value =total;
                    dataGridView2.Rows.Add(row);
                    GrandTotal = (int)(GrandTotal + total);
                    lblTotal.Text ="LKR "+ GrandTotal;
                    TotalQuantity = TotalQuantity + quantity;

                    uploadData();

                    
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);

            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            uploadData();
            try
            {
                if (cmbCustomer.Text == "" ||txtDate.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data");

                }
                else
                {
                    
                    string total = GrandTotal.ToString();
                    string name = cmbCustomer.Text;
                    string quantity = TotalQuantity.ToString();


                    connection.Open();
                    query = "insert into orders(Customer_Name,Total_Quantity,Total_Price) values(@Customer_Name,@Total_Quantity,@Total_Price)";
                    command = new MySqlCommand(query, connection);

                   
                    command.Parameters.AddWithValue("@Customer_Name", name);
                    command.Parameters.AddWithValue("@Total_Quantity", quantity);
                    command.Parameters.AddWithValue("@Total_Price", total);
                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("success");



                    }
                    else
                    {
                        MessageBox.Show("Unsuccess");
                    }
                    connection.Close();
                    
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void uploadData()
        {
            try
            {
                connection.Open();
                query = "select * from orders";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                datatable.Load(dataReader);
                dataReader.Close();
                connection.Close();
                dataGridView1.DataSource = datatable;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
    }
}
