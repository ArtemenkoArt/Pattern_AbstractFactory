using System;

namespace AbstractFactory
{
    public class Сomputer : IСomputer
    {
        public ICpu Cpu { get; }
        public IHdd Hdd { get; }
        public IRam Ram { get; }
        public IVga Vga { get; }

        public Сomputer(IComputerFactory factory)
        {
            Cpu = factory.GetCpu();
            Hdd = factory.GetHdd();
            Ram = factory.GetRam();
            Vga = factory.GetVga();
        }

        public void GetPartsInfo()
        {
            Console.WriteLine($"CPU: {Cpu.Name}");
            Console.WriteLine($"HDD: {Hdd.Name}");
            Console.WriteLine($"RAM: {Ram.Name}");
            Console.WriteLine($"VGA: {Vga.Name}");
            Console.WriteLine($"Performance factor: {Cpu.PerformanceFactor() + Hdd.PerformanceFactor() + Ram.PerformanceFactor() + Vga.PerformanceFactor()}");
        }
    }
}
