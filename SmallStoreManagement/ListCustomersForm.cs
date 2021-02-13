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
    public partial class ListCustomersForm : Form
    {
        public ListCustomersForm()
        {
            InitializeComponent();
        }

        private void ListCustomersForm_load(object sender, EventArgs e)
        {
            List<Customer> customers = Customer.GetAllCustomers();
            listCustomersView.Items.Clear();
            foreach (Customer c in customers)
            {
                string[] row = new string[] { c.Fullname, c.Address, c.Discount.ToString() };
                ListViewItem lvi = new ListViewItem(row){Tag = c};
                listCustomersView.Items.Add(lvi);
            }
        }
        
    }
}
