using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class CartRegisterUser:Person
    {
        public CartRegisterUser(string _cartNumber,string _email, string _password, string _confirmPassword)
        {
            CartNumber = _cartNumber;
            Email = _email;
            Password = _password;
            ConfirmPassword = _confirmPassword;

        }
        public string CartNumber { get; set; }
    }
}
