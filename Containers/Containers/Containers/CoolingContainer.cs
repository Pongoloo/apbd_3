using Containers.Enums;
using Containers.Exceptions;
using Containers.Products;

namespace Containers.Containers;

public class CoolingContainer:Container
{
    public Product Product { get;}
    public double Temperature { get; set; }
    
    public CoolingContainer(double cargoWeight, int height, int weight, int depth, double maxCargoWeight,Product product) : base(cargoWeight, height, weight, depth, maxCargoWeight)
    {
        Product = product;
        SerialNumber = "KON-C-" + _ID;
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