using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX03
{
    internal class Airplane : IFlyable , IMovable
    {
         int IFlyable. Speed { get ; set ; }
        int IMovable.Speed { get ; set; }

        void IFlyable.backward()
        {
            Console.WriteLine("Airplane Iflyable bacward");
       }

        void IMovable.backward()
        {
            Console.WriteLine("Airplane bacword imovable");
        }

        void IFlyable.forward()
        {
            Console.WriteLine("Airplane Iflyable forward");

        }

        void IMovable.forward()
        {
            Console.WriteLine("imovable forward Airplane");
        }

        void IFlyable.left()
        {
            Console.WriteLine("Airplane Iflyable left");

        }

        void IMovable.left()
        {
            Console.WriteLine("Airplane imovable left");        }

        void IMovable.right()
        {
            Console.WriteLine("Airplane imovable right");

        }

        void IFlyable.right()
        {
            Console.WriteLine("Airplane Iflyable right");
        }




    }
}
