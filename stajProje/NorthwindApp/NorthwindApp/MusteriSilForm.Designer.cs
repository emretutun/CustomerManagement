namespace NorthwindApp
{
    partial class MusteriSilForm
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
            this.labelMusteriID = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.buttonMusteriSil = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMusteriID
            // 
            this.labelMusteriID.AutoSize = true;
            this.labelMusteriID.Location = new System.Drawing.Point(41, 87);
            this.labelMusteriID.Name = "labelMusteriID";
            this.labelMusteriID.Size = new System.Drawing.Size(85, 13);
            this.labelMusteriID.TabIndex = 0;
            this.labelMusteriID.Text = "Müşteri ID Girin :";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(145, 87);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 1;
            // 
            // buttonMusteriSil
            // 
            this.buttonMusteriSil.Location = new System.Drawing.Point(93, 133);
            this.buttonMusteriSil.Name = "buttonMusteriSil";
            this.buttonMusteriSil.Size = new System.Drawing.Size(75, 23);
            this.buttonMusteriSil.TabIndex = 2;
            this.buttonMusteriSil.Text = "Sil";
            this.buttonMusteriSil.UseVisualStyleBackColor = true;
            this.buttonMusteriSil.Click += new System.EventHandler(this.buttonMusteriSil_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(273, 36);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(463, 359);
            this.dataGridViewCustomers.TabIndex = 3;
            // 
            // MusteriSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.buttonMusteriSil);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelMusteriID);
            this.Name = "MusteriSilForm";
            this.Text = "MusteriSilForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMusteriID;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Button buttonMusteriSil;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}