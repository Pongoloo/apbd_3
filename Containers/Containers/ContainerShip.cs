using Containers.Containers;
using Containers.Exceptions;

namespace Containers;

public class ContainerShip
{
    public List<Container>? Containers { get; set; }
    public double Velocity { get; set; }
    public int MaxAmountOfContainers { get; set; }
    public double MaxWeightToTransport { get; set; }

    public override string ToString()
    {
        return "Velocity:" + Velocity + " " +
               "Max Amount of Containers To carry:" + MaxAmountOfContainers + " " +
               "MaxWeightToTransport:" + MaxWeightToTransport + " " +
               "Currently " + Containers.Count + " containers on board";
    }
    public ContainerShip(double velocity, int maxAmountOfContainers, double maxWeightToTransport)
    {
        Containers = new List<Container>();
        Velocity = velocity;
        MaxAmountOfContainers = maxAmountOfContainers;
        MaxWeightToTransport = maxWeightToTransport;
    }

    public void AddContainerToShip(Container container)
    {
        if (Containers.Count >= MaxAmountOfContainers)
        {
            Console.WriteLine("Too many containers on this ship already");
            return;
        }

        double weightSum = 0;
        for (int i = 0; i < Containers.Count; i++)
        {
            weightSum += Containers[i].CargoWeight;
            weightSum += Containers[i].Weight;
        }

        weightSum += container.Weight;
        weightSum += container.CargoWeight;
        if (weightSum >= MaxWeightToTransport * 1000)
        {
            Console.WriteLine("Too much weight on this ship already");
            return;
        }
        Containers.Add(container);
    }

    public Container DepartContainerFromShip(int containerID)
    {
        for (int i = 0; i < Containers.Count(); i++)
        {
            var container = Containers[i];
            if (container._ID == containerID)
            {
                Containers.RemoveAt(i);
                Console.WriteLine("departed container nr:"+containerID+" from the ship");
                return container;
            }
        }
        Console.WriteLine("No such container on the ship");
        throw new NoSuchContainerException();
    }

   

    public void AddContainersToShip(List<Container> containers)
    {
        if (Containers.Count+containers.Count >= MaxAmountOfContainers)
        {
            Console.WriteLine("Too many containers on this ship already");
            return;
        }

        double weightSum = 0;
        for (int i = 0; i < Containers.Count; i++)
        {
            weightSum += Containers[i].CargoWeight;
            weightSum += Containers[i].Weight;
        }

        for (int i = 0; i < containers.Count; i++)
        {
            weightSum += containers[i].CargoWeight;
            weightSum += containers[i].Weight;
        }
       
        if (weightSum >= MaxWeightToTransport * 1000)
        {
            Console.WriteLine("Too much weight on this ship already");
            return;
        }
        for (int i = 0; i < containers.Count; i++)
        {
            Containers.Add(containers[i]);
        }
    }
}