using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallStoreManagement
{
    public partial class CartDetailForm : Form
    {
        private int OwnerId;
        public CartDetailForm()
        {
            InitializeComponent();
        }
        public CartDetailForm(int ownerId)
        {
            InitializeComponent();
            this.OwnerId = ownerId;
        }

        private void CartDetailForm_load(object sender, EventArgs e)
        {
            cartOwner.Text = new Customer(this.OwnerId).Fullname;
            List<Product> items = Cart.GetItemsOf(this.OwnerId);
            listCartDetailView.Items.Clear();
            foreach (Product i in items)
            {
                string[] row = new string[] {i.ProductName, i.Category, i.Price.ToString() };
                ListViewItem lvi = new ListViewItem(row) { Tag = i };
                listCartDetailView.Items.Add(lvi);
            }
        }

        private void CartDetailPaid_Click(object sender, EventArgs e)
        {
            Cart.PurgeCartOf(this.OwnerId);
            listCartDetailView.Items.Clear();
            Thread.Sleep(1000);
            this.Close();
        }
    }
}
