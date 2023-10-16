using System;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        private string tankName;
        private int ammoLevel;
        private int armorLevel;
        private int maneuverabilityLevel;
        private Random random;

        public Tank(string name)
        {
            random = new Random();
            tankName = name;
            ammoLevel = random.Next(101);
            armorLevel = random.Next(101);
            maneuverabilityLevel = random.Next(101);
        }

        // Implement operator overloads (^) for tank battles.
        public static bool operator >(Tank tank1, Tank tank2)
        {
            int parametersBetterInTank1 = 0;

            if (tank1.ammoLevel > tank2.ammoLevel)
                parametersBetterInTank1++;
            if (tank1.armorLevel > tank2.armorLevel)
                parametersBetterInTank1++;
            if (tank1.maneuverabilityLevel > tank2.maneuverabilityLevel)
                parametersBetterInTank1++;

            return parametersBetterInTank1 >= 2;
        }

        public static bool operator <(Tank tank1, Tank tank2)
        {
            return tank2 > tank1;
        }

        public string GetTankParameters()
        {
            return $"Tank: {tankName}, Ammo: {ammoLevel}%, Armor: {armorLevel}%, Maneuverability: {maneuverabilityLevel}%";
        }
    }
}
