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
    public partial class ListProductsForm : Form
    {
        public ListProductsForm()
        {
            InitializeComponent();
        }

        private void ListProductsForm_load(object sender, EventArgs e)
        {
            
            List<Product> products = Product.GetAllProducts();
            listProductsView.Items.Clear();
            foreach (Product p in products)
            {
                string[] row = new string[] { p.ProductName, p.Category, p.Price.ToString() };
                ListViewItem lvi = new ListViewItem(row){ Tag = p};
                listProductsView.Items.Add(lvi);
            }
        }
    }
}
