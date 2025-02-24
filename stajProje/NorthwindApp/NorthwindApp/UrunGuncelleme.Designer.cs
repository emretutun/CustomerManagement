namespace NorthwindApp
{
    partial class UrunGuncelleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUrunGuncelle = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxSupplierID = new System.Windows.Forms.TextBox();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.textBoxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnitsInStock = new System.Windows.Forms.TextBox();
            this.textBoxUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.textBoxReorderLevel = new System.Windows.Forms.TextBox();
            this.checkBoxDiscontinued = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi ID:\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori ID:\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Miktarı:\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birim Fiyatı:\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stoktaki Miktar:\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sipariş Miktarı:\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Yeniden Sipariş Seviyesi:\n";
            // 
            // buttonUrunGuncelle
            // 
            this.buttonUrunGuncelle.Location = new System.Drawing.Point(595, 198);
            this.buttonUrunGuncelle.Name = "buttonUrunGuncelle";
            this.buttonUrunGuncelle.Size = new System.Drawing.Size(152, 23);
            this.buttonUrunGuncelle.TabIndex = 8;
            this.buttonUrunGuncelle.Text = "Ürünü Güncelle";
            this.buttonUrunGuncelle.UseVisualStyleBackColor = true;
            this.buttonUrunGuncelle.Click += new System.EventHandler(this.buttonUrunGuncelle_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(317, 23);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 9;
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Location = new System.Drawing.Point(317, 54);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSupplierID.TabIndex = 10;
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.Location = new System.Drawing.Point(317, 101);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoryID.TabIndex = 11;
            // 
            // textBoxQuantityPerUnit
            // 
            this.textBoxQuantityPerUnit.Location = new System.Drawing.Point(317, 146);
            this.textBoxQuantityPerUnit.Name = "textBoxQuantityPerUnit";
            this.textBoxQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantityPerUnit.TabIndex = 12;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(317, 196);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitPrice.TabIndex = 13;
            // 
            // textBoxUnitsInStock
            // 
            this.textBoxUnitsInStock.Location = new System.Drawing.Point(317, 248);
            this.textBoxUnitsInStock.Name = "textBoxUnitsInStock";
            this.textBoxUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitsInStock.TabIndex = 14;
            // 
            // textBoxUnitsOnOrder
            // 
            this.textBoxUnitsOnOrder.Location = new System.Drawing.Point(317, 285);
            this.textBoxUnitsOnOrder.Name = "textBoxUnitsOnOrder";
            this.textBoxUnitsOnOrder.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitsOnOrder.TabIndex = 15;
            // 
            // textBoxReorderLevel
            // 
            this.textBoxReorderLevel.Location = new System.Drawing.Point(317, 331);
            this.textBoxReorderLevel.Name = "textBoxReorderLevel";
            this.textBoxReorderLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxReorderLevel.TabIndex = 16;
            // 
            // checkBoxDiscontinued
            // 
            this.checkBoxDiscontinued.AutoSize = true;
            this.checkBoxDiscontinued.Location = new System.Drawing.Point(63, 379);
            this.checkBoxDiscontinued.Name = "checkBoxDiscontinued";
            this.checkBoxDiscontinued.Size = new System.Drawing.Size(124, 17);
            this.checkBoxDiscontinued.TabIndex = 17;
            this.checkBoxDiscontinued.Text = "Satıştan Kaldırıldı mı?\n";
            this.checkBoxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // UrunGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxDiscontinued);
            this.Controls.Add(this.textBoxReorderLevel);
            this.Controls.Add(this.textBoxUnitsOnOrder);
            this.Controls.Add(this.textBoxUnitsInStock);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxQuantityPerUnit);
            this.Controls.Add(this.textBoxCategoryID);
            this.Controls.Add(this.textBoxSupplierID);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonUrunGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunGuncelleme";
            this.Text = "UrunGuncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUrunGuncelle;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxSupplierID;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.TextBox textBoxQuantityPerUnit;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxUnitsInStock;
        private System.Windows.Forms.TextBox textBoxUnitsOnOrder;
        private System.Windows.Forms.TextBox textBoxReorderLevel;
        private System.Windows.Forms.CheckBox checkBoxDiscontinued;
    }
}