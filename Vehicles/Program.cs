﻿namespace Vehicles;

internal class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Drive();

        Sportscar mySportsCar = new Sportscar();
        mySportsCar.Drive();

        Van myVan = new Van();
        myVan.Drive();

        Minivan myMiniVan = new Minivan();
        myMiniVan.Drive();

        ExcursionVan myExcursionVan = new ExcursionVan();
        myExcursionVan.Drive();
    }
}
