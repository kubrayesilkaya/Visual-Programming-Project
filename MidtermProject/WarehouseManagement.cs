using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProject
{
    public partial class WarehouseManagement : Form
    {
        public WarehouseManagement()
        {
            InitializeComponent();

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string Message = "\n  You Can Update\n    Informations\nOf Your Warehouse";
            lblWarehousesManagementWelcome.Text = lblWarehousesManagementWelcome.Text + Message;
        }

        private void btnUpdateChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE WAREHOUSE SET WAREHOUSE_NAME = @warehouseName, WAREHOUSE_E_MAIL = @warehouseEmail, WAREHOUSE_PHONE_NUMBER = @warehousePhoneNumber, WAREHOUSE_PASSWORD = @warehousePassword WHERE ID = @warehouseId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@warehouseName", txtWarehouseName.Text);
                command.Parameters.AddWithValue("@warehouseEmail", txtWarehouseEmail.Text);
                command.Parameters.AddWithValue("@warehousePhoneNumber", txtWarehousePhoneNumber.Text);
                command.Parameters.AddWithValue("@warehousePassword", txtWarehousePassword.Text);
                command.Parameters.AddWithValue("@warehouseId", CurrentWarehouse.Id);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Warehouse information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Warehouse information update failed.");
                }
            }

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
    
