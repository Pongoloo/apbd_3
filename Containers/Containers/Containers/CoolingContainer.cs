using Containers.Enums;
using Containers.Exceptions;
using Containers.Products;

namespace Containers.Containers;

public class CoolingContainer:Container
{
    public Product Product { get;}
    public double Temperature { get; set; }
    
    public CoolingContainer(double cargoWeight, int height, int weight, int depth, double maxCargoWeight,Product product,double temperature) : base(cargoWeight, height, weight, depth, maxCargoWeight)
    {
        Temperature = temperature;
        Product = product;
        SerialNumber = "KON-C-" + _ID;
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
               "Product:" + Product.Name + " ," + Product.Temperature + " " +
               "Temperature:" + Temperature;
    }
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        if (Temperature < Product.Temperature)
        {
            throw new UnsupportedCargoException("Temperature in the container is too small for that cargo");
        }
    }
}