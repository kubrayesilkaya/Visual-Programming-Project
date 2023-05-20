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

namespace MidtermProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnToPassSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btnClearLogin_Click(object sender, EventArgs e)
        {
            txtFactoryEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtFactoryEmail.Text;
            string password = txtPassword.Text;
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";
            string query = "SELECT FACTORY_TYPE_ID FROM FACTORIES WHERE FACTORY_E_MAIL=@Email AND PASSWORD=@Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    CurrentUser.Email = email;
                    CurrentUser.Password = password;
                    CurrentUser.FactoryTypeId = (int)result;

                    int factoryTypeId = (int)result;
                    if (factoryTypeId == 1 && radioBtnProducer.Checked)
                    {
                        ProducerFactory producerFactoryForm = new ProducerFactory();
                        producerFactoryForm.Show();
                        this.Hide();
                    }
                    else if (factoryTypeId == 2 && radioBtnConsumer.Checked)
                    {
                        ConsumerFactory consumerFactoryForm = new ConsumerFactory();
                        consumerFactoryForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select the appropriate factory type.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
        }

        private void btnToPassWarehousesLogin_Click(object sender, EventArgs e)
        {
            WarehousesLoginPage warehousesLoginPage = new WarehousesLoginPage();
            warehousesLoginPage.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHelp viewHelp = new ViewHelp();
            viewHelp.ShowDialog();
        }

        private void tipsAndTricksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipsAndTricks tipsAndTricks = new TipsAndTricks();
            tipsAndTricks.ShowDialog();
        }
    }
}