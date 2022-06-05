using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.MarsRover.Models
{
    

    public class Location
    {

        public Location()
        {

        }
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }
         

        public int X { get; set; }

        public int Y{get; set; }
    }
}
