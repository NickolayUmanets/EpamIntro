using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._1._1_SaladPovar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salad S1 = new Salad("qwe");
            //Salad S2 = new Salad("asd");
            //Salad S3 = new Salad("zxc");
            //Salad S4 = new Salad("rty");
            //Salad S5 = new Salad("dfg");

            Salad s = new Salad("test");
            s.AddIngridient(Beans.Pea, 150);
            s.AddIngridient(TuberCrops.Potato, 70);
            s.AddIngridient(TuberCrops.Batata, 30);
            s.AddIngridient(Tomatoes.Tomato, 80);
            s.AddIngridient(BulbCrop.Garlic, 25);
            s.AddIngridient(Deserts.Rhubarb, 20);
            foreach (string item in s.CaloriesRangeIngridients(20, 70))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(s.CompleteMass);
            Console.WriteLine(s.CalculateCalories());

            Salad s1 = new Salad("test 2");

            Console.ReadKey();
   

            //List<Salad> salads = new List<Salad>(0); //спросить о третьей перегрузке
            //salads.Add(S1);
            //salads.Add(S2);
            //salads.Add(S3);
            //salads.Add(S4);
            //salads.Add(S5);            
        }
    }
}
