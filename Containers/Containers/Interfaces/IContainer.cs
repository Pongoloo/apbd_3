namespace Containers.Interfaces;

public interface IContainer
{
    void Unload();
    void Load(double cargoWeight);
}