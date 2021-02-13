using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallStoreManagement
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerAddButton_Click(object sender, EventArgs e)
        {
            
            string userpasswordHash = Utils.CreateMD5(NewCustomerPassword.Text);

            Customer c = new Customer()
            {
                Fullname = NewCustomerName.Text,
                Password = userpasswordHash,
                Address  = NewCustmomerAddress.Text,
                Discount = Int32.Parse(NewCustomerDiscount.Text)
            };
            Customer.AddCustomer(c);
            this.Close();
        }
    }
}
