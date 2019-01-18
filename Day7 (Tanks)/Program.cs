using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityTanksInArmy = 5;

            Tank[] firstTanksArmy = new Tank[quantityTanksInArmy];
            Tank[] secondTanksArmy = new Tank[quantityTanksInArmy];

            for (int i = 0; i < quantityTanksInArmy; i++)
            {
                firstTanksArmy[i] = new Tank("T-34");
                secondTanksArmy[i] = new Tank("Pantera");
            }

            int index = 0;

            try
            {
                while (true)
                {
                    Console.WriteLine(firstTanksArmy[index].GetTankParameters() + "\n");

                    Console.WriteLine(secondTanksArmy[index].GetTankParameters() + "\n");

                    Console.WriteLine(firstTanksArmy[index] * secondTanksArmy[index]);

                    index++;

                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Конец битвы");
                Console.ReadLine();
            }
        }
    }
}
