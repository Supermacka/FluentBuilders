using ITHS_CC_Labb3;
using System;

//House house = new House(2, 2, "Benkes gränd 4", false, 0);

//HouseFB.HouseBuilder builder = new HouseFB.HouseBuilder();
//HouseFB.House house = builder
//    .SetNumberOfRooms(-2)
//    .Build();

HouseFB.House house = HouseFB.House.Builder
    .HasSwimmingPool(true)
    .SetStreetAddress("Wargs väg 14")
    .SetNumberOfParkingSpotsInGarage(1)
    .SetNumberOfWindows(10)
    .Build();

Console.WriteLine(house);

