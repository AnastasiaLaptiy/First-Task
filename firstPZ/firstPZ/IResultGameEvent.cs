using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    delegate void Display(string s);
    delegate void ColoredDisplay();
    interface IResultGameEvent
    {
        event Display eDisplay;
        event ColoredDisplay eColoredDisplay;
    }
}
