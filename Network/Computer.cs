class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }

    public Computer(string ipAddress, int power, string operatingSystem)
    {
        IPAddress = ipAddress;
        Power = power;
        OperatingSystem = operatingSystem;
    }

    public override string ToString()
    {
        return $"{OperatingSystem} Computer {IPAddress} (Power: {Power})";
    }
}
