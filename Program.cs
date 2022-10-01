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
            const int Ladder = 1;
            const int NoPlay = 2;
            const int Snake = 3;

            Random random = new Random();

            while (Position <= 100)
            {
                int DieRoll = random.Next(1, 7);
                Console.WriteLine($"Die Rolling : {DieRoll}");

                int options = random.Next(0, 3);

                switch (options)
                {
                    case Ladder:
                        Position += DieRoll;
                        break;
                    case Snake:
                        Position -= DieRoll;
                        break;
                    case NoPlay:
                        Console.WriteLine("Position " + Position);
                        break;
                }
            }
            Console.WriteLine("Position " + Position);
        }
    }
}
