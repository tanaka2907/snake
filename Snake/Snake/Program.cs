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
            Point p1 = new Point(3,5,'#');
            p1.Draw();

            Point p2 = new Point(1,6,'*');
            p2.Draw();

            Point p3 = new Point(7, 6, '*');
            Point p4 = new Point(9, 10, '*');

            HorizontalLine hl = new HorizontalLine(4, 7, 3, '@');
            hl.Draw();

            VertikalLine v1 = new VertikalLine(6, 10, 7, '$');
            v1.Draw();

            Console.ReadLine();
        }

       
    }
}
