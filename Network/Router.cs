class Router : Computer, IConnectable
{
    public Router(string ipAddress, int power, string operatingSystem) : base(ipAddress, power, operatingSystem)
    {
    }

    public void Connect(Computer device)
    {
        Console.WriteLine($"{this} connected to {device}");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"{this} disconnected from {device}");
    }

    public void TransmitData(Computer source, Computer destination, string data)
    {
        Console.WriteLine($"{source} transmitted data to {destination}: {data}");
    }
}