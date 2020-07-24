using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramms
{
    class NameWithDot
    {
        private string name;

        public string FullName 
        {
            set
            {
                this.name = value;
            }

            get
            {
                return name;
            }
        }

        public void ConvertName(string name)
        {
            string[] arrayName = name.Split(" ");
            for(int i=0;i<arrayName.Length-1;i++)
            {
                char[] firstLetter = arrayName[i].ToCharArray();
                Console.Write(firstLetter[0] + ". ");
            }
            Console.WriteLine(arrayName[arrayName.Length-1]);
        }
    }
}
