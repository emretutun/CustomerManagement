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
    public partial class MusteriIslemleriForm : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";
        private object musteriGuncellemeForm;

        public MusteriIslemleriForm()
        {
            InitializeComponent();

            LoadCustomers();
        }

        private void MusteriIslemleriForm_Load(object sender, EventArgs e)
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

                    dataGridViewCustomers.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleForm musteriEkleForm = new MusteriEkleForm();
            musteriEkleForm.ShowDialog();
        }

        private void buttonMusteriSil_Click(object sender, EventArgs e)
        {
            MusteriSilForm musteriSilForm = new MusteriSilForm();
            musteriSilForm.ShowDialog();
        }

        private void buttonMusteriGuncelle_Click(object sender, EventArgs e)
        {
            
            MusteriGuncelleme musteriGuncellemeForm = new MusteriGuncelleme();

           
            musteriGuncellemeForm.ShowDialog();  
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxAra.Text.Trim(); 
            string query = "SELECT CustomerID, CompanyName, ContactName, ContactTitle FROM Customers WHERE CompanyName LIKE @search OR ContactName LIKE @search";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCustomers.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}