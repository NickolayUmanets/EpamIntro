namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Cucurbits: Vegetables
    {
        public static Vegetables Cucumber = new Vegetables()
        {
            Name = "Cucumber",
            proteins = 0.65,
            carbohydrates = 3.63,
            energy = 15,
            vitaminC = 2.8
        };
        public static Vegetables Pumpkin = new Vegetables() //тыква
        {
            Name = "Pumpkin",
            proteins = 1,
            carbohydrates = 4.4,
            energy = 22,
            vitaminC = 8
        };
        public static Vegetables Marrow = new Vegetables() //кабачок
        {
            Name = "Marrow",
            proteins = 0.6,
            carbohydrates = 4.6,
            energy = 24,
            vitaminC = 15
        };
        public static Vegetables CustardSquash = new Vegetables() //патиссон
        {
            Name = "Custard Sqush",
            proteins = 0.6,
            carbohydrates = 4.3,
            energy = 19.4,
            vitaminC = 23
        };

    }
}
