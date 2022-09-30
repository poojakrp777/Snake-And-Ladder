using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int StartPosition = 0;
            int ran = 0;
            Random random = new Random(); //Random function can generate random number
            ran = random.Next(1, 7);//Considering range from 1 to 6 i.e below 7
            Console.WriteLine("Rolled Dice");
            Console.WriteLine("Number got: " + ran);
            Console.WriteLine("Starting Position of Player 1 is :" + StartPosition);
            Console.ReadLine();
        }
    }
}
