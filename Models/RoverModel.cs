using HB.MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.MarsRover.Models
{
    interface IRover
    {
        public void LandRoverFirstLocation(int x, int y, CordinatesEnum _direction);
        public string WriteCurrentLocation();

        public bool RunLetter(string letter);



        public bool GoForward();

        public void TurnLeft();
        public void TurnRight();
    }

    public class Rover : IRover
    {

        public Rover()
        {

        }
        public Rover(Area _area, Location _location, CordinatesEnum _direction)
        {
            area = _area;
            location = _location;
            direction = _direction;
        }


        public Area area { get; set; }

        public Location location { get; set; }

        public CordinatesEnum direction { get; set; }



        public void LandRoverFirstLocation(int x, int y, CordinatesEnum _direction)
        {
            if (location == null)
                location = new Location(x, y);
            else
            {
                location.X = x;
                location.Y = y;
            }

            direction = _direction;
        }

        public string WriteCurrentLocation()
        {
            return location.X + " " + location.Y + " " + direction;
        }

        public bool RunLetter(string letter)
        {
            bool operationCanAvalible = true;
            for (int i = 0; i < letter.Length; i++)
            {
                if (operationCanAvalible)
                {
                    switch (letter[i])
                    {
                        case 'R':
                            TurnRight();
                            break;
                        case 'L':
                            TurnRight();
                            break;
                        case 'M':
                            operationCanAvalible = GoForward();
                            break;
                        default:
                            break;
                    }
                }
            }
            return operationCanAvalible;
        }



        public bool GoForward()
        {

            if (!area.CanGoForward(location, direction))
                return false;
            switch (direction)
            {
                case CordinatesEnum.NORT:
                    location.Y += 1;
                    break;
                case CordinatesEnum.EAST:
                    location.X += 1;
                    break;
                case CordinatesEnum.SOUTH:
                    location.Y -= 1;
                    break;
                case CordinatesEnum.WEST:
                    location.X -= 1;
                    break;
            }

            return true;
        }
        public void TurnLeft()
        {
            direction = ((int)direction - 1) < (int)CordinatesEnum.NORT ? CordinatesEnum.WEST : (CordinatesEnum)((int)direction - 1);
        }
        public void TurnRight()
        {
            direction = ((int)direction + 1) > (int)CordinatesEnum.WEST ? CordinatesEnum.NORT : (CordinatesEnum)((int)direction + 1);
        }
    }
}
