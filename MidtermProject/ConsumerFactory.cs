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
    public partial class ConsumerFactory : Form
    {
        public ConsumerFactory()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string Message = "!\nYou can save the products you consume \nfrom this page to the warehouse.\nPlease do the product update carefully.";
            lblMessageConsumer.Text = lblMessageConsumer.Text + Message;
        }

        private void btnToSeeWarehouses_Click(object sender, EventArgs e)
        {
            Warehouses warehouseForm = new Warehouses();
            warehouseForm.Show();
            this.Hide();
        }

        private void btnToSubmitStockChanges_Click(object sender, EventArgs e)
        {
            string depoAdi = comboBoxToChooseWarehouse.Text;
            string urunAdi = txtProductName.Text;
            int urunMiktari = Convert.ToInt32(txtAmountOfPrdouct.Text);

            // Veritabanına bağlantıyı kur
            SqlConnection con = new SqlConnection("Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True");
            con.Open();

            // Ürünün veritabanında olup olmadığını kontrol et
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM PRODUCTS WHERE PRODUCT_NAME = @productName AND QUANTITY >= @quantity AND WAREHOUSE_ID = (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME=@warehouseName)", con);
            checkCmd.Parameters.AddWithValue("@productName", urunAdi);
            checkCmd.Parameters.AddWithValue("@quantity", urunMiktari);
            checkCmd.Parameters.AddWithValue("@warehouseName", depoAdi);
            int existCount = (int)checkCmd.ExecuteScalar();

            if (existCount > 0) // ürün varsa, miktarını azalt
            {
                SqlCommand updateCmd = new SqlCommand("UPDATE PRODUCTS SET QUANTITY = QUANTITY - @quantity WHERE PRODUCT_NAME = @productName AND WAREHOUSE_ID = (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME=@warehouseName)", con);
                updateCmd.Parameters.AddWithValue("@productName", urunAdi);
                updateCmd.Parameters.AddWithValue("@quantity", urunMiktari);
                updateCmd.Parameters.AddWithValue("@warehouseName", depoAdi);
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla tüketildi!");
            }
            else // ürün yoksa, hata mesajı göster
            {
                MessageBox.Show("Tüketmek istediğiniz ürün stokta yok veya yeterli miktarda değil!");
            }
        }

        private void ConsumerFactory_Load(object sender, EventArgs e)
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
                        comboBoxToChooseWarehouse.Items.Add(reader["WAREHOUSE_NAME"].ToString());
                    }
                    connection.Close();
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
