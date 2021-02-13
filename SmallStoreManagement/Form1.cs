using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallStoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Database db = new Database();
            Database.InitializeCustomers();
            Database.InitializeProducts();
            Database.InitializeCurrentUser();
            Database.InitializeCart();
            InitializeComponent();
            
        }

        private void buttonCustomersList_Click(object sender, EventArgs e)
        {
            if (Database.GetCurrentUser("Name").Equals("Admin"))
            {
                ListCustomersForm lcf = new ListCustomersForm();
                lcf.Show();
            }
            else { MessageBox.Show("You must be identified as Admin to enter this section. Log In first"); }


        }

        private void buttonProductsList_Click(object sender, EventArgs e)
        {
            if (Database.GetCurrentUser("Name").Equals("Admin"))
            {
                ListProductsForm lpf = new ListProductsForm();
                lpf.Show();
            }
            else { MessageBox.Show("You must be identified as Admin to enter this section. Log In first"); }
        }

        private void buttonCartsList_Click(object sender, EventArgs e)
        {
            if (Database.GetCurrentUser("Name").Equals("Admin"))
            {
                ListCartForm lcf = new ListCartForm();
                lcf.Show();
            }
            else { MessageBox.Show("You must be identified as Admin to enter this section. Log In first"); }
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            if (Database.GetCurrentUser("Name").Equals("Admin"))
            {
                AddProductForm apf = new AddProductForm();
                apf.Show();
            }
            else { MessageBox.Show("You must be identified as Admin to enter this section. Log In first"); }
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm apf = new AddCustomerForm();
            apf.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string currentUsername = Database.GetCurrentUser("Name");
            if (currentUsername.Equals(""))
            {
                CustomerLoginForm clf = new CustomerLoginForm(this);
                clf.Show();
            }
            else
            {
                Database.ClearSession();
                HomeLoginButton.Text = "Log In";
            }
        }

        private void Form1_load(object sender, EventArgs e)
        {
            string currentUsername = Database.GetCurrentUser("Name");
            if (currentUsername.Equals(""))
            {
                HomeLoginButton.Text = "Log In";
            }
            else
            {
                HomeLoginButton.Text = "You are identified as \n" + currentUsername + "\n Click here to logout";
            }
        }
    }
}
