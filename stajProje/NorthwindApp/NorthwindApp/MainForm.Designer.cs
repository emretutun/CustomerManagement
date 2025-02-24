namespace NorthwindApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.buttonSiparisler = new System.Windows.Forms.Button();
            this.buttonUrunler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(25, 53);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(113, 23);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // buttonSiparisler
            // 
            this.buttonSiparisler.Location = new System.Drawing.Point(194, 53);
            this.buttonSiparisler.Name = "buttonSiparisler";
            this.buttonSiparisler.Size = new System.Drawing.Size(115, 25);
            this.buttonSiparisler.TabIndex = 1;
            this.buttonSiparisler.Text = "Tüm Siparişler";
            this.buttonSiparisler.UseVisualStyleBackColor = true;
            this.buttonSiparisler.Click += new System.EventHandler(this.buttonSiparisler_Click);
            // 
            // buttonUrunler
            // 
            this.buttonUrunler.Location = new System.Drawing.Point(348, 53);
            this.buttonUrunler.Name = "buttonUrunler";
            this.buttonUrunler.Size = new System.Drawing.Size(116, 25);
            this.buttonUrunler.TabIndex = 2;
            this.buttonUrunler.Text = "Ürün İşlemleri";
            this.buttonUrunler.UseVisualStyleBackColor = true;
            this.buttonUrunler.Click += new System.EventHandler(this.buttonUrunler_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUrunler);
            this.Controls.Add(this.buttonSiparisler);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button buttonSiparisler;
        private System.Windows.Forms.Button buttonUrunler;
    }
}