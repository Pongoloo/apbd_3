using Containers.Exceptions;
using Containers.Interfaces;

namespace Containers.Containers;

public class Container:IContainer
{
    public double CargoWeight { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public double MaxCargoWeight { get; set; }
    public string SerialNumber { get; set; }
    public readonly int _ID;
    private static int _containerID=1;

    public Container(double cargoWeight, int height, int weight, int depth, double maxCargoWeight)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxCargoWeight = maxCargoWeight;
        _ID = _containerID;
        _containerID++;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public override string ToString()
    {
        return "CargoWeight:" + CargoWeight + " " +
               "Height:" + Height + " " +
               "Weight:" + Weight + " " +
               "Depth:" + Depth + "" +
               "MaxCargoWeight" + MaxCargoWeight + " " +
               "ID:" + _ID;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > MaxCargoWeight)
        {
            throw new OverFillException();
        }

        CargoWeight = cargoWeight;
    }
}