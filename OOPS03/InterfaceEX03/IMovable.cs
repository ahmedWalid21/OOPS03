using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX03
{
    internal interface IMovable
    {
        int Speed { get; set; }
        void forward();
        void backward();
        void left();
        void right();

    }
}
