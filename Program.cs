using System;

namespace CSharpProgramms
{
    class Program
    {
        static void Main(string[] args)
        {
            NameWithDot Name = new NameWithDot();
            Name.FullName = "Vangipurapu Venkata Sai Laxman";
            Name.ConvertName(Name.FullName);
        }
    }
}
