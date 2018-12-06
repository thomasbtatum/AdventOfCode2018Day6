using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018Day6
{
    internal class GridLocation: Coordinate
    {

        public Coordinate ClosestCoordinate { get; set; }
        public bool ClosestTied { get; set; }
        public bool IsCoordinate { get; set; }
        public int ClosestDistance { get; set; }

        public GridLocation(int x, int y)
        {
            X = x;
            Y = y;
            IsCoordinate = false;
            ClosestTied = false;
            ClosestDistance = Int32.MaxValue;
        }

        public void ProcessCoordinate(Coordinate c)
        {
            if (IsCoordinate) { return; }

            if((c.X == X) && (c.Y == Y))
            {
                ClosestCoordinate = c;
                IsCoordinate = true;
                ClosestDistance = 0;
                ClosestTied = false;

                return;
            }
            var distance = c.ManhattenDistance(this);
            if (distance == ClosestDistance)
            {
                ClosestTied = true;
                //ClosestCoordinate = null;
                return;
            }
            if (distance < ClosestDistance)
            {
                ClosestTied = false;
                ClosestDistance = distance;
                ClosestCoordinate = c;
                return;
            }

        }
    }
}
