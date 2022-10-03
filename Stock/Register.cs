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
using System.Xml.Linq;

namespace Stock
{
    public partial class Register : Form
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
        public Register()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" )
                {
                    MessageBox.Show("Please Enter Username And Password");

                }
                else
                {
                    string username = txtUsername.Text;
                    var password = txtPassword.Text;

                    connection.Open();
                    query = "insert into user(username,password) values(@username,@password)";
                    command = new MySqlCommand(query, connection);

                   
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
            
                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Register success");
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Register Unsuccess");
                    }
                    connection.Close();
                    
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
