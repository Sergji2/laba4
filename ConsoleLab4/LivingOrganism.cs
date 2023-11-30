class LivingOrganism
{
    protected double energy;
    protected int age;
    protected double size;

    public LivingOrganism(double energy, int age, double size)
    {
        this.energy = energy;
        this.age = age;
        this.size = size;
    }

    public double Energy
    {
        get { return energy; }
    }

    public int Age
    {
        get { return age; }
    }

    public double Size
    {
        get { return size; }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Energy: {energy}, Age: {age}, Size: {size}");
    }

    public virtual void SimulateTurn()
    {
        age++;
        energy -= 5;
    }
}