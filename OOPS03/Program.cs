using OOPS03.InterfaceEX01;
using OOPS03.InterfaceEX02;
using OOPS03.InterfaceEX03;

namespace OOPS03
{
    internal class Program
    {
        //static void print10number(SeriesByTwo s)
        //{
        //    for(int i =0; i<10; i++)
        //    {
        //        Console.Write($"{s.Current} ");
        //        s.Next();
        //    }
        //    Console.WriteLine();
        //    s.Reset();

        //}
        //static void print10number(SeriesByThree s)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{s.Current} ");
        //        s.Next();
        //    }
        //    Console.WriteLine();
        //    s.Reset();

        //}
        static void print10number(ISeries s)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{s.Current} ");
                s.Next();
            }
            Console.WriteLine();
            s.Reset();

        }
        static void Main(string[] args)
        {

            //Interface: Reference type
            // code contract between who developer write it and developer use it
            //can not create any object from interface

            //  MyType m=new MyType();
            // m.Salary = 120000;
            //Console.WriteLine(m.Salary);
            // m.Myfun();

            //IMyType i;
            //i = new MyType();
            //i.Salary = 1234;
            //Console.WriteLine(i.Salary);
            //i.Myfun();
            //i.print();

            // SeriesByTwo s = new SeriesByTwo();
            // SeriesByThree t=new SeriesByThree();
            // print10number(t)


            //Employee[] e = new Employee[3]
            //{
            //    new Employee(){Id=1, Name="Ahmed", Age=23, Salary=12000},
            //    new Employee(){Id=2, Name="Ali", Age=33, Salary=11000},
            //    new Employee(){Id=3, Name="Omar", Age=43, Salary=13000}

            //};
            //Array.Sort(e);
            //foreach(Employee item in e)
            //{
            //    Console.WriteLine(item);   
            //}

            //Airplane a=new Airplane();
            //IMovable i = a;
            //i.forward();
            //IFlyable f = a;
            //f.forward();

            //Shallow copy and Deep copy

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"Arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");
            //arr2 = arr1;//Shallow copy
            //Console.WriteLine();
            //Console.WriteLine($"Arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");

            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]);

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"Arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");
            //arr2 =(int[] )arr1.Clone();//Deep copy
            //Console.WriteLine();
            //Console.WriteLine($"Arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");

            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]);

            Employee e = new Employee() { Id = 1, Name = "Ahmed", Age = 23, Salary = 12000 };
            Employee e2 = new Employee() { Id = 2, Name = "Ali", Age = 34, Salary = 11000 };
          
            //e2 = e;
            //Console.WriteLine(e.GetHashCode());
            //Console.WriteLine(e2.GetHashCode());
            //Console.WriteLine(e);
            //Console.WriteLine(e2);


            e2 = (Employee)e.Clone();
            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(e2.GetHashCode());
            Console.WriteLine(e);
            Console.WriteLine(e2);
        }
    }
}
