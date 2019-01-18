using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public string ModelTank { get; set; }
        public int Ammunition { get; set; }
        public int Armor { get; set; }
        public int Maneuverability { get; set; }

        static private Random randomizer = new Random();

        public Tank(string modelTank)
        {
            ModelTank = modelTank;          
            Ammunition = randomizer.Next(0, 101);
            Armor = randomizer.Next(0, 101);
            Maneuverability = randomizer.Next(0, 101);
        }

        public static string operator *(Tank firstTank, Tank secondTank)
        {
            int pointsFirstTank = 0, pointsSecondTank = 0;

            if (firstTank.Armor > secondTank.Armor)
            {
                pointsFirstTank++;
            }

            if (secondTank.Armor > firstTank.Armor)
            {
                pointsSecondTank++;
            }

            if (firstTank.Ammunition > secondTank.Ammunition)
            {
                pointsFirstTank++;
            }

            if (secondTank.Ammunition > firstTank.Ammunition)
            {
                pointsSecondTank++;
            }

            if (firstTank.Maneuverability > secondTank.Maneuverability)
            {
                pointsFirstTank++;
            }

            if (secondTank.Maneuverability > firstTank.Maneuverability)
            {
                pointsSecondTank++;
            }

            if (pointsFirstTank - pointsSecondTank >= 1)
            {
                return "Победил " + firstTank.ModelTank;
            }
            else if (pointsSecondTank - pointsFirstTank >= 1)
            {
                return "Победил " + secondTank.ModelTank;
            }
            else
            {
                return "Ничья";
            }
        }

        public string GetTankParameters()
        {
            return "Модель танка: " + ModelTank + "\nУровень боекомплекта: " + Ammunition + "%\nУровень брони: " + Armor + "%\nУровень маневренности: " + Maneuverability + "%\n";
        }    
    }
}
