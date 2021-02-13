using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallStoreManagement
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            if (CategoryChoice.Text.Equals("")) {
                MessageBox.Show("Please, choose a category"); 
                CategoryLabel.BackColor = Color.FromArgb(200, 0, 0); 
            }
            else if (ProductName.Text.Equals(""))  {
                MessageBox.Show("Please, Enter a valid name");
                ProductNameLabel.BackColor = Color.FromArgb(200, 0, 0);
            }
            else if (Price.Text.Equals(""))
            {
                MessageBox.Show("Please, Enter a valid Price");
                PriceLabel.BackColor = Color.FromArgb(200, 0, 0);
            }
            else {
                Product p = new Product() { ProductName = ProductName.Text, Category = CategoryChoice.Text, Price = Int32.Parse(Price.Text) };
                Product.AddProduct(p);
                this.Close();
            }
            
            // ListProductsForm lpf = new ListProductsForm();
        }

        private void AddProductForm_load(object sender, EventArgs e)
        {
            Console.WriteLine("Yes");
        }
    }
}
