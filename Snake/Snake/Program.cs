using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 9;
            char sim1 = '#';

            Draw(x1, y1, sim1);


            Console.ReadLine();
        }

        static void Draw(int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}
