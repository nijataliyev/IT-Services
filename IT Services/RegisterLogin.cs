using IT_Services.FakeDB;
using IT_Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Services
{
    public partial class RegisterLogin : Form
    {
        public RegisterLogin()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterUser user = new RegisterUser(txbx_name.Text, 
                                                txbx_surname.Text, 
                                                txbx_email.Text, 
                                                txbx_password.Text, 
                                                txbx_confirm_password.Text);
            MyDB.users.Add(user);
            txbx_name.Text = "";
            txbx_surname.Text = "";
            txbx_email.Text = "";
            txbx_password.Text = "";
            txbx_confirm_password.Text = "";
        }

        private void btn_cart_register_Click(object sender, EventArgs e)
        {
            CartRegisterUser user = new CartRegisterUser(txbx_cart_register_number.Text,
                                                        txbx_cart_register_email.Text,
                                                        txbx_cart_register_password.Text,
                                                        txbx_cart_register_confirm_password.Text);

            foreach (Carts cart in MyDB.cartsNumber)
            {
                if (txbx_cart_register_number.Text == cart.CartNumber)
                {
                    MyDB.users.Add(user);
                }
                else
                {
                    MessageBox.Show("Cart Nomresi Yalnishdir");
                }
            }
            
            txbx_cart_register_number.Text = "";
            txbx_cart_register_email.Text = "";
            txbx_cart_register_password.Text = "";
            txbx_cart_register_confirm_password.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txbx_login_email.Text == "admin" && txbx_login_password.Text == "12345")
            {
                GenerateCarts generateCarts = new GenerateCarts();
                generateCarts.Show();
                //AdminPanel adminPanel = new AdminPanel();
                //adminPanel.Show();
            }
            else
            {
                foreach (Person user in MyDB.users)
                {
                    if (txbx_login_email.Text == user.Email && txbx_login_password.Text == user.Password)
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Melumatlarinizi Duzgun Daxil edin");
                    }
                }
            }
           
        }
    }
}
