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
    public partial class UrunGuncelleme : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";
        private string productID;

        public UrunGuncelleme(string productID, string productName, string supplierID, string categoryID, string quantityPerUnit, string unitPrice, string unitsInStock, string unitsOnOrder, string reorderLevel, string discontinued)
        {
            InitializeComponent();
            this.productID = productID;
            textBoxProductName.Text = productName;
            textBoxSupplierID.Text = supplierID;
            textBoxCategoryID.Text = categoryID;
            textBoxQuantityPerUnit.Text = quantityPerUnit;
            textBoxUnitPrice.Text = unitPrice;
            textBoxUnitsInStock.Text = unitsInStock;
            textBoxUnitsOnOrder.Text = unitsOnOrder;
            textBoxReorderLevel.Text = reorderLevel;
            checkBoxDiscontinued.Checked = discontinued == "True";
        }

        private void buttonUrunGuncelle_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text.Trim();
            string supplierID = textBoxSupplierID.Text.Trim();
            string categoryID = textBoxCategoryID.Text.Trim();
            string quantityPerUnit = textBoxQuantityPerUnit.Text.Trim();
            string unitPrice = textBoxUnitPrice.Text.Trim();
            string unitsInStock = textBoxUnitsInStock.Text.Trim();
            string unitsOnOrder = textBoxUnitsOnOrder.Text.Trim();
            string reorderLevel = textBoxReorderLevel.Text.Trim();
            string discontinued = checkBoxDiscontinued.Checked ? "1" : "0";

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(unitPrice))
            {
                MessageBox.Show("Ürün adı ve fiyatı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
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
                            MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Ürün güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

