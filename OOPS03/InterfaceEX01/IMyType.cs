using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX01
{
    internal interface IMyType
    {
        //what can write inside Interface:
        //signature of properties
        //signature of methods[Name, return type , parameter]
        //default implemeted methods[full implemented methods]

        //signature of methods[Name, return type , parameter]
        void Myfun();
        //signature of properties
        double Salary {  get; set; }
        //default implemeted methods[full implemented methods]
        void print()
        {
            Console.WriteLine("default implemeted methods[full implemented methods]");
        }
    }
}
