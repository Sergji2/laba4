class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem(List<LivingOrganism> organisms)
    {
        this.organisms = organisms;
    }

    public void SimulateEcosystem(int turns)
    {
        for (int i = 1; i <= turns; i++)
        {
            Console.WriteLine($"\nTurn {i}:");

            foreach (var organism in organisms)
            {
                organism.DisplayInfo();

                if (organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }

                if (organism is IPredator)
                {
                    ((IPredator)organism).Hunt(organisms);
                }

                organism.SimulateTurn();

                Console.WriteLine();
            }
        }
    }
}