using System;
using System.Collections.Generic;
using System.Text;


namespace Labo3
{
    public abstract class CellphoneFactory
    {
        public abstract ICellphone GetCellphone(string Cellphone);
    }
}
