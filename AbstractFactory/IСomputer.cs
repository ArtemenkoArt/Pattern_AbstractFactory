namespace AbstractFactory
{
    public interface IСomputer
    {
        ICpu Cpu { get; }
        IHdd Hdd { get; }
        IRam Ram { get; }
        IVga Vga { get; }

        void GetPartsInfo();
    }
}