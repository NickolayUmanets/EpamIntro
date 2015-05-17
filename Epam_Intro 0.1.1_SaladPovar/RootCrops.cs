namespace Epam_Intro_0._1._1_SaladPovar
{
    public class RootCrops : Vegetables
    {
        public static Vegetables Beet = new Vegetables() //свёкла
        {
            Name = "Beet",
            proteins = 1.1,
            carbohydrates = 10.3,
            energy = 47,
            vitaminC = 8
        };
        public static Vegetables Carrot = new Vegetables() //морковь
        {
            Name = "Carrot",
            proteins = 1.3,
            carbohydrates = 7.6,
            energy = 36,
            vitaminC = 4
        };
        public static Vegetables Turnip = new Vegetables() //репа
        {
            Name = "Turnip",
            proteins = 1.5,
            carbohydrates = 6.2,
            energy = 32,
            vitaminC = 20
        };
        public static Vegetables Parsley = new Vegetables() //петрушка
        {
            Name = "Parsley",
            proteins = 3.7,
            carbohydrates = 7.6,
            energy = 49,
            vitaminC = 150
        };
        public static Vegetables Celery = new Vegetables() //сельдерей
        {
            Name = "Celery",
            proteins = 0.9,
            carbohydrates = 2.2,
            energy = 13,
            vitaminC = 38
        };
        public static Vegetables Radish = new Vegetables() //редька
        {
            Name = "Radish",
            proteins = 1.9,
            carbohydrates = 6.7,
            energy = 36,
            vitaminC = 29
        };
        public static Vegetables GardenRadish = new Vegetables() //редис
        {
            Name = "Garden Radish",
            proteins = 1.2,
            carbohydrates = 3.4,
            energy = 20,
            vitaminC = 25
        };
        public static Vegetables HorseRadish = new Vegetables() //хрен
        {
            Name = "Horse Radish",
            proteins = 1.2,
            carbohydrates = 8,
            energy = 48,
            vitaminC = 24.9
        };
    }
}
