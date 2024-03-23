using Containers.Enums;
using Containers.Interfaces;

namespace Containers.Containers;

public class LiquidContainer:Container,IHazardNotifier
{
    private TypeOfCargo _typeOfCargo;
    public LiquidContainer(double cargoWeight, int height, int weight, int depth, double maxCargoWeight,TypeOfCargo typeOfCargo) : base(cargoWeight, height, weight, depth, maxCargoWeight)
    {
        _typeOfCargo = typeOfCargo;
        SerialNumber = "KON-L-" + _ID;
    }

    public override void Load(double cargoWeight)
    {
        if (_typeOfCargo == TypeOfCargo.Dangerous)
        {
            if (cargoWeight > MaxCargoWeight / 2)
            {
                SendHazardNotification();
            }
        }
        else
        {
            if (cargoWeight > MaxCargoWeight * 0.9)
            {
                SendHazardNotification();
            } 
        }
    }

    public void SendHazardNotification()
    {
        Console.WriteLine("A dangerous situation was about to occur in Container nr:"+_ID);
    }
}