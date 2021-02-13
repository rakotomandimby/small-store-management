namespace SmallStoreManagement
{
    partial class ListProductsForm
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
            this.listProductsLabel = new System.Windows.Forms.Label();
            this.listProductsView = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listProductsLabel
            // 
            this.listProductsLabel.AutoSize = true;
            this.listProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductsLabel.Location = new System.Drawing.Point(12, 9);
            this.listProductsLabel.Name = "listProductsLabel";
            this.listProductsLabel.Size = new System.Drawing.Size(257, 37);
            this.listProductsLabel.TabIndex = 0;
            this.listProductsLabel.Text = "List of oProducts";
            // 
            // listProductsView
            // 
            this.listProductsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.Category,
            this.Price});
            this.listProductsView.FullRowSelect = true;
            this.listProductsView.GridLines = true;
            this.listProductsView.HideSelection = false;
            this.listProductsView.Location = new System.Drawing.Point(12, 63);
            this.listProductsView.Name = "listProductsView";
            this.listProductsView.Size = new System.Drawing.Size(776, 375);
            this.listProductsView.TabIndex = 1;
            this.listProductsView.UseCompatibleStateImageBehavior = false;
            this.listProductsView.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 600;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listProductsView);
            this.Controls.Add(this.listProductsLabel);
            this.Name = "ListProductsForm";
            this.Text = "ListProductsForm";
            this.Load += new System.EventHandler(this.ListProductsForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listProductsLabel;
        private System.Windows.Forms.ListView listProductsView;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
    }
}