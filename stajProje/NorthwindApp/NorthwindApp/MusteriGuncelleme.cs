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
    public partial class MusteriGuncelleme : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";
        public MusteriGuncelleme()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void MusteriGuncelleme_Load(object sender, EventArgs e)
        {
            
            LoadCustomers();
        }

        private void LoadCustomers()
        {
           
            string query = "SELECT CustomerID, CompanyName, ContactName, ContactTitle FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // DataGridView'e verileri yükle
                    dataGridViewCustomers.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satıra tıklandı mı?
            {
                DataGridViewRow row = dataGridViewCustomers.Rows[e.RowIndex];

                
                textBoxCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                textBoxCompanyName.Text = row.Cells["CompanyName"].Value.ToString();
                textBoxContactName.Text = row.Cells["ContactName"].Value.ToString();
                textBoxContactTitle.Text = row.Cells["ContactTitle"].Value.ToString();
            }
        }

        
        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
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

            
            string query = "UPDATE Customers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle WHERE CustomerID = @CustomerID";

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
                            MessageBox.Show("Müşteri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers(); 
                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
