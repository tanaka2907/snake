using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine
    {
        List<Point> plist;

        public VertikalLine(int topy, int downy, int x, char sim)
        {
            plist = new List<Point>();

            for (int y = topy; y <= downy; y++)
            {
                Point p = new Point(x, y, sim);

                plist.Add(p);

            }
        }

        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
