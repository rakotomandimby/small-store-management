namespace SmallStoreManagement
{
    partial class CartDetailForm
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
            this.listCartDetailView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartOwner = new System.Windows.Forms.Label();
            this.CartDetailPaidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCartDetailView
            // 
            this.listCartDetailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemCategory,
            this.ItemPrice});
            this.listCartDetailView.FullRowSelect = true;
            this.listCartDetailView.GridLines = true;
            this.listCartDetailView.HideSelection = false;
            this.listCartDetailView.Location = new System.Drawing.Point(12, 65);
            this.listCartDetailView.Name = "listCartDetailView";
            this.listCartDetailView.Size = new System.Drawing.Size(636, 373);
            this.listCartDetailView.TabIndex = 0;
            this.listCartDetailView.UseCompatibleStateImageBehavior = false;
            this.listCartDetailView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Product Name";
            this.ItemName.Width = 512;
            // 
            // ItemCategory
            // 
            this.ItemCategory.Text = "Category";
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Price";
            // 
            // cartOwner
            // 
            this.cartOwner.AutoSize = true;
            this.cartOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartOwner.Location = new System.Drawing.Point(13, 22);
            this.cartOwner.Name = "cartOwner";
            this.cartOwner.Size = new System.Drawing.Size(165, 37);
            this.cartOwner.TabIndex = 1;
            this.cartOwner.Text = "cartOwner";
            // 
            // CartDetailPaidButton
            // 
            this.CartDetailPaidButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CartDetailPaidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartDetailPaidButton.Location = new System.Drawing.Point(512, 12);
            this.CartDetailPaidButton.Name = "CartDetailPaidButton";
            this.CartDetailPaidButton.Size = new System.Drawing.Size(138, 47);
            this.CartDetailPaidButton.TabIndex = 2;
            this.CartDetailPaidButton.Text = "Paid";
            this.CartDetailPaidButton.UseVisualStyleBackColor = false;
            this.CartDetailPaidButton.Click += new System.EventHandler(this.CartDetailPaid_Click);
            // 
            // CartDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.CartDetailPaidButton);
            this.Controls.Add(this.cartOwner);
            this.Controls.Add(this.listCartDetailView);
            this.Name = "CartDetailForm";
            this.Text = "CartDetailForm";
            this.Load += new System.EventHandler(this.CartDetailForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCartDetailView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemCategory;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.Label cartOwner;
        private System.Windows.Forms.Button CartDetailPaidButton;
    }
}