namespace NorthwindApp
{
    partial class MusteriEkleForm
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
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.labelContactTitle = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.textBoxContactTitle = new System.Windows.Forms.TextBox();
            this.buttonMusteriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(56, 48);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(62, 13);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "CustomerID";
            this.labelCustomerID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(56, 101);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(79, 13);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "CompanyName";
            this.labelCompanyName.Click += new System.EventHandler(this.labelCompanyName_Click);
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(56, 155);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(72, 13);
            this.labelContactName.TabIndex = 2;
            this.labelContactName.Text = "ContactName";
            // 
            // labelContactTitle
            // 
            this.labelContactTitle.AutoSize = true;
            this.labelContactTitle.Location = new System.Drawing.Point(56, 210);
            this.labelContactTitle.Name = "labelContactTitle";
            this.labelContactTitle.Size = new System.Drawing.Size(64, 13);
            this.labelContactTitle.TabIndex = 3;
            this.labelContactTitle.Text = "ContactTitle";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(158, 41);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 4;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(158, 94);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 5;
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(158, 148);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactName.TabIndex = 6;
            // 
            // textBoxContactTitle
            // 
            this.textBoxContactTitle.Location = new System.Drawing.Point(158, 203);
            this.textBoxContactTitle.Name = "textBoxContactTitle";
            this.textBoxContactTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactTitle.TabIndex = 7;
            // 
            // buttonMusteriEkle
            // 
            this.buttonMusteriEkle.Location = new System.Drawing.Point(428, 101);
            this.buttonMusteriEkle.Name = "buttonMusteriEkle";
            this.buttonMusteriEkle.Size = new System.Drawing.Size(168, 41);
            this.buttonMusteriEkle.TabIndex = 8;
            this.buttonMusteriEkle.Text = "Müşteri Ekle";
            this.buttonMusteriEkle.UseVisualStyleBackColor = true;
            this.buttonMusteriEkle.Click += new System.EventHandler(this.buttonMusteriEkle_Click);
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 275);
            this.Controls.Add(this.buttonMusteriEkle);
            this.Controls.Add(this.textBoxContactTitle);
            this.Controls.Add(this.textBoxContactName);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelContactTitle);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCustomerID);
            this.Name = "MusteriEkleForm";
            this.Text = "MusteriEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Label labelContactTitle;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.TextBox textBoxContactTitle;
        private System.Windows.Forms.Button buttonMusteriEkle;
    }
}