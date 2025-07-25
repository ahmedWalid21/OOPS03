using OOPS03.InterfaceEX01;

namespace OOPS03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Interface: Reference type
            // code contract between who developer write it and developer use it
            //can not create any object from interface

            //  MyType m=new MyType();
            // m.Salary = 120000;
            //Console.WriteLine(m.Salary);
            // m.Myfun();

            IMyType i;
            i = new MyType();
            i.Salary = 1234;
            Console.WriteLine(i.Salary);
            i.Myfun();
            i.print();








        }
    }
}
