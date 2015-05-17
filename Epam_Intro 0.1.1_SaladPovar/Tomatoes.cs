using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Tomatoes: Vegetables
    {
        public static Vegetables Tomato = new Vegetables() //томат, помидор
        {
            Name = "Tomato",
            proteins = 0.5,
            carbohydrates = 4,
            energy = 18,
            vitaminC = 34
        };
        public static Vegetables Paprica = new Vegetables() //перец сладкий
        {
            Name = "Paprica",
            proteins = 1.3,
            carbohydrates = 4.9,
            energy = 26,
            vitaminC = 200
        };
        public static Vegetables Squash = new Vegetables() //баклажан
        {
            Name = "Squash",
            proteins = 1.2,
            carbohydrates = 4.5,
            energy = 24,
            vitaminC = 5
        };
    }
}
