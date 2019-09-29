using AbstractFactory.Component;
using AbstractFactory.Component.Hdd;
using AbstractFactory.Component.Ram;
using AbstractFactory.Component.Vga;

namespace AbstractFactory.Factory
{
    public class LaptopFactory : IComputerFactory
    {
        public ICpu GetCpu()
        {
            return new LaptopCpu(2, 2500, "Intell Core i3 mobile", 250);
        }

        public IHdd GetHdd()
        {
            return new LaptopHdd(256000,5400,"WD Blue", 100.5m);
        }

        public IRam GetRam()
        {
            return new LaptopRam(4096,1333,"Samsung 4GB", 78.35m);
        }

        public IVga GetVga()
        {
            return new LaptopVga(10, 500, 512, "On board",0);
        }
    }
}
