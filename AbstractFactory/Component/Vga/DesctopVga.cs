namespace AbstractFactory.Component.Vga
{
    public class DesctopVga : IVga
    {
        public int CoreQty { get; }
        public int Frequency { get; }
        public int SizeMb { get; }
        public string Name { get; }
        public decimal Price { get; }

        public DesctopVga(int coreQty, int frequency, int sizeMb, string name, decimal price)
        {
            CoreQty = coreQty;
            Frequency = frequency;
            SizeMb = sizeMb;
            Name = name;
            Price = price;
        }

        public int PerformanceFactor() => SizeMb / 1024 * (CoreQty * (Frequency / 100));
    }
}
