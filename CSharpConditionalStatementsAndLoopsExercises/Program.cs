using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConditionalStatementsAndLoopsExercises
{
    class Program
    {
        static void Main(string[] args) // 01.Choose a drink
        {
            var person = Console.ReadLine().ToLower();

            if (person == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (person == "businessman"|| person =="businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (person == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else 
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
