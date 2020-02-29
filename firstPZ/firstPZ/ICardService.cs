using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    delegate void isValid(Dictionary<cardManager, playerManager> a);
    interface ICardService
    {
      event isValid eventForTest;
    }
}
