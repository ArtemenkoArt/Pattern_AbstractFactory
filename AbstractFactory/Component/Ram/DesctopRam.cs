namespace AbstractFactory.Component.Ram
{
    public class DesctopRam : IRam
    {
        public int SizeMb { get; }
        public int Frequency { get; }
        public string Name { get; }
        public decimal Price { get; }

        public DesctopRam(int sizeMb, int frequency, string name, decimal price)
        {
            SizeMb = sizeMb;
            Frequency = frequency;
            Name = name;
            Price = price;
        }

        public int PerformanceFactor() => SizeMb / 1024 * (Frequency / 100);
    }
}
