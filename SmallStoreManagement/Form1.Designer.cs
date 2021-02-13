namespace SmallStoreManagement
{
    partial class Form1
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
            this.buttonCustomersList = new System.Windows.Forms.Button();
            this.buttonProductsList = new System.Windows.Forms.Button();
            this.buttonCartsList = new System.Windows.Forms.Button();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.AddNewCustomerButton = new System.Windows.Forms.Button();
            this.HomeLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCustomersList
            // 
            this.buttonCustomersList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomersList.Location = new System.Drawing.Point(19, 44);
            this.buttonCustomersList.Name = "buttonCustomersList";
            this.buttonCustomersList.Size = new System.Drawing.Size(259, 23);
            this.buttonCustomersList.TabIndex = 2;
            this.buttonCustomersList.Text = "Open List of Customers";
            this.buttonCustomersList.UseVisualStyleBackColor = false;
            this.buttonCustomersList.Click += new System.EventHandler(this.buttonCustomersList_Click);
            // 
            // buttonProductsList
            // 
            this.buttonProductsList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductsList.Location = new System.Drawing.Point(19, 73);
            this.buttonProductsList.Name = "buttonProductsList";
            this.buttonProductsList.Size = new System.Drawing.Size(259, 23);
            this.buttonProductsList.TabIndex = 3;
            this.buttonProductsList.Text = "Open List of Products";
            this.buttonProductsList.UseVisualStyleBackColor = false;
            this.buttonProductsList.Click += new System.EventHandler(this.buttonProductsList_Click);
            // 
            // buttonCartsList
            // 
            this.buttonCartsList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCartsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartsList.Location = new System.Drawing.Point(19, 102);
            this.buttonCartsList.Name = "buttonCartsList";
            this.buttonCartsList.Size = new System.Drawing.Size(259, 23);
            this.buttonCartsList.TabIndex = 4;
            this.buttonCartsList.Text = "Open List of Carts";
            this.buttonCartsList.UseVisualStyleBackColor = false;
            this.buttonCartsList.Click += new System.EventHandler(this.buttonCartsList_Click);
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddNewProductButton.Location = new System.Drawing.Point(351, 73);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(166, 23);
            this.AddNewProductButton.TabIndex = 5;
            this.AddNewProductButton.Text = "Add new Product";
            this.AddNewProductButton.UseVisualStyleBackColor = false;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.Location = new System.Drawing.Point(351, 44);
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.Size = new System.Drawing.Size(166, 23);
            this.AddNewCustomerButton.TabIndex = 6;
            this.AddNewCustomerButton.Text = "Add new Customer";
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // HomeLoginButton
            // 
            this.HomeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLoginButton.Location = new System.Drawing.Point(612, 44);
            this.HomeLoginButton.Name = "HomeLoginButton";
            this.HomeLoginButton.Size = new System.Drawing.Size(233, 101);
            this.HomeLoginButton.TabIndex = 7;
            this.HomeLoginButton.Text = "Log In";
            this.HomeLoginButton.UseVisualStyleBackColor = true;
            this.HomeLoginButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.HomeLoginButton);
            this.Controls.Add(this.AddNewCustomerButton);
            this.Controls.Add(this.AddNewProductButton);
            this.Controls.Add(this.buttonCartsList);
            this.Controls.Add(this.buttonProductsList);
            this.Controls.Add(this.buttonCustomersList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomersList;
        private System.Windows.Forms.Button buttonProductsList;
        private System.Windows.Forms.Button buttonCartsList;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.Button AddNewCustomerButton;
        private System.Windows.Forms.Button HomeLoginButton;
    }
}

