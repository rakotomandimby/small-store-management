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
    public partial class ListCartForm : Form
    {
        public ListCartForm()
        {
            InitializeComponent();
        }

        private void ListCartForm_load(object sender, EventArgs e)
        {
            List<Cart> carts = Cart.GetAllCarts();
            listCartFormView.Items.Clear();
            foreach (Cart c in carts)
            {
                string[] row = new string[] { c.ownerName, c.total.ToString() };
                ListViewItem lvi = new ListViewItem(row) { Tag = c };
                listCartFormView.Items.Add(lvi);
            }
        }

        private void listCartForm_DoubleClick(object sender, EventArgs e)
        {
            Cart selectedItem = (Cart)listCartFormView.SelectedItems[0].Tag;
            CartDetailForm cdf = new CartDetailForm(selectedItem.ownerId);
            cdf.Show();
        }
    }
}
