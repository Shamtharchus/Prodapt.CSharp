using System;
using Prodapt.CSharp.Library;

namespace Prodapt.Csharp.Day4
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Login obj = new Login();
            var result = obj.Validation("admin", "admin@123");
            Console.WriteLine(result ? "Valid User" : "Invalid User");
        }
    }
}
