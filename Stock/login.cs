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
    public partial class login : Form
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
        public login()
        {
            InitializeComponent();
            server = "localhost";
            database = "stockmanagement";
            username = "root";
            password = "password";
            string connectionString;
            connectionString = "server=" + server + ";" +
                               "database=" + database + ";" +
                               "username=" + username + ";" +
                               "password=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                var password = txtPassword.Text;

                connection.Open();
                
                query = "SELECT * FROM user WHERE username=@username AND password=@password";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                
                dataReader = command.ExecuteReader();
                bool isExist = dataReader.Read();
                if (isExist)
                {
                    MessageBox.Show("Login Success");
                    Stock stock = new Stock();
                    stock.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Unuccess");
                }


               
                connection.Close();


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}