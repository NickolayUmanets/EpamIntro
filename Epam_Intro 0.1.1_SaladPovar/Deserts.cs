namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Deserts: Vegetables
    {
        public static Vegetables Artichoke = new Vegetables() //артишок
        {
            Name = "Artichoke",
            proteins = 0.7,
            carbohydrates = 2.47,
            energy = 17,
            vitaminC = 2
        };
        public static Vegetables Rhubarb = new Vegetables() // ревень
        {
            Name = "Rhubarb",
            proteins = 0.8,
            carbohydrates = 4.54,
            energy = 88,
            vitaminC = 8
        };
        public static Vegetables Asparagus = new Vegetables() // спаржа
        {
            Name = "Asparagus",
            proteins = 1.9,
            carbohydrates = 3.1,
            energy = 21,
            vitaminC = 20
        };
    }
}
