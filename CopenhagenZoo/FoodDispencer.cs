using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class FoodDispencer
    {
        public void FeedAnimals(int animals)//A method that feeds the animals
        {
            switch(animals)
            {
                case 1://If animals is 1 it feeds the zebras
                    Console.Clear();
                    Console.WriteLine("Fodre zebraene...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Succes!");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                case 2://if animals is 2 it feeds the hippos
                    Console.Clear();
                    Console.WriteLine("Fodre flodhestene...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Succes!");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                case 3://if animals is 3 it feeds the tigers
                    Console.Clear();
                    Console.WriteLine("Fodre tigerene...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Succes!");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;
                    
            }
        }
    }

}