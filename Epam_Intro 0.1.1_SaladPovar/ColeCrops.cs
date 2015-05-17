using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class ColeCrops: Vegetables
    {
        public static Vegetables Broccoli = new Vegetables()
        {
            Name = "Broccoli",
            proteins = 2.8,
            carbohydrates = 6.6,
            energy = 34,
            vitaminC = 89.2
        };
        public static Vegetables WhiteCabbage = new Vegetables() //белокачаная капуста
        {
            Name = "White Cabbage",
            proteins = 1.5,
            carbohydrates = 5.2,
            energy = 27,
            vitaminC = 24
        };
        public static Vegetables Kohlrabi = new Vegetables()
        {
            Name = "Kohlrabi",
            proteins = 2.8,
            carbohydrates = 7.9,
            energy = 44,
            vitaminC = 50
        };
        public static Vegetables BrusselsSprout = new Vegetables()
        {
            Name = "Brussels Sprout",
            proteins = 3.4,
            carbohydrates = 5.2,
            energy = 43,
            vitaminC = 85
        };
        public static Vegetables CauliFlower = new Vegetables() //цветная капуста
        {
            Name = "Cauli Flower",
            proteins = 2.1,
            carbohydrates = 4.7,
            energy = 28,
            vitaminC = 42
        };
    }
}
