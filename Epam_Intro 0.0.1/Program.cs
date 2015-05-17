//Разработать класс LinearFunction инкапсулирующий два поля данных – параметры a и b линейной функции y=ax+b.
//Реализовать для полей данных необходимые свойства и метод,
//возвращающий значение функции по заданному значению x.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epam_Intro_0._0._1
{
    public class LinearFunction
    {
        public int a, b, x, y;
        public int Calculate(int y) { return y = a * x + b; }
    }
    public class LinearFunction2
    {
        private int a;
        private int b;
        private int x;
        private int y;

        public int A
        {
            get
            {
                //Console.WriteLine("\"a\" is set to ");
                return a;
            }
            set { a = value; }
        }
        public int B
        {
            get
            {
                //Console.WriteLine("\"b\" is set to ");
                return b;
            }
            set { b = value; }
        }
        public int X
        {
            get
            {
                //Console.WriteLine("\"x\" is set to ");
                return x;
            }
            set { x = value; }
        }

        public int Y(int x)
        {
            return y= A * X + B;
        }
        //public int Y
        //{
        //    get { return y = a * x + b; }
        //    set { y = A * X + B; }
        //}

        //    public int Calculate()
        //    {
        //        return y = A * X + B;
        //    }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //LinearFunction Y1 = new LinearFunction();
            //Console.WriteLine("Enter a");
            //Y1.a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter b");
            //Y1.b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter x");
            //Y1.x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("y is");
            //Console.WriteLine(Y1.y = Y1.Calculate(Y1.y));
            //Console.ReadKey();

            LinearFunction2 Y2 = new LinearFunction2();
            Console.WriteLine("Enter a");
            Y2.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Y2.A);
            Console.WriteLine("Enter b");
            Y2.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Y2.B);
            Console.WriteLine("Enter x");
            Y2.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Y2.X);
            //Console.WriteLine("y is " + Y2.Y);
            Console.WriteLine("y is {0}", Y2.Y(Y2.X));
            

            Console.WriteLine("Enter x");
            Y2.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y is {0}", Y2.Y(Y2.X));
            Console.ReadKey();


        }
    }
}
