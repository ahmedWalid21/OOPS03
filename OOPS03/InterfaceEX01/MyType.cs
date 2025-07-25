using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX01
{
    internal class MyType : IMyType //implemention
    {
        public double Salary{ get; set; }

        public void Myfun()
        {
            Console.WriteLine("hello from class");
        }
    }
}
