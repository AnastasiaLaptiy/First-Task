using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    delegate void Point();
    delegate void Battle();
    interface ICardService
    {
        event Point Point;
        event Battle Battle;
    }
}
