using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018Day6
{
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Id { get { return String.Format("{0}-{1}", X, Y); }  }

        public Coordinate()
        {

        }
        public Coordinate(string line)
        {
            var coords = line.Split(',');
            X = Convert.ToInt32(coords[0].Trim());
            Y = Convert.ToInt32(coords[1].Trim());
        }
        public int ManhattenDistance(Coordinate v2)
        {
            return Math.Abs(X - v2.X) + Math.Abs(Y - v2.Y);
        }
    }
}
