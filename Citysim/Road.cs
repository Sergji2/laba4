class Road
{
    public double Length { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }

    public Road(double length, int lanes, int trafficLevel)
    {
        Length = length;
        Lanes = lanes;
        TrafficLevel = trafficLevel;
    }
}