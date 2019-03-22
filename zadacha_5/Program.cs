using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5
{
    class MyClass
    {
        //private double x;
        //private double y;

        //public double X
        //{
        //    get => x;
        //    set => x = value;
        //}
        //public double Y
        //{
        //    get => y;
        //    set => y = value;
        //}
        //public MyClass(double x, double y)
        //{
        //  X = x;
        //  Y = y;
        //}
        public MyClass() { }
        public double Sum(double X, double Y)
        {
            return X + Y;
        }
        public double Sub(double X, double Y)
        {
            return X - Y;
        }
        public double Mult(double X, double Y)
        {
            return X * Y;
        }
        public double Div(double X, double Y)
        {
            return X / Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //    //Console.WriteLine("Сумма = " + OBJ.Sum() + ";");
            //    //Console.WriteLine("result = " + My_func(OBJ)  + ";");
            //    Console.WriteLine("Result = " + My_func(4,3) + ";");
            //    Console.ReadKey();
            //}

            //public static double My_func (double x, double y)
            //{
            //    MyClass obj = new MyClass();
            //    double a = obj.Mult(x, 5);
            //    double b = obj.Div(y, 2);
            //    double c = obj.Sum(a, b);
            //    double d = obj.Min(c, b);
            //    return d;
            //}
            MyClass obj = new MyClass();
            double x = 4;
            double y = 10;

            Console.WriteLine("Print result = " + obj.Sub(obj.Sum(x, obj.Mult(x, 5)), this.Div(y, 2)) + ";");
            
            Console.ReadKey();
        }
    }
}
