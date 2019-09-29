using AbstractFactory.Component;

namespace AbstractFactory
{
    public interface IRam : IComponentBasicProperties
    {
        int SizeMb { get; }
        int Frequency { get; }
        int PerformanceFactor();
    }
}
