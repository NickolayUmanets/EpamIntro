using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Grains: Vegetables
    {
        public static Vegetables Maize = new Vegetables() //кукуруза
        {
            Name = "Maize",
            proteins = 3.5,
            carbohydrates = 15.6,
            energy = 101,
            vitaminC = 0
        };
    }
}
