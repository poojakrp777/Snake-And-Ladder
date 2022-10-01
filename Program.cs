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
            int Position = 0;

            //Initializing Constants
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;

            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            Console.WriteLine($"Die Rolling : {DieRoll}");

            int options = random.Next(1, 4);

            switch (options)
            {
                case LADDER:
                    Position += DieRoll;
                    break;
                case SNAKE:
                    Position -= DieRoll;
                    break;
                case NOPLAY:
                    Console.WriteLine("Position " + Position);
                    break;
            }
            Console.WriteLine("Position " + Position);
        }
    }
}
