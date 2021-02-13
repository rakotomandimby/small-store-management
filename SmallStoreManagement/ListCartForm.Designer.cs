namespace SmallStoreManagement
{
    partial class ListCartForm
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
            this.listCartFormView = new System.Windows.Forms.ListView();
            this.CartOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listCartFormView
            // 
            this.listCartFormView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CartOwner,
            this.CartTotal});
            this.listCartFormView.FullRowSelect = true;
            this.listCartFormView.GridLines = true;
            this.listCartFormView.HideSelection = false;
            this.listCartFormView.Location = new System.Drawing.Point(12, 33);
            this.listCartFormView.Name = "listCartFormView";
            this.listCartFormView.Size = new System.Drawing.Size(330, 233);
            this.listCartFormView.TabIndex = 0;
            this.listCartFormView.UseCompatibleStateImageBehavior = false;
            this.listCartFormView.View = System.Windows.Forms.View.Details;
            this.listCartFormView.DoubleClick += new System.EventHandler(this.listCartForm_DoubleClick);
            // 
            // CartOwner
            // 
            this.CartOwner.Text = "Owner of the Cart";
            this.CartOwner.Width = 256;
            // 
            // CartTotal
            // 
            this.CartTotal.Text = "Total";
            // 
            // ListCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 278);
            this.Controls.Add(this.listCartFormView);
            this.Name = "ListCartForm";
            this.Text = "ListCartForm";
            this.Load += new System.EventHandler(this.ListCartForm_load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCartFormView;
        private System.Windows.Forms.ColumnHeader CartOwner;
        private System.Windows.Forms.ColumnHeader CartTotal;
    }
}