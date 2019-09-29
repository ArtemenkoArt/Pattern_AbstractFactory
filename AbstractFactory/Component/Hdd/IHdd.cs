using AbstractFactory.Component;

namespace AbstractFactory
{
    public interface IHdd : IComponentBasicProperties
    {
        int SizeMb { get; }
        int RotationSpeed { get; }
        int PerformanceFactor();
    }
}
