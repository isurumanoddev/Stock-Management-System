using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stock
{
    public partial class Stock : Form
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

        public Stock()
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
      
        public void uploadData()
        {
            try
            {
                connection.Open();
                query = "select * from stock";
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
        private void Stock_Load(object sender, EventArgs e)
        {
            uploadData();
            getCategories();
            getSuppliers();
        }

        private void getCategories()   //// ????????????????????????
        {

            try
            {

                connection.Open();
                query = "select name from category";
                command=new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cmbCategory.Items.Add(dataReader.GetString(i));

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
        private void getSuppliers()   //// ????????????????????????
        {

            try
            {

                connection.Open();
                query = "select name from supplier";
                command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cmbSupplier.Items.Add(dataReader.GetString(i));

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



        private void btnSave(object sender, EventArgs e)
        {
            
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtQuantity.Text == "" || txtBprice.Text == "" || txtSPrice.Text == "" || txtDate.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data");

                }
                else
                {
                    int id = int.Parse(txtId.Text);
                    string name = txtName.Text;
                    string category = cmbCategory.Text;
                    int quantity = int.Parse(txtQuantity.Text);
                    int bprice = int.Parse(txtBprice.Text);
                    int sprice = int.Parse(txtSPrice.Text);
                    string date = txtDate.Text;
                    string supplier = cmbSupplier.Text;

                    connection.Open();
                    query = "insert into stock values(@id,@name,@category,@quantity,@Bprice,@Sprice,@date,@supplier)";
                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id",id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@Bprice", bprice);
                    command.Parameters.AddWithValue("@Sprice", sprice);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@supplier", supplier);
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
                    uploadData();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btnEdit(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string category = cmbCategory.Text;
                int quantity = int.Parse(txtQuantity.Text);
                int bprice = int.Parse(txtBprice.Text);
                int sprice = int.Parse(txtSPrice.Text);
                string date = txtDate.Text;
                string supplier = cmbSupplier.Text;
            
                connection.Open();
                query = "update stock set name=@name,category=@category,quantity=@quantity,Bprice=@Bprice,Sprice=@Sprice,date=@date,supplier=@supplier where id=@id ";
                command = new MySqlCommand(query, connection);
            
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@Bprice", bprice);
                command.Parameters.AddWithValue("@Sprice", sprice);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@supplier", supplier);
                command.Parameters.AddWithValue("@id", id);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Update Success");
                }
                else
                {
                    MessageBox.Show("Update Unsuccess");
                }
                connection.Close();
                uploadData();
            }
            catch (Exception exception)
            {
            
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);

                connection.Open();
                query = "delete from stock where id=@id";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                var i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("delete Success");

                }
                else
                {
                    MessageBox.Show("delete Unsuccess");
                }

                connection.Close();
                uploadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cmbCategory.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtBprice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtSPrice.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtDate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                cmbSupplier.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

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
    }
}
