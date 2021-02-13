namespace SmallStoreManagement
{
    partial class AddProductForm
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
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.CategoryChoice = new System.Windows.Forms.ComboBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(177, 12);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(293, 20);
            this.ProductName.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(178, 89);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(66, 20);
            this.Price.TabIndex = 1;
            // 
            // CategoryChoice
            // 
            this.CategoryChoice.FormattingEnabled = true;
            this.CategoryChoice.Items.AddRange(new object[] {
            "Frozen",
            "Alcohol",
            "Other"});
            this.CategoryChoice.Location = new System.Drawing.Point(178, 51);
            this.CategoryChoice.Name = "CategoryChoice";
            this.CategoryChoice.Size = new System.Drawing.Size(121, 21);
            this.CategoryChoice.TabIndex = 2;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(3, 9);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(148, 25);
            this.ProductNameLabel.TabIndex = 3;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(3, 47);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(99, 25);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(3, 83);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(61, 25);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price";
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(350, 108);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(120, 51);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 171);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.CategoryChoice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductName);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.ComboBox CategoryChoice;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddProduct;
    }
}