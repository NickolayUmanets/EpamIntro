using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class BulbCrop: Vegetables
    {
        public static Vegetables Garlic = new Vegetables()
        {
            Name = "Garlic",
            proteins = 6.36,
            carbohydrates = 30.96,
            energy = 149,
            vitaminC = 31.2
        };
        public static Vegetables GreenOnion = new Vegetables()
        {
            Name = "Green Onion",
            proteins = 1.1,
            carbohydrates = 4.1,
            energy = 21,
            vitaminC = 48
        };
        public static Vegetables BulbOnion = new Vegetables()
        {
            Name = "Bulb Onion",
            proteins = 2.5,
            carbohydrates = 9.2,
            energy = 48,
            vitaminC = 8.4
        };
    }
}
