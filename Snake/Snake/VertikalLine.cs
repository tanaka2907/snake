using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine : Figure
    {
        

        public VertikalLine(int topy, int downy, int x, char sim)
        {
            plist = new List<Point>();

            for (int y = topy; y <= downy; y++)
            {
                Point p = new Point(x, y, sim);

                plist.Add(p);

            }
        }

        
    }
}
