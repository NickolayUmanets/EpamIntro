//Разработать класс Triangle для представления треугольника со сторонами a, b, c. Инкапсулировать необходимые поля и снабдить класс
//свойствами для модификации сторон треугольника. Продумать и реализовать механизм валидации значений сторон треугольника, которые
//могут задаваться пользователем. Рассмотреть различные ситуации (например: создание нового или модификация уже существующего).
//Реализовать метод, определяющий вид треугольника (остроугольный, тупоугольный или прямоугольный). Вид треугольника реализовать
//с помощью перечислителя.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._0._3
{
    public class PrototypeTriangle
    {
        private double a;
        private double b;
        private double c;

        public PrototypeTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // private double minc = Math.Abs(a - b);
        // private double maxc = b + a;

        public double A
        {
            get { return a; }
            set { a = value >= 0 ? value : 0; } //if value >= 0 then a = value else a = 0
        }
        public double B
        {
            get { return b; }
            set { b = value >= 0 ? value : 0; }
        }

        public double C
        {
            get { return c; }
            set { c = value >= 0 ? value : 0; }
        }

        public bool isTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator true(PrototypeTriangle t)
        {
            return t.isTriangle;
        }
        public static bool operator false(PrototypeTriangle t)
        {
            return t.isTriangle;
        }

        public string TriangleType()
        {
            if (a*a == b*b + c*c || b*b == a*a+c*c || c*c == a*a+b*b)
            {
                return "rectangular";
            }
            else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            {
                return "obtuse-angled";
            }
            else
            {
                return "acute-angled";
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double c = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            PrototypeTriangle triangle1 = new PrototypeTriangle(a, b, c);
            if (triangle1)
            {
                Console.WriteLine("Triangle is OK");
                Console.WriteLine(triangle1.TriangleType());
            }
            else
            {
                Console.WriteLine("Triangle is not OK");
            }
             
            Console.ReadKey();
        }
    }
}
