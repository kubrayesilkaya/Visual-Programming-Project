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
    public partial class WarehousesLoginPage : Form
    {
        public WarehousesLoginPage()
        {
            InitializeComponent();
        }

        private void btnToClear_Click(object sender, EventArgs e)
        {
            txtWarehouseEmail.Text = string.Empty;
            txtWarehousePassword.Text = string.Empty;
        }

        private void btnToPassSignUpPage_Click(object sender, EventArgs e)
        {
            WarehousesSignUpPage warehousesSignUp = new WarehousesSignUpPage();
            warehousesSignUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string warehouseEmail = txtWarehouseEmail.Text;
            string warehousePassword = txtWarehousePassword.Text;

            string query = "SELECT * FROM WAREHOUSE WHERE WAREHOUSE_E_MAIL = @warehouse_Email AND WAREHOUSE_PASSWORD = @warehouse_Password";
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@warehouse_Email", warehouseEmail);
            command.Parameters.AddWithValue("@warehouse_Password", warehousePassword);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int warehouseId = (int)reader["ID"];
                CurrentWarehouse.Id = warehouseId;
                CurrentWarehouse.Email = warehouseEmail;
                CurrentWarehouse.Password = warehousePassword;

                WarehouseManagement warehouseManagementPage = new WarehouseManagement();
                warehouseManagementPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail or Password is wrong. Please try again.");
            }
            reader.Close();
            connection.Close();
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