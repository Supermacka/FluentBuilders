using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class House
    {
        public int NoOfRooms { get; set; } = 1;

        public int NoOfWindows { get; set; } = 0;

        /// <summary>This field includes the street name and the street number</summary>
        public string? StreetAdress { get; set; }

        public bool HasSwimmingPool { get; set; }

        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;


        public static HouseBuilder? Builder = new HouseBuilder();

        internal House() { 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{(!string.IsNullOrWhiteSpace(StreetAdress) ? $"This house is located at {StreetAdress}" : "Take a look at this beautiful house")}.");
            sb.AppendLine($"It has {NoOfRooms} {(NoOfRooms > 1 ? "rooms" : "room")} and {NoOfWindows} {(NoOfWindows == 1 ? "window" : "windows")}");
            if (HasSwimmingPool & HasGarage)
            {
                sb.Append($"It is very fancy and has both a swimming pool, and a garage with place for {ParkingSpotsInGarage} car");
                if (ParkingSpotsInGarage > 1)
                {
                    sb.Append("s");
                }
                sb.AppendLine(".");
            }
            else if (HasSwimmingPool)
            {
                sb.AppendLine("It has a nice swimming pool");
            }
            else if (HasGarage)
            {
                sb.AppendLine($"It has a garage with place for {ParkingSpotsInGarage} {(ParkingSpotsInGarage == 1 ? "car" : "cars")}");
            }
            return sb.ToString();
        }
    }
}
