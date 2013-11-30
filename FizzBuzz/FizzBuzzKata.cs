using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzKata: IFizzBuzzKata
    {
        public string Answer(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    return "fizzbuzz";
                }

                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }

            return number.ToString();
        }
    }
}
