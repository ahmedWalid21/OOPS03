using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS03.InterfaceEX02
{
    internal class Employee :ICloneable
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
       public double Salary {  get; set; }

        public object Clone()
        {
            return new Employee() { Id=this.Id, Name=this.Name, Age=this.Age, Salary=this.Salary};
        }

        public int CompareTo(object? obj)
        {
            Employee e=(Employee)obj;
            if (this.Age > e.Age) return 234;
            else if (this.Age < e.Age) return -23;
            else return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }


    }
}
