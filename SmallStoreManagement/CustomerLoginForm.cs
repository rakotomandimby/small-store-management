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
    public partial class CustomerLoginForm : Form
    {
        private Form f1;
        public CustomerLoginForm()
        {
            InitializeComponent();
        }
        public CustomerLoginForm(Form f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // check password match
            if (Database.CheckCredentials(username.Text, userpassword.Text))
            {
                // write in Current_User
                Database.SetCurrentUser(username.Text);

                this.f1.Controls["HomeLoginButton"].Text = "You are identified as \n" + username.Text + "\n Click here to logout";
                this.Close();
                if (username.Equals("Admin")) {
                    ListCartForm lcf = new ListCartForm();
                    lcf.Show();
                } else
                {
                    UserShoppingForm usf = new UserShoppingForm();
                    usf.Show();
                }
            }
            else {
                MessageBox.Show("Bad Username or password, Try again");
            }

        }
    }
}
