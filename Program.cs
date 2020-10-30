using System;

namespace Labo3
{
    class Program
    {
        static void Main(string[] args)
        {
            CellphoneFactory factory = new ConcreteCellphoneFactory();
            ICellphone iphone = factory.GetCellphone("Iphone");
            iphone.TurnOn();
            ICellphone samsung = factory.GetCellphone("Samsung");
            samsung.TurnOn();
            ICellphone huawei = factory.GetCellphone("Huawei");
            huawei.TurnOn();

            Console.ReadKey();
        }
    }
}
