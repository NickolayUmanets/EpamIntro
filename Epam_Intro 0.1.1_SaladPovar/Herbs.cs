using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Herbs: Vegetables
    {
        public static Vegetables Dill = new Vegetables() //укроп
        {
            Name = "Dill",
            proteins = 2.5,
            carbohydrates = 6.3,
            energy = 40,
            vitaminC = 100
        };
        public static Vegetables Basil = new Vegetables() //базилик
        {
            Name = "Basil",
            proteins = 3.15,
            carbohydrates = 2.65,
            energy = 23,
            vitaminC = 18
        };
        public static Vegetables Estragon = new Vegetables() // эстрагон
        {
            Name = "Estragon",
            proteins = 1.5,
            carbohydrates = 5,
            energy = 24.8,
            vitaminC = 10
        };
        public static Vegetables Marjoram = new Vegetables() //майоран
        {
            Name = "Marjoram",
            proteins = 12.66,
            carbohydrates = 60.56,
            energy = 271,
            vitaminC = 51.4
        };
        public static Vegetables Savory = new Vegetables() //чабёр
        {
            Name = "Savory",
            proteins = 6.73,
            carbohydrates = 23,
            energy = 272,
            vitaminC = 50
        };
    }
}
