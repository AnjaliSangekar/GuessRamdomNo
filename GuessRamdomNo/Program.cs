using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessRamdomNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = (new Random()).Next(10);
            Console.WriteLine("Random number: {0}", randomNumber);

            for (var i = 1; i <= 4; i++)
            {
                Console.Write("Guess the number between 1 and 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("Yow won");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("Yow lost");
                }
            }
            Console.ReadLine();

        }
    }

}
