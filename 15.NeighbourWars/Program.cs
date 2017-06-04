using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPointsPesho = 100;
            int healthPointsGosho = 100;

            int cnt = 0;

            while (true)
            {
                cnt++;

                if (cnt % 2 == 1)
                {
                    healthPointsGosho -= damagePesho;

                    if (healthPointsGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", cnt);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthPointsGosho);
                    }
                }



                if (cnt % 2 == 0)
                {
                    healthPointsPesho -= damageGosho;

                    if (healthPointsPesho <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", cnt);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPointsPesho);
                    }
                }
                if (cnt % 3 == 0)
                {
                    healthPointsPesho += 10;
                    healthPointsGosho += 10;
                }
            }
        }
    }
}
