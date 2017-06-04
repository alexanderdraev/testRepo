using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maximSum = int.Parse(Console.ReadLine());
            var totalCombinations = 0;
            var sum = 0;


            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var number = (i * j) * 3;
                    sum += number;
                    totalCombinations++;

                    if (sum >= maximSum)
                    {
                        Console.WriteLine("{0} combinations",
                            totalCombinations);
                        Console.WriteLine("Sum: {0} >= {1}",
                          sum, maximSum);

                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations"
                            , totalCombinations);
            Console.WriteLine("Sum: {0}",
              sum);
        }
    }
}
