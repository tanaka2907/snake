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
            Point p1 = new Point();

            p1.x = 2;
            p1.y = 8;
            p1.sim = '*';

            p1.Draw();

            Point p2 = new Point();

            p2.x = 5;
            p2.y = 9;
            p2.sim = '#';

            p2.Draw();

            Console.ReadLine();
        }

       
    }
}
