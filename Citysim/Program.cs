using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        Road cityRoad = new Road(10, 2, 3);

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Car", 60, 1.5),
            new Vehicle("Truck", 40, 3),
            new Vehicle("Bus", 50, 2.5)
        };

        TrafficSimulation simulation = new TrafficSimulation(cityRoad, vehicles);
        simulation.SimulateTraffic(5);

    }
}
