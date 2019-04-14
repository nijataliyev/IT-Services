using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Services.Models
{
    class RegisterUser:Person
    {
        public RegisterUser(string _name, string _surname, string _email, string _password, string _confirmPassword)
        {
            Name = _name;
            Surname = _surname;
            Email = _email;
            Password = _password;
            ConfirmPassword = _confirmPassword;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
