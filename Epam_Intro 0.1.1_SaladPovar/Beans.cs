using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Beans: Vegetables
    {
        public static Vegetables Pea = new Vegetables()
        {
            Name = "Pea",
            proteins = 5,
            carbohydrates = 8.3,
            energy = 55,
            vitaminC = 25
        };
        public static Vegetables Bean = new Vegetables()
        {
            Name = "Bean",
            proteins = 21,
            carbohydrates = 47,
            energy = 298,
            vitaminC = 0
        };       
    }
}
