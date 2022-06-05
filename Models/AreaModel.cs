using HB.MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.MarsRover.Models
{
    interface IArea
    {
        public bool CanGoForward(Location location, CordinatesEnum direction); 
    }

    public class Area : IArea
    {
        public bool CanGoForward(Location location, CordinatesEnum direction)
        {
            
            Location tLocation = new Location(location.X, location.Y);
            switch (direction)
            {
                case CordinatesEnum.NORT:
                    tLocation.Y += 1;
                    break;
                case CordinatesEnum.EAST:
                    tLocation.X += 1;
                    break;
                case CordinatesEnum.SOUTH:
                    tLocation.Y -= 1;
                    break;
                case CordinatesEnum.WEST:
                    tLocation.X -= 1;
                    break;
            }
            return MinWidth <= tLocation.X && tLocation.X <= Width && MinHeight <= tLocation.Y && tLocation.Y <= Height;
        } 
        public Area(int _Width, int _Height)
        { 
            Width = _Width;
            Height = _Height;
        }
          

        public int MinWidth { get; set; }

        public int MinHeight { get; set; }
        public int Width { get; set; }

        public int Height { get; set; } 
    }
}
