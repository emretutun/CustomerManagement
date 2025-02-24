namespace NorthwindApp
{
    partial class MusteriIslemleriForm
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonMusteriEkle = new System.Windows.Forms.Button();
            this.buttonMusteriSil = new System.Windows.Forms.Button();
            this.buttonMusteriGuncelle = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(470, 385);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // buttonMusteriEkle
            // 
            this.buttonMusteriEkle.Location = new System.Drawing.Point(581, 58);
            this.buttonMusteriEkle.Name = "buttonMusteriEkle";
            this.buttonMusteriEkle.Size = new System.Drawing.Size(144, 23);
            this.buttonMusteriEkle.TabIndex = 1;
            this.buttonMusteriEkle.Text = "Müşteri Ekle";
            this.buttonMusteriEkle.UseVisualStyleBackColor = true;
            this.buttonMusteriEkle.Click += new System.EventHandler(this.buttonMusteriEkle_Click);
            // 
            // buttonMusteriSil
            // 
            this.buttonMusteriSil.Location = new System.Drawing.Point(581, 115);
            this.buttonMusteriSil.Name = "buttonMusteriSil";
            this.buttonMusteriSil.Size = new System.Drawing.Size(144, 23);
            this.buttonMusteriSil.TabIndex = 2;
            this.buttonMusteriSil.Text = "Müşteri Sil";
            this.buttonMusteriSil.UseVisualStyleBackColor = true;
            this.buttonMusteriSil.Click += new System.EventHandler(this.buttonMusteriSil_Click);
            // 
            // buttonMusteriGuncelle
            // 
            this.buttonMusteriGuncelle.Location = new System.Drawing.Point(581, 173);
            this.buttonMusteriGuncelle.Name = "buttonMusteriGuncelle";
            this.buttonMusteriGuncelle.Size = new System.Drawing.Size(144, 23);
            this.buttonMusteriGuncelle.TabIndex = 3;
            this.buttonMusteriGuncelle.Text = "Müşteri Güncelle";
            this.buttonMusteriGuncelle.UseVisualStyleBackColor = true;
            this.buttonMusteriGuncelle.Click += new System.EventHandler(this.buttonMusteriGuncelle_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(105, 25);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(100, 20);
            this.textBoxAra.TabIndex = 4;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(235, 25);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 23);
            this.buttonAra.TabIndex = 5;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Ara :";
            // 
            // MusteriIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonMusteriGuncelle);
            this.Controls.Add(this.buttonMusteriSil);
            this.Controls.Add(this.buttonMusteriEkle);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "MusteriIslemleriForm";
            this.Text = "MusteriIslemleriForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonMusteriEkle;
        private System.Windows.Forms.Button buttonMusteriSil;
        private System.Windows.Forms.Button buttonMusteriGuncelle;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label1;
    }
}