using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<LivingOrganism> organisms = new List<LivingOrganism>
        {
            new Animal("Lion", 80, 5, 1.5),
            new Animal("Deer", 60, 3, 1.2),
            new Plant("Oak", 40, 10, 0.8),
            new Microorganism("Bacteria", 20, 1, 0.1)
        };

        Ecosystem ecosystem = new Ecosystem(organisms);
        ecosystem.SimulateEcosystem(5);

    }
}
