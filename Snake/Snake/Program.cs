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
            

            HorizontalLine hl = new HorizontalLine(0, 79, 0, '.');
            hl.Draw();
            HorizontalLine h2 = new HorizontalLine(0, 79, 24, '.');
            h2.Draw();

            VertikalLine v1 = new VertikalLine(0, 24, 0, '.');
            v1.Draw();
            VertikalLine v2 = new VertikalLine(0, 24, 79, '.');
            v2.Draw();

            Console.ReadLine();
        }

     

    }
}
