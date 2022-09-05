using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenZoo
{
    internal class GUI
    {
        public void StartMenu()//method for the start menu
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------\r\n");
            Console.WriteLine("                                       København Zoo");
            Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Se liste over dyr");
            Console.WriteLine("2. Se liste over dyrepassere");
            Console.WriteLine("3. fodder et dyr");
            Console.WriteLine("4. Luk");
            Console.Write("Vælg en mulighed: ");
        }
        public void FoodMenu()//A method for the food menu
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------\r\n");
            Console.WriteLine("                                            Mad menu");
            Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Fodder zebraene");
            Console.WriteLine("2. Fodder flodhestene");
            Console.WriteLine("3. Fodder tigerene");
            Console.Write("Vælg en mulighed");
        }
    }
}