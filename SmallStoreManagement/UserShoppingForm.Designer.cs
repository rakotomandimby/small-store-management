namespace SmallStoreManagement
{
    partial class UserShoppingForm
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
            this.listShoppingView = new System.Windows.Forms.ListView();
            this.UsernameDisplay = new System.Windows.Forms.Label();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCartView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShoppingView
            // 
            this.listShoppingView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductCategory,
            this.ProductPrice});
            this.listShoppingView.FullRowSelect = true;
            this.listShoppingView.GridLines = true;
            this.listShoppingView.HideSelection = false;
            this.listShoppingView.Location = new System.Drawing.Point(12, 86);
            this.listShoppingView.Name = "listShoppingView";
            this.listShoppingView.Size = new System.Drawing.Size(776, 287);
            this.listShoppingView.TabIndex = 0;
            this.listShoppingView.UseCompatibleStateImageBehavior = false;
            this.listShoppingView.View = System.Windows.Forms.View.Details;
            this.listShoppingView.DoubleClick += new System.EventHandler(this.listShoppingView_DoubleClick);
            // 
            // UsernameDisplay
            // 
            this.UsernameDisplay.AutoSize = true;
            this.UsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameDisplay.Location = new System.Drawing.Point(13, 13);
            this.UsernameDisplay.Name = "UsernameDisplay";
            this.UsernameDisplay.Size = new System.Drawing.Size(0, 37);
            this.UsernameDisplay.TabIndex = 1;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product";
            this.ProductName.Width = 512;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Text = "Category";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            // 
            // listCartView
            // 
            this.listCartView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listCartView.FullRowSelect = true;
            this.listCartView.GridLines = true;
            this.listCartView.HideSelection = false;
            this.listCartView.Location = new System.Drawing.Point(12, 494);
            this.listCartView.Name = "listCartView";
            this.listCartView.Size = new System.Drawing.Size(776, 298);
            this.listCartView.TabIndex = 2;
            this.listCartView.UseCompatibleStateImageBehavior = false;
            this.listCartView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 512;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // SaveCartButton
            // 
            this.SaveCartButton.Location = new System.Drawing.Point(20, 437);
            this.SaveCartButton.Name = "SaveCartButton";
            this.SaveCartButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCartButton.TabIndex = 3;
            this.SaveCartButton.Text = "Save Cart";
            this.SaveCartButton.UseVisualStyleBackColor = true;
            this.SaveCartButton.Click += new System.EventHandler(this.SaveCartButton_Click);
            // 
            // UserShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 804);
            this.Controls.Add(this.SaveCartButton);
            this.Controls.Add(this.listCartView);
            this.Controls.Add(this.UsernameDisplay);
            this.Controls.Add(this.listShoppingView);
            this.Name = "UserShoppingForm";
            this.Text = "UserShoppingForm";
            this.Load += new System.EventHandler(this.UserShoppingForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listShoppingView;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductCategory;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.Label UsernameDisplay;
        private System.Windows.Forms.ListView listCartView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button SaveCartButton;
    }
}