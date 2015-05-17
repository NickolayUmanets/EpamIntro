using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Greens : Vegetables
    {
        public static Vegetables CabbageLettuce = new Vegetables()
        {
            Name = "Cabbage Lettuce",
            proteins = 0.9,
            carbohydrates = 1.8,
            energy = 14,
            vitaminC = 28
        };
        public static Vegetables LeafLettuce = new Vegetables()
        {
            Name = "Leaf Lettuce",
            proteins = 1.5,
            carbohydrates = 2,
            energy = 16,
            vitaminC = 15
        };    
    }
}
