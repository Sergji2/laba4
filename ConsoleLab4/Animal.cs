class Animal : LivingOrganism, IReproducible, IPredator
{
    private string species;

    public Animal(string species, double energy, int age, double size) : base(energy, age, size)
    {
        this.species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{species} is reproducing.");
    }

    public void Hunt(List<LivingOrganism> organisms)
    {
        Console.WriteLine($"{species} is hunting for food.");

        foreach (var organism in organisms)
        {
            if (organism != this && organism is Animal)
            {
                ((Animal)organism).energy -= 10;
                Console.WriteLine($"{species} hunted {organism.GetType().Name}. Energy decreased.");
                break;
            }
        }
    }

    public override void SimulateTurn()
    {
        base.SimulateTurn();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Species: {species}");
    }
}