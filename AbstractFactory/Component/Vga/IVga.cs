using AbstractFactory.Component;

namespace AbstractFactory
{
    public interface IVga : IComponentBasicProperties
    {
        int CoreQty { get; }
        int Frequency { get; }
        int SizeMb { get; }
        int PerformanceFactor();
    }
}
