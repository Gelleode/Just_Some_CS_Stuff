using System;

class ic2EnergyLevels
{
    public static void PrintEnergyLevels()
    {
        ulong energy = 32, energyTier = 1;
        while (true)
        {
            string energyS;
            if (energy < 10000)
                energyS = energy.ToString();
            else if (energy < 1000000)
                energyS = (energy/1000D).ToString("####.#0") + "K";
            else if (energy < 1000000000)
                energyS = (energy/1000000D).ToString("####.#0") + "M";
            else if (energy < 1000000000000)
                energyS = (energy/1000000000D).ToString("####.#0") + "G";
            else if (energy < 1000000000000000)
                energyS = (energy/1000000000000D).ToString("####.#0") + "T";
            else if (energy < 1000000000000000000)
                energyS = (energy/1000000000000000D).ToString("####.#0") + "P";
            else if (energy < 10000000000000000000)
                energyS = (energy/1000000000000000000D).ToString("####.#0") + "E";
            else
                energyS = energy.ToString();
            Console.WriteLine($"Tier - {energyTier}, Energy - {energyS}");
            try
            {
                energy = checked(energy*4);
                energyTier++;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
                break;
            }
        }
    }
}
