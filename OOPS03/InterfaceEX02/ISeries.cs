using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX02
{
    internal interface ISeries
    {
        int Current { get; set; }
        void Next();
        void Reset();



    }
}
