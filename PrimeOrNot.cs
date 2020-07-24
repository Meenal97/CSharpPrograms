using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramms
{
    class PrimeOrNot
    {
        private int number;
        bool prime;

        public int Number
        {
            set
            {
                this.number = value;
            }
            get
            {
                return number;
            }
        }

        public string Prime(int number)
        {
            for(int i=2;i<number/2;i++)
            {
                if(number % i == 0)
                {
                    prime = true;
                    break;
                }
            }
            if(prime == true)
            {
                return " is not a prime number";
            }
            else
            {
                return " is a prime number";
            }

        }
        
    }
}
