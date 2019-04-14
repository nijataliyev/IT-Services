using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IT_Services.Models
{
    class Carts
    {
        public Carts()
        {
            CartNumber = RandomCart();
            CartPrice = RandomPrice();
        }
        public string CartNumber { get; set; }
        public string CartPrice { get; set; }

        private string RandomCart()
        {
            int value = 0;
            string result = null;
            
            for (int i = 0; i < 3; i++)
            {
                Random randomNumber = new Random();
                value = randomNumber.Next(1000,9999);
                result += value.ToString();
            }
            
            return result;
        }
        private string RandomPrice()
        {
            Random randomPrice = new Random();
            string resultPrice = null;
            for (int i = 0; i < 9999; i++)
            {
                int a = randomPrice.Next(10, 60);
                if (a == 10 || a == 15 || a == 25 || a == 50)
                {
                    resultPrice += a.ToString();
                    break;
                }
            }
            return resultPrice;
        }

        public void GenerateCart()
        {
            RandomCart();
            RandomPrice();
            
        }
        
    }
}
