class Microorganism : LivingOrganism, IReproducible
{
    private string strain;

    public Microorganism(string strain, double energy, int age, double size) : base(energy, age, size)
    {
        this.strain = strain;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{strain} is reproducing.");
    }

    public override void SimulateTurn()
    {
        base.SimulateTurn();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Strain: {strain}");
    }
}