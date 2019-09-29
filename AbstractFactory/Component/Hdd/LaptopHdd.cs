namespace AbstractFactory.Component.Hdd
{
    public class LaptopHdd : IHdd
    {
        public int SizeMb { get; }
        public int RotationSpeed { get; }
        public string Name { get; }
        public decimal Price { get; }

        public LaptopHdd(int sizeMb, int rotationSpeed, string name, decimal price)
        {
            SizeMb = sizeMb;
            RotationSpeed = rotationSpeed;
            Name = name;
            Price = price;
        }

        public int PerformanceFactor() => SizeMb / 1024 * (RotationSpeed / 1000);
    }
}
