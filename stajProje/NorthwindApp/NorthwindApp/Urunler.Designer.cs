namespace NorthwindApp
{
    partial class Urunler
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.buttonUrunSil = new System.Windows.Forms.Button();
            this.buttonUrunGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrunAra = new System.Windows.Forms.TextBox();
            this.buttonUrunAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(1063, 410);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Location = new System.Drawing.Point(67, 469);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(148, 23);
            this.buttonUrunEkle.TabIndex = 1;
            this.buttonUrunEkle.Text = "Ürün Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // buttonUrunSil
            // 
            this.buttonUrunSil.Location = new System.Drawing.Point(273, 469);
            this.buttonUrunSil.Name = "buttonUrunSil";
            this.buttonUrunSil.Size = new System.Drawing.Size(154, 23);
            this.buttonUrunSil.TabIndex = 2;
            this.buttonUrunSil.Text = "Ürün Sil";
            this.buttonUrunSil.UseVisualStyleBackColor = true;
            this.buttonUrunSil.Click += new System.EventHandler(this.buttonUrunSil_Click);
            // 
            // buttonUrunGuncelle
            // 
            this.buttonUrunGuncelle.Location = new System.Drawing.Point(478, 469);
            this.buttonUrunGuncelle.Name = "buttonUrunGuncelle";
            this.buttonUrunGuncelle.Size = new System.Drawing.Size(136, 23);
            this.buttonUrunGuncelle.TabIndex = 3;
            this.buttonUrunGuncelle.Text = "Ürün Güncelle";
            this.buttonUrunGuncelle.UseVisualStyleBackColor = true;
            this.buttonUrunGuncelle.Click += new System.EventHandler(this.buttonUrunGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara :";
            // 
            // textBoxUrunAra
            // 
            this.textBoxUrunAra.Location = new System.Drawing.Point(168, 25);
            this.textBoxUrunAra.Name = "textBoxUrunAra";
            this.textBoxUrunAra.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunAra.TabIndex = 5;
            // 
            // buttonUrunAra
            // 
            this.buttonUrunAra.Location = new System.Drawing.Point(285, 22);
            this.buttonUrunAra.Name = "buttonUrunAra";
            this.buttonUrunAra.Size = new System.Drawing.Size(75, 23);
            this.buttonUrunAra.TabIndex = 6;
            this.buttonUrunAra.Text = "Ara";
            this.buttonUrunAra.UseVisualStyleBackColor = true;
            this.buttonUrunAra.Click += new System.EventHandler(this.buttonUrunAra_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 543);
            this.Controls.Add(this.buttonUrunAra);
            this.Controls.Add(this.textBoxUrunAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUrunGuncelle);
            this.Controls.Add(this.buttonUrunSil);
            this.Controls.Add(this.buttonUrunEkle);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "Urunler";
            this.Text = "Urunler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.Button buttonUrunSil;
        private System.Windows.Forms.Button buttonUrunGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrunAra;
        private System.Windows.Forms.Button buttonUrunAra;
    }
}