interface IConnectable
{
    void Connect(Computer device);
    void Disconnect(Computer device);
    void TransmitData(Computer source, Computer destination, string data);
}