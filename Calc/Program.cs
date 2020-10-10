using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorLib.Calculator c = new CalculatorLib.Calculator();
            while (true)
            {
                c.Main();
            }
        }
    }
}
