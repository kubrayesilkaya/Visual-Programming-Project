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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace MidtermProject
{
    public partial class ProducerFactory : Form
    {
        public ProducerFactory()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string Message = "!\nYou can save the products you produce \nfrom this page to the warehouse.\nPlease do the product update carefully.";
            lblMessage.Text = lblMessage.Text + Message;
        }

        private void btnToSeeWarehouses_Click(object sender, EventArgs e)
        {
            Warehouses warehousePage = new Warehouses();
            warehousePage.Show();
            this.Hide();
        }

        private void ProducerFactory_Load(object sender, EventArgs e)
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
                        comboBoxWarehouses.Items.Add(reader["WAREHOUSE_NAME"].ToString());
                    }
                    connection.Close();
                }
            }
        }

        private void lblSubmitUpdate_Click(object sender, EventArgs e)
        {
            string depoAdi = comboBoxWarehouses.Text;
            string urunAdi = txtEnterTheProduct.Text;
            int urunMiktari = Convert.ToInt32(txtAmountOfProduct.Text);

            // Veritabanına bağlantıyı kur
            SqlConnection con = new SqlConnection("Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True");
            con.Open();

            // Ürünün veritabanında olup olmadığını kontrol et
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM PRODUCTS WHERE PRODUCT_NAME = @productName AND WAREHOUSE_ID = (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME=@warehouseName)", con);
            checkCmd.Parameters.AddWithValue("@productName", urunAdi);
            checkCmd.Parameters.AddWithValue("@warehouseName", depoAdi);
            int existCount = (int)checkCmd.ExecuteScalar();

            if (existCount > 0) // ürün zaten varsa, miktarını artır
            {
                SqlCommand updateCmd = new SqlCommand("UPDATE PRODUCTS SET QUANTITY = QUANTITY + @quantity WHERE PRODUCT_NAME = @productName AND WAREHOUSE_ID = (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME=@warehouseName)", con);
                updateCmd.Parameters.AddWithValue("@productName", urunAdi);
                updateCmd.Parameters.AddWithValue("@quantity", urunMiktari);
                updateCmd.Parameters.AddWithValue("@warehouseName", depoAdi);
                updateCmd.ExecuteNonQuery();
            }
            else // ürün yoksa, yeni kayıt ekle
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO PRODUCTS (PRODUCT_NAME, QUANTITY, WAREHOUSE_ID) VALUES (@productName, @quantity, (SELECT ID FROM WAREHOUSE WHERE WAREHOUSE_NAME=@warehouseName))", con);
                insertCmd.Parameters.AddWithValue("@productName", urunAdi);
                insertCmd.Parameters.AddWithValue("@quantity", urunMiktari);
                insertCmd.Parameters.AddWithValue("@warehouseName", depoAdi);
                insertCmd.ExecuteNonQuery();
            }

            // Veritabanı bağlantısını kapat
            con.Close();

            MessageBox.Show("Ürün başarıyla eklendi!");
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

        private void tipsAndTrickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipsAndTricks tipsAndTricks = new TipsAndTricks();
            tipsAndTricks.ShowDialog();
        }
    }
}
