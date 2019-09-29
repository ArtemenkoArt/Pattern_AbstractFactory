using AbstractFactory.Component;
using AbstractFactory.Component.Hdd;
using AbstractFactory.Component.Ram;
using AbstractFactory.Component.Vga;

namespace AbstractFactory.Factory
{
    public class DesctopFactory : IComputerFactory
    {
        public ICpu GetCpu()
        {
            return new DesctopCpu(4, 3000, "Intell Core i5", 300);
        }

        public IHdd GetHdd()
        {
            return new DesctopHdd(512000,7200,"Seagate 7200", 130.75m);
        }

        public IRam GetRam()
        {
            return new DesctopRam(8192,1833,"GoodRam 8GB",105);
        }

        public IVga GetVga()
        {
            return new DesctopVga(256, 2333, 4096,"nVidia GT 1050", 350);
        }
    }
}
