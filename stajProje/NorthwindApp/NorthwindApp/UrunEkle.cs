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
    public partial class UrunEkle : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";

        public UrunEkle()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
        }

        private void LoadCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxCategory.Items.Add(new ComboBoxItem(reader["CategoryName"].ToString(), reader["CategoryID"].ToString()));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, CompanyName FROM Suppliers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxSupplier.Items.Add(new ComboBoxItem(reader["CompanyName"].ToString(), reader["SupplierID"].ToString()));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tedarikçi yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text.Trim();
            string quantityPerUnit = textBoxQuantityPerUnit.Text.Trim();
            decimal unitPrice = Convert.ToDecimal(textBoxUnitPrice.Text);
            int unitsInStock = Convert.ToInt32(textBoxUnitsInStock.Text);
            int unitsOnOrder = Convert.ToInt32(textBoxUnitsOnOrder.Text);
            int reorderLevel = Convert.ToInt32(textBoxReorderLevel.Text);
            bool discontinued = checkBoxDiscontinued.Checked;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Ürün adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           int categoryID = ((ComboBoxItem)comboBoxCategory.SelectedItem).Value;
           int supplierID = ((ComboBoxItem)comboBoxSupplier.SelectedItem).Value;

            string query = "INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, " +
                           "UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                           "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, " +
                           "@UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@SupplierID", supplierID);
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        command.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        command.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                        command.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder);
                        command.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                        command.Parameters.AddWithValue("@Discontinued", discontinued);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ürün eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = int.Parse(value);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}