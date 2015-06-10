using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

#region Вводное
//namespace multicast_delegates_examle
//{
//public delegate void SampleDelegate(); // 1. создаем простой делегат с простой сигнатурой
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SampleDelegate del = new SampleDelegate(SampleMethodOne); // 3. создаем экземпляр делегата и передаем ему в конструктор имя желаемого метода, на который указывает наш экземпляр делегата
//            del(); // 4. вызываем делегат del
//            Console.ReadKey();
//        }

//        public static void SampleMethodOne() // 2. создаем метод с сигнатурой как у делегата. static для того, чтобы не создавать экземпляр класса где вводим этот метод
//        {
//            Console.WriteLine("SampleMethodOne invoked");
//        }
//    }


//}
#endregion

#region шаг 1
//public delegate void SampleDelegate(); // 1. создаем простой делегат с простой сигнатурой
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SampleDelegate del1, del2, del3, del4; // 3. создаем экземпляр делегата и передаем ему в конструктор имя желаемого метода, на который указывает наш экземпляр делегата
//            del1 = new SampleDelegate(SampleMethodOne);
//            del2 = new SampleDelegate(SampleMethodTwo);
//            del3 = new SampleDelegate(SampleMethodThree);
//            del4 = del1 + del2 + del3;
//            del4();
//            Console.ReadKey();
//        }
//        public static void SampleMethodOne() // 2. создаем метод с сигнатурой как у делегата. static для того, чтобы не создавать экземпляр класса где вводим этот метод
//        {
//            Console.WriteLine("SampleMethodOne invoked");
//        }
//        public static void SampleMethodTwo() 
//        {
//            Console.WriteLine("SampleMethodTwo invoked");
//        }
//        public static void SampleMethodThree()
//        {
//            Console.WriteLine("SampleMethodThree invoked");
//        }
//    }
#endregion

#region шаг 2
//public delegate void SampleDelegate(); // 1. создаем простой делегат с простой сигнатурой
//class Program
//{
//    static void Main(string[] args)
//    {
//        SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        del += SampleMethodTwo;
//        del += SampleMethodThree;
//        del -= SampleMethodOne;
//        del();
//        Console.ReadKey();
//    }
//    public static void SampleMethodOne() // 2. создаем метод с сигнатурой как у делегата. static для того, чтобы не создавать экземпляр класса где вводим этот метод
//    {
//        Console.WriteLine("SampleMethodOne invoked");
//    }
//    public static void SampleMethodTwo()
//    {
//        Console.WriteLine("SampleMethodTwo invoked");
//    }
//    public static void SampleMethodThree()
//    {
//        Console.WriteLine("SampleMethodThree invoked");
//    }
//}
#endregion

#region шаг 3
//public delegate int SampleDelegate(); // 1. создаем простой делегат с простой сигнатурой
//class Program
//{
//    static void Main(string[] args)
//    {
//        SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        del += SampleMethodTwo;
//        int DelegateReturnValue = del();
//        Console.WriteLine(DelegateReturnValue); // вызывается последний метод в списке подписей делегата, т.е. SampleMethodTwo. все это в том случае, если делегат del является multicast и он возвращает не void
//        Console.ReadKey();
//    }
//    public static int SampleMethodOne() // 2. создаем метод с сигнатурой как у делегата. static для того, чтобы не создавать экземпляр класса где вводим этот метод
//    {
//        return 1;
//    }
//    public static int SampleMethodTwo()
//    {
//        return 2;
//    }
//}
#endregion

#region шаг 4
public delegate void SampleDelegate(out int Integer); // 1. создаем простой делегат с простой сигнатурой
class Program
{
    static void Main(string[] args)
    {
        SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;
        int DelegateoutputParameterValue = -1;
        del(out DelegateoutputParameterValue);
        Console.WriteLine(DelegateoutputParameterValue); // вызывается последний метод в списке подписей делегата, т.е. SampleMethodTwo. все это в том случае, если делегат del является multicast и он возвращает void, но содержит параметры
        Console.ReadKey();
    }
    public static void SampleMethodOne(out int Number) // 2. создаем метод с сигнатурой как у делегата. static для того, чтобы не создавать экземпляр класса где вводим этот метод
    {
        Number = 1;
    }
    public static void SampleMethodTwo(out int Number)
    {
        Number = 2;
    }
}
#endregion