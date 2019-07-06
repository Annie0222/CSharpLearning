using System;

namespace Oven
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven(100);
            oven.OverHeat += new Oven.OverHeatHandler((temp) => Console.WriteLine($"Warning! Oven is over heat. Current temperature is {temp}."));
            oven.OverHeat += new Oven.OverHeatHandler((temp) => {
                Console.WriteLine("Close oven when temperature is over 102.");
                if (temp > 102) oven.Close();
            });
            oven.Start();

            Console.ReadLine();
        }
    }
}
