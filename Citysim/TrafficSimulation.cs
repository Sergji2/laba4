class TrafficSimulation
{
    private Road road;
    private List<Vehicle> vehicles;

    public TrafficSimulation(Road road, List<Vehicle> vehicles)
    {
        this.road = road;
        this.vehicles = vehicles;
    }

    public void SimulateTraffic(int turns)
    {
        Random random = new Random();

        for (int turn = 1; turn <= turns; turn++)
        {
            Console.WriteLine($"\nTurn {turn}:");

            foreach (var vehicle in vehicles)
            {
                double adjustedSpeed = vehicle.Speed - road.TrafficLevel * 2;
                if (adjustedSpeed < 0)
                    adjustedSpeed = 0;

                vehicle.Speed = adjustedSpeed;

                vehicle.Move();

                if (random.Next(1, 11) <= road.TrafficLevel)
                    vehicle.Stop();

                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }
    }
}