using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerFactory laptopFactory = new LaptopFactory();
            IComputerFactory desctopFactory = new DesctopFactory();

            List<IСomputer> сomputers = new List<IСomputer>()
            {
                new Сomputer(laptopFactory),
                new Сomputer(desctopFactory)
            };

            foreach (var сomputer in сomputers)
            {
                сomputer.GetPartsInfo();
                Console.WriteLine(new String('-',40));
            }

            Console.ReadLine();
        }
    }
}
