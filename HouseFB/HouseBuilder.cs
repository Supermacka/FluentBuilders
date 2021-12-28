using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class HouseBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder HasSwimmingPool(bool hasPool)
        {
            _house.HasSwimmingPool = hasPool;
            return this;
        }

        public HouseBuilder SetStreetAddress(string address)
        {
            _house.StreetAdress = address;
            return this;
        }

        public HouseBuilder SetNumberOfRooms(int noOfRooms)
        {
            if (noOfRooms <= 0)
            {
                throw new ArgumentOutOfRangeException("Can not set zero or negative number of rooms.");
            }

            _house.NoOfRooms = noOfRooms;
            return this;
        }

        public HouseBuilder SetNumberOfWindows(int noOfWindows)
        {
            if (noOfWindows < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set negative number of windows.");
            }

            _house.NoOfWindows = noOfWindows;
            return this;
        }

        public HouseBuilder SetNumberOfParkingSpotsInGarage(int noOfParkingSpotsInGarage)
        {
            if (noOfParkingSpotsInGarage < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set negative number of parking spots.");
            }

            _house.ParkingSpotsInGarage = noOfParkingSpotsInGarage;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }
}
