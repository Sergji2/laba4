class Network
{
    private List<Computer> devices;

    public Network(List<Computer> devices)
    {
        this.devices = devices;
    }

    public void ConnectDevices(IConnectable source, IConnectable destination)
    {
        Console.WriteLine($"Connecting {source} to {destination}");
        source.Connect(destination as Computer);
    }

    public void DisconnectDevices(IConnectable source, IConnectable destination)
    {
        Console.WriteLine($"Disconnecting {source} from {destination}");
        source.Disconnect(destination as Computer);
    }

    public void TransmitData(IConnectable source, IConnectable destination, string data)
    {
        Console.WriteLine($"Transmitting data from {source} to {destination}: {data}");
        source.TransmitData(source as Computer, destination as Computer, data);
    }
}