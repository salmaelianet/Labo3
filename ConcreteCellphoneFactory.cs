using System;
using System.Collections.Generic;
using System.Text;


namespace Labo3
{
    public class ConcreteCellphoneFactory:CellphoneFactory
    {
        public override ICellphone GetCellphone(string Cellphone)
        {
            switch (Cellphone)
            {
                case "Iphone":
                    return new Iphone();
                case "Samsung":
                    return new Samsung();
                case "Huawei":
                    return new Huawei();
                default:
                    throw new Exception(string.Format("Cellphone '{0}' cannot be created", Cellphone));
            }
        }
    }
}
