﻿using System;

namespace CSharpProgramms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Name With Dot
            NameWithDot Name = new NameWithDot();
            Name.FullName = "Vangipurapu Venkata Sai Laxman";
            Name.ConvertName(Name.FullName);
            #endregion

            PrimeOrNot number = new PrimeOrNot();
            number.Number = 78;
            string PrimeOrNot = number.Prime(number.Number);
            Console.WriteLine(number.Number + PrimeOrNot);
            
        }
    }
}
