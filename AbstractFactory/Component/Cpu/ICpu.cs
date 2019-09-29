using AbstractFactory.Component;

namespace AbstractFactory
{
    public interface ICpu : IComponentBasicProperties
    {
        int CoreQty { get; }
        int Frequency { get; }
        int PerformanceFactor();
    }
}
