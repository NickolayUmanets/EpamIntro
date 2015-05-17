/*Разработать класс Item для представления некоторого товара с наименованием, ценой за единицу товара и количеством.
 * Реализовать необходимые поля, свойства для чтения/изменения значений полей и метод,
 * возвращающий в денежном выражении общую стоимость товара. Создать коллекцию ArrayList случайных объектов этого типа
 * с 100 000 элементами. Найти сумму всех стоимостей товаров.
 * 
Дополнительно. Сделать то же самое, но вместо класса создать структуру. Определить время выполнения программы в
 * обоих случаях. При наличии существенной разницы во времени выполнения объяснить ее с помощью инструмента ildasm.
*/

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Epam_Intro_0._0._2
{
    namespace TestItem
    {
        public class Item
        {
            private string name;
            private double price;
            private int quantity;

            public Item(string item_name)
            {
                name = item_name;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                }
            }
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = roundPrice(value);
                }
            }
            public int Quantity
            {
                get
                {
                    return quantity;
                }
                set
                {
                    quantity = value;
                }
            }
            private double roundPrice(double val)
            {
                return Math.Round(val, 2, MidpointRounding.AwayFromZero);
            }
            public double totalPrice()
            {
                double result = quantity * price;
                return roundPrice(result);
            }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {

                ArrayList itemList = new ArrayList();
                Random rnd = new Random();
                double totalPrice1 = 0.0;

                for (int i = 0; i < 99999; i++)
                {
                    Item item = new Item("item_" + i.ToString("00000"));
                    item.Quantity = rnd.Next(1000);
                    item.Price = NextDouble(rnd, 0.1, 1000.0);

                    totalPrice1 += item.totalPrice();

                    itemList.Add(item);
                }
                double totalPrice2 = 0.0;
                foreach (Item item in itemList)
                {
                    totalPrice2 += item.totalPrice();
                }
                Console.WriteLine("test");
                Console.WriteLine(Math.Round(totalPrice1, 2, MidpointRounding.AwayFromZero));
                Console.WriteLine(Math.Round(totalPrice2, 2, MidpointRounding.AwayFromZero));
                }


            private static double NextDouble(Random rng, double min, double max)
            {
                return min + (rng.NextDouble() * (max - min));
            }
            
        }        
    }
}
