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
    public partial class Urunler : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";

        public Urunler()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, " +
                           "UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkleForm = new UrunEkle();
            urunEkleForm.ShowDialog();
            LoadProducts();
        }

        private void buttonUrunSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                string productID = dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
                string productName = dataGridViewProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show($"{productName} ürününü silmek istediğinize emin misiniz?", "Ürünü Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteProduct(productID);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteProduct(string productID)
        {
            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProducts(); 
                        }
                        else
                        {
                            MessageBox.Show("Ürün silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                string productID = dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
                string productName = dataGridViewProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                string supplierID = dataGridViewProducts.SelectedRows[0].Cells["SupplierID"].Value.ToString();
                string categoryID = dataGridViewProducts.SelectedRows[0].Cells["CategoryID"].Value.ToString();
                string quantityPerUnit = dataGridViewProducts.SelectedRows[0].Cells["QuantityPerUnit"].Value.ToString();
                string unitPrice = dataGridViewProducts.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
                string unitsInStock = dataGridViewProducts.SelectedRows[0].Cells["UnitsInStock"].Value.ToString();
                string unitsOnOrder = dataGridViewProducts.SelectedRows[0].Cells["UnitsOnOrder"].Value.ToString();
                string reorderLevel = dataGridViewProducts.SelectedRows[0].Cells["ReorderLevel"].Value.ToString();
                string discontinued = dataGridViewProducts.SelectedRows[0].Cells["Discontinued"].Value.ToString();

                
                UrunGuncelleme urunGuncellemeForm = new UrunGuncelleme(productID, productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued);
                urunGuncellemeForm.ShowDialog();

                
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUrunAra_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxUrunAra.Text.Trim();
            string query = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice FROM Products WHERE ProductName LIKE @search OR SupplierID LIKE @search";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
