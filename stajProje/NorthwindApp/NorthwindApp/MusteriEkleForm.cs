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

namespace NorthwindApp
{
    public partial class MusteriEkleForm : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";

        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            string customerID = textBoxCustomerID.Text.Trim();
            string companyName = textBoxCompanyName.Text.Trim();
            string contactName = textBoxContactName.Text.Trim();
            string contactTitle = textBoxContactTitle.Text.Trim();

            if (string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Müşteri ID ve Şirket Adı zorunludur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle) " +
                           "VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CompanyName", companyName);
                        command.Parameters.AddWithValue("@ContactName", contactName);
                        command.Parameters.AddWithValue("@ContactTitle", contactTitle);

                        
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelCompanyName_Click(object sender, EventArgs e)
        {

        }
    }
}