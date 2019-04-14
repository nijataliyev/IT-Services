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
    public partial class GenerateCarts : Form
    {
        public GenerateCarts()
        {
            InitializeComponent();
        }
        Carts cart = new Carts();

        private void button1_Click(object sender, EventArgs e)
        {
            cart.GenerateCart();
            txbx_cartNumber.Text = cart.CartNumber;
            txbx_cartPrice.Text = cart.CartPrice;
        }

        private void btn_addCart_Click(object sender, EventArgs e)
        {
            
            MyDB.cartsNumber.Add(cart);
        }
    }
}
