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
    public partial class Siparisler : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";

        public Siparisler()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = "SELECT OrderDate, Freight, ShipName, ShipCity FROM Orders";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataOrders.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}