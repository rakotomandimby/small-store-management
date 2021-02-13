namespace SmallStoreManagement
{
    partial class AddCustomerForm
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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerDiscountLabel = new System.Windows.Forms.Label();
            this.NewCustomerName = new System.Windows.Forms.TextBox();
            this.NewCustmomerAddress = new System.Windows.Forms.TextBox();
            this.NewCustomerDiscount = new System.Windows.Forms.TextBox();
            this.NewCustomerAddButton = new System.Windows.Forms.Button();
            this.CustomerPasswordLabel = new System.Windows.Forms.Label();
            this.NewCustomerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(166, 25);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressLabel.Location = new System.Drawing.Point(12, 62);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(189, 25);
            this.CustomerAddressLabel.TabIndex = 5;
            this.CustomerAddressLabel.Text = "Customer Address";
            // 
            // CustomerDiscountLabel
            // 
            this.CustomerDiscountLabel.AutoSize = true;
            this.CustomerDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDiscountLabel.Location = new System.Drawing.Point(12, 87);
            this.CustomerDiscountLabel.Name = "CustomerDiscountLabel";
            this.CustomerDiscountLabel.Size = new System.Drawing.Size(194, 25);
            this.CustomerDiscountLabel.TabIndex = 6;
            this.CustomerDiscountLabel.Text = "Customer Discount";
            // 
            // NewCustomerName
            // 
            this.NewCustomerName.Location = new System.Drawing.Point(219, 13);
            this.NewCustomerName.Name = "NewCustomerName";
            this.NewCustomerName.Size = new System.Drawing.Size(164, 20);
            this.NewCustomerName.TabIndex = 7;
            // 
            // NewCustmomerAddress
            // 
            this.NewCustmomerAddress.Location = new System.Drawing.Point(219, 62);
            this.NewCustmomerAddress.Name = "NewCustmomerAddress";
            this.NewCustmomerAddress.Size = new System.Drawing.Size(164, 20);
            this.NewCustmomerAddress.TabIndex = 8;
            // 
            // NewCustomerDiscount
            // 
            this.NewCustomerDiscount.Location = new System.Drawing.Point(219, 90);
            this.NewCustomerDiscount.Name = "NewCustomerDiscount";
            this.NewCustomerDiscount.Size = new System.Drawing.Size(164, 20);
            this.NewCustomerDiscount.TabIndex = 9;
            // 
            // NewCustomerAddButton
            // 
            this.NewCustomerAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerAddButton.Location = new System.Drawing.Point(233, 119);
            this.NewCustomerAddButton.Name = "NewCustomerAddButton";
            this.NewCustomerAddButton.Size = new System.Drawing.Size(105, 43);
            this.NewCustomerAddButton.TabIndex = 10;
            this.NewCustomerAddButton.Text = "Add";
            this.NewCustomerAddButton.UseVisualStyleBackColor = true;
            this.NewCustomerAddButton.Click += new System.EventHandler(this.NewCustomerAddButton_Click);
            // 
            // CustomerPasswordLabel
            // 
            this.CustomerPasswordLabel.AutoSize = true;
            this.CustomerPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPasswordLabel.Location = new System.Drawing.Point(12, 37);
            this.CustomerPasswordLabel.Name = "CustomerPasswordLabel";
            this.CustomerPasswordLabel.Size = new System.Drawing.Size(204, 25);
            this.CustomerPasswordLabel.TabIndex = 11;
            this.CustomerPasswordLabel.Text = "Customer Password";
            // 
            // NewCustomerPassword
            // 
            this.NewCustomerPassword.Location = new System.Drawing.Point(219, 39);
            this.NewCustomerPassword.Name = "NewCustomerPassword";
            this.NewCustomerPassword.Size = new System.Drawing.Size(164, 20);
            this.NewCustomerPassword.TabIndex = 12;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 189);
            this.Controls.Add(this.NewCustomerPassword);
            this.Controls.Add(this.CustomerPasswordLabel);
            this.Controls.Add(this.NewCustomerAddButton);
            this.Controls.Add(this.NewCustomerDiscount);
            this.Controls.Add(this.NewCustmomerAddress);
            this.Controls.Add(this.NewCustomerName);
            this.Controls.Add(this.CustomerDiscountLabel);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerDiscountLabel;
        private System.Windows.Forms.TextBox NewCustomerName;
        private System.Windows.Forms.TextBox NewCustmomerAddress;
        private System.Windows.Forms.TextBox NewCustomerDiscount;
        private System.Windows.Forms.Button NewCustomerAddButton;
        private System.Windows.Forms.Label CustomerPasswordLabel;
        private System.Windows.Forms.TextBox NewCustomerPassword;
    }
}