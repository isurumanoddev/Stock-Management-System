using MySql.Data.MySqlClient;
using System;
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
    public partial class Supplier : Form
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





        public Supplier()
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
                query = "select * from supplier";
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

        private void Supplier_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtNumber.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Missing Details ");

                }
                else
                {
                    int id = int.Parse(txtId.Text);
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string email = txtEmail.Text;
                    string number = txtNumber.Text;

                    connection.Open();
                    query = "insert into supplier values(@id,@name,@address,@email,@number)";
                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@number", number);

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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string number = txtNumber.Text;

                connection.Open();
                query = "update supplier set name=@name,address=@address,email=@email,number=@number where id=@id)";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@id", id);

                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Update success");

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
                query = "delete from supplier where id=@id";
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
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtNumber.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();
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
    }
}
