using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0;


            if (person == "Athlete")
            {
                totalPrice = quantity * 0.7;
                Console.WriteLine("The {0} has to pay {1:f2}.",
                    person,totalPrice);
                
            }
            else if (person == "Businessman" || person == "Businesswoman")
            {
                totalPrice = quantity * 1.0;
                Console.WriteLine("The {0} has to pay {1:f2}.",
                    person, totalPrice);
            }
            else if (person == "SoftUni Student")
            {
                totalPrice = quantity * 1.70;
                Console.WriteLine("The {0} has to pay {1:f2}.",
                    person, totalPrice);
            }
            else
            {
                totalPrice = quantity * 1.2;
                Console.WriteLine("The {0} has to pay {1:f2}.",
                    person, totalPrice);
            }
        }
    }
}
