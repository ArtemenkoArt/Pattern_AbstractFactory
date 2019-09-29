namespace AbstractFactory.Component
{
    public class DesctopCpu : ICpu
    {
        public int CoreQty { get; }
        public int Frequency { get; }
        public string Name { get; }
        public decimal Price { get; }

        public DesctopCpu(int coreQty, int frequency, string name, decimal price)
        {
            CoreQty = coreQty;
            Frequency = frequency;
            Name = name;
            Price = price;
        }

        public int PerformanceFactor() => CoreQty * (Frequency / 100);
    }
}
