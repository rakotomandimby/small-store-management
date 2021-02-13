using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace SmallStoreManagement
{
    public partial class UserShoppingForm : Form
    {
        private ListView CartContent;
        public UserShoppingForm()
        {
            InitializeComponent();
        }


        private void UserShoppingForm_load(object sender, EventArgs e)
        {
            UsernameDisplay.Text = Database.GetCurrentUser("Name");
            List <Product> products = Product.GetAllProducts();
            listShoppingView.Items.Clear();
            foreach (Product p in products)
            {
                string[] row = new string[] { p.ProductName, p.Category, p.Price.ToString() };
                ListViewItem lvi = new ListViewItem(row) { Tag = p };
                listShoppingView.Items.Add(lvi);
            }
            List<Product> items = Cart.GetItemsOf(Int32.Parse(Database.GetCurrentUser("Id")));
            listCartView.Items.Clear();
            foreach (Product i in items)
            {
                string[] row1 = new string[] { i.ProductName, i.Category, i.Price.ToString() };
                ListViewItem lvi1 = new ListViewItem(row1) { Tag = i };
                listCartView.Items.Add(lvi1);
            }
        }

        private void listShoppingView_DoubleClick(object sender, EventArgs e)
        {
            //Check if there is an Already existing cart and prepend it
            
            

            Product selectedItem = (Product)listShoppingView.SelectedItems[0].Tag;
            // MessageBox.Show(listShoppingView.SelectedItems[0].SubItems[0].Text);
            string[] row2 = new string[] { 
                                selectedItem.ProductName, 
                                selectedItem.Category, 
                                selectedItem.Price.ToString() };
            ListViewItem lvi2 = new ListViewItem(row2) { Tag = selectedItem };
            listCartView.Items.Add(lvi2);
            CartContent = listCartView;
            // Update Total Price
        }

        private void SaveCartButton_Click(object sender, EventArgs e)
        {
            int currentUserId = Int32.Parse(Database.GetCurrentUser("Id"));
            Customer customer = new Customer(currentUserId);
            customer.AppendToCart(CartContent);
        }
    }
}
