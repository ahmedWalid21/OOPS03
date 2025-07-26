using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX03
{
    internal class Car : IMovable
    {
        public int Speed { get ; set ; }

        public void backward()
        {
            Console.WriteLine("Car Imovable bacward");
        }

        public void forward()
        {
            Console.WriteLine("Car Imovable forward");

        }

        public void left()
        {
            Console.WriteLine("Car Imovable left");

        }

        public void right()
        {
            Console.WriteLine("Car Imovable right");

        }
    }
}
