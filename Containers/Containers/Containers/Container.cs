using Containers.Interfaces;

namespace Containers.Containers;

public class Container:IContainer
{
    public double CargoWeight { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; set; }
    private static int ContainerID=1;

    public Container(double cargoWeight, int height, int weight, int depth)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON-" + '?' + "-" + ContainerID;
        ContainerID++;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new NotImplementedException();
    }
}