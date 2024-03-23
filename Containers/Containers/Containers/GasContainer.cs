using Containers.Interfaces;

namespace Containers.Containers;

public class GasContainer:Container,IHazardNotifier
{
    public double GasPressure { get; set; }
    
    public GasContainer(double cargoWeight, int height, int weight, int depth, double maxCargoWeight,double gasPressure) : base(cargoWeight, height, weight, depth, maxCargoWeight)
    {
        GasPressure = gasPressure;
        SerialNumber = "KON-G-" + _ID;
    }
    public override string ToString()
    {
        return "CargoWeight:" + CargoWeight + " " +
               "Height:" + Height + " " +
               "Weight:" + Weight + " " +
               "Depth:" + Depth + "" +
               "MaxCargoWeight" + MaxCargoWeight + " " +
               "ID:" + _ID + "" +
               "Serial Number:" + SerialNumber + " " +
               "GasPressure:" + GasPressure;
    }
    public override void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }

    public void SendHazardNotification()
    {
        Console.WriteLine("A dangerous situation was about to occur in GasContainer nr:"+_ID);
    }
}