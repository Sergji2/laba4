class Plant : LivingOrganism, IReproducible
{
    private string type;

    public Plant(string type, double energy, int age, double size) : base(energy, age, size)
    {
        this.type = type;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{type} is reproducing.");
    }

    public override void SimulateTurn()
    {
        base.SimulateTurn();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: {type}");
    }
}
