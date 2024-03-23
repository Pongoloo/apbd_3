// See https://aka.ms/new-console-template for more information

using Containers;
using Containers.Containers;
using Containers.Enums;
using Containers.Products;

Container container = new Container(0,50,25,20,1000.0);
Container lcontainer = new LiquidContainer(0,50,25,20,1000.0,TypeOfCargo.Dangerous);
Container gcontainer = new GasContainer(0,50,25,20,1000.0,30.0);
Container ccontainer = new CoolingContainer(0,50,25,20,1000.0,new Product("banana",13.7),15);

container.Load(50.0);
lcontainer.Load(50.0);
gcontainer.Load(50.0);
ccontainer.Load(50.0);
List<Container> list = new List<Container>() { lcontainer, gcontainer, ccontainer };
ContainerShip ship = new ContainerShip(80.0,20,70);
ship.AddContainerToShip(container);
ship.AddContainersToShip(list);

ship.DepartContainerFromShip(1);

container.Unload();

Container containerToAdd = new Container(0,50,25,20,1000.0);

ship.DepartContainerFromShip(2);
ship.AddContainerToShip(containerToAdd);

ContainerShip ship2 = new ContainerShip(50, 60, 70);
ship2.AddContainerToShip(ship.DepartContainerFromShip(3));

Console.WriteLine(lcontainer);
Console.WriteLine(ship);


