namespace SmallStoreManagement
{
    partial class ListCustomersForm
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
            this.listCustomersView = new System.Windows.Forms.ListView();
            this.Fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCustomersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCustomersView
            // 
            this.listCustomersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fullname,
            this.Address,
            this.Discount});
            this.listCustomersView.FullRowSelect = true;
            this.listCustomersView.GridLines = true;
            this.listCustomersView.HideSelection = false;
            this.listCustomersView.Location = new System.Drawing.Point(12, 51);
            this.listCustomersView.Name = "listCustomersView";
            this.listCustomersView.Size = new System.Drawing.Size(776, 387);
            this.listCustomersView.TabIndex = 0;
            this.listCustomersView.UseCompatibleStateImageBehavior = false;
            this.listCustomersView.View = System.Windows.Forms.View.Details;
            // 
            // Fullname
            // 
            this.Fullname.Text = "Fullname";
            this.Fullname.Width = 192;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 512;
            // 
            // Discount
            // 
            this.Discount.Text = "Discount";
            // 
            // listCustomersLabel
            // 
            this.listCustomersLabel.AutoSize = true;
            this.listCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomersLabel.Location = new System.Drawing.Point(13, 13);
            this.listCustomersLabel.Name = "listCustomersLabel";
            this.listCustomersLabel.Size = new System.Drawing.Size(226, 31);
            this.listCustomersLabel.TabIndex = 1;
            this.listCustomersLabel.Text = "List of Customers";
            // 
            // ListCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCustomersLabel);
            this.Controls.Add(this.listCustomersView);
            this.Name = "ListCustomersForm";
            this.Text = "ListCustomersForm";
            this.Load += new System.EventHandler(this.ListCustomersForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCustomersView;
        private System.Windows.Forms.Label listCustomersLabel;
        private System.Windows.Forms.ColumnHeader Fullname;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Discount;
    }
}