using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Computer> devices = new List<Computer>
        {
            new Server("192.168.1.1", 1000, "Windows Server"),
            new Workstation("192.168.1.2", 500, "Windows 10"),
            new Router("192.168.1.3", 200, "RouterOS")
        };

        Network network = new Network(devices);

        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine($"\nTurn {turn}:");

            network.ConnectDevices(devices[0] as IConnectable, devices[1] as IConnectable);
            network.TransmitData(devices[0] as IConnectable, devices[1] as IConnectable, "Hello, World!");
            network.DisconnectDevices(devices[0] as IConnectable, devices[1] as IConnectable);

            Console.WriteLine();
        }
    }
}
