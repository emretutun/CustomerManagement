using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindApp
{
    public partial class MainForm : Form
    {
        private string kullaniciRolu; 

        
        public MainForm(string rol)
        {
            InitializeComponent();
            kullaniciRolu = rol;
            YetkiKontrol(); 
        }

        private void YetkiKontrol()
        {
            if (kullaniciRolu == "Personel")
            {
                
                btnMusteriIslemleri.Enabled = false;
                btnMusteriIslemleri.Visible = false;

                buttonUrunler.Enabled = false;
                buttonUrunler.Visible = false;
            }
            else if (kullaniciRolu == "Admin")
            {
               
                btnMusteriIslemleri.Enabled = true;
                btnMusteriIslemleri.Visible = true;

                buttonUrunler.Enabled = true;
                buttonUrunler.Visible = true;
            }
            else
            {
                btnMusteriIslemleri.Enabled = false;
                btnMusteriIslemleri.Visible = false;

                buttonUrunler.Enabled = false;
                buttonUrunler.Visible = false;

                buttonSiparisler.Enabled = false;
                buttonSiparisler.Visible = false;
            }
        }

        
        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            MusteriIslemleriForm musteriForm = new MusteriIslemleriForm();
            musteriForm.Show();
        }

        private void buttonSiparisler_Click(object sender, EventArgs e)
        {
            Siparisler siparislerForm = new Siparisler();
            siparislerForm.ShowDialog();
        }

        private void buttonUrunler_Click(object sender, EventArgs e)
        {
            Urunler urunlerForm = new Urunler();
            urunlerForm.ShowDialog();
        }
    }
}