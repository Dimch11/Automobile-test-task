using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Automobile> automobiles = new List<Automobile>()
        {
            new SportCar(1, 10, 5, 100),
            new PassengerCar(1, 10, 5, 100, 8, 4),
            new Truck(1, 10, 5, 100, 5000, 4000)
        };

        foreach (var automobile in automobiles)
        {
            automobile.DisplayCurrentFuelRange();
        }
    }
}