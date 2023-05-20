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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KUBRA\\SQLEXPRESS;Initial Catalog=MidtermProject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO FACTORIES (FACTORY_E_MAIL, PASSWORD, FACTORY_NAME, FACTORY_PHONE_NUMBER, FACTORY_COUNTRY, FACTORY_ADDRESS, FACTORY_TAX_NUMBER, FACTORY_TYPE_ID) VALUES (@FACTORY_E_MAIL, @PASSWORD, @FACTORY_NAME, @FACTORY_PHONE_NUMBER, @FACTORY_COUNTRY, @FACTORY_ADDRESS, @FACTORY_TAX_NUMBER, @FACTORY_TYPE_ID)", connection);
            command.Parameters.AddWithValue("@FACTORY_E_MAIL", txtFactoryEmail.Text);
            command.Parameters.AddWithValue("@PASSWORD", txtFactoryPassword.Text);
            command.Parameters.AddWithValue("@FACTORY_NAME", txtFactoryName.Text);
            command.Parameters.AddWithValue("@FACTORY_PHONE_NUMBER", txtFactoryPhone.Text);
            command.Parameters.AddWithValue("@FACTORY_COUNTRY", comboBoxCountries.Text);
            command.Parameters.AddWithValue("@FACTORY_ADDRESS", txtFactoryAddress.Text);
            command.Parameters.AddWithValue("@FACTORY_TAX_NUMBER", txtFactoryTaxNumber.Text);
            command.Parameters.AddWithValue("@FACTORY_TYPE_ID", radioBtnProducer.Checked ? 1 : 2);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            LoginPage loginForm = new LoginPage();
            loginForm.Show();
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