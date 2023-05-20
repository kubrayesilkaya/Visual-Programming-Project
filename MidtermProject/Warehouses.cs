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
    public partial class Warehouses : Form
    {
        public Warehouses()
        {
            InitializeComponent();
        }

        private void Warehouses_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT WAREHOUSE_NAME FROM WAREHOUSE";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxWarehousesPage.Items.Add(reader["WAREHOUSE_NAME"].ToString());
                    }
                    connection.Close();
                }
            }
        }

        private void btnClickWarehouse_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectedWarehouse = comboBoxWarehousesPage.SelectedItem.ToString();
                string queryProducts = "SELECT PRODUCT_NAME, PRODUCT_PRICE, QUANTITY FROM PRODUCTS WHERE WAREHOUSE_ID = (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME = @SelectedWarehouse)";
                using (SqlCommand command = new SqlCommand(queryProducts, connection))
                {
                    command.Parameters.AddWithValue("@SelectedWarehouse", selectedWarehouse);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewProducts.DataSource = table;
                    }
                }
            }
        }

        private void btnToPassFactoriesPage_Click(object sender, EventArgs e)
        {
            FactoriesList factoriesList = new FactoriesList();
            factoriesList.Show();
            this.Hide();
            

        }

        private void btnToPreviousPage_Click(object sender, EventArgs e)
        {
            if (CurrentUser.FactoryTypeId == 1)
            {
                ProducerFactory producerFactoryForm = new ProducerFactory();
                producerFactoryForm.Show();
                this.Hide();
            }
            else if (CurrentUser.FactoryTypeId == 2)
            {
                ConsumerFactory consumerFactoryForm = new ConsumerFactory();
                consumerFactoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid factory type.");
            }
        }

        private void btnInformationsOfWarehouses_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectedWarehouse = comboBoxWarehousesPage.SelectedItem.ToString();
                string query = "SELECT WAREHOUSE_E_MAIL, WAREHOUSE_PHONE_NUMBER, WAREHOUSE_COUNTRY, WAREHOUSE_ADDRESS FROM WAREHOUSE WHERE WAREHOUSE_NAME = @SelectedWarehouse";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedWarehouse", selectedWarehouse);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewProducts.DataSource = table;
                    }
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