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
    public partial class FactoriesList : Form
    {
        public FactoriesList()
        {
            InitializeComponent();
        }

        private void btnFactoriesList_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";

            // Veritabanı bağlantısı açılır
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // checkBoxProducerFactories seçiliyse, FACTORY_TYPE_ID'si 1 olan fabrikaların verileri alınır
                if (checkBoxProducerFactories.Checked && !checkBoxConsumerFactories.Checked)
                {
                    string query = "SELECT FACTORY_NAME, FACTORY_E_MAIL, FACTORY_PHONE_NUMBER FROM FACTORIES WHERE FACTORY_TYPE_ID = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_FactoriesList.DataSource = table;
                }
                // checkBoxConsumerFactories seçiliyse, FACTORY_TYPE_ID'si 2 olan fabrikaların verileri alınır
                else if (!checkBoxProducerFactories.Checked && checkBoxConsumerFactories.Checked)
                {
                    string query = "SELECT FACTORY_NAME, FACTORY_E_MAIL, FACTORY_PHONE_NUMBER FROM FACTORIES WHERE FACTORY_TYPE_ID = 2";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_FactoriesList.DataSource = table;
                }
                // Her iki checkbox da seçiliyse, FACTORY_TYPE_ID'si 1 ve 2 olan fabrikaların verileri alınır
                else if (checkBoxProducerFactories.Checked && checkBoxConsumerFactories.Checked)
                {
                    string query = "SELECT FACTORY_NAME, FACTORY_E_MAIL, FACTORY_PHONE_NUMBER FROM FACTORIES WHERE FACTORY_TYPE_ID IN (1, 2)";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_FactoriesList.DataSource = table;
                }
                // Hiçbiri seçili değilse, kullanıcı uyarılır
                else
                {
                    MessageBox.Show("Please select at least one checkbox!");
                }
            }
        }

        private void btnToPassPreviousPage_Click(object sender, EventArgs e)
        {
            Warehouses  warehousesPage = new Warehouses();
            warehousesPage.Show();
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
