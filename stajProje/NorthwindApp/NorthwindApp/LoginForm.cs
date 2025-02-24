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
    public partial class LoginForm : Form
    {
        public static string KullaniciRolu { get; private set; } 

        public LoginForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=instnwnd;Integrated Security=True;";
            string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            KullaniciRolu = result.ToString(); 
                            MessageBox.Show("Giriş Başarılı!", "Başarılı ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mainForm = new MainForm(KullaniciRolu); 
                            this.Hide(); 
                            mainForm.ShowDialog(); 
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}