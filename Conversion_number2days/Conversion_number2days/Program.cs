using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_number2days
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 1;
            Console.WriteLine("Please type number to covert: ");

            string time = Console.ReadLine();

            var = Convert.ToInt32(time);


            if (var >=1000)
            
            {
          
                int years = var / 365;
                var = var % 365;
                int months = var / 28;
                var = var % 28;
                int weeks = var / 7;
                int days = var % 7;
                Console.WriteLine("Converted to: " + years + " years " + months + " months " + weeks + " weeks " + days + " days");
                
            }
            else
            {
                Console.WriteLine("Enter a number >= 1000: ");
            }
            Console.ReadKey();
        }
    }
}
