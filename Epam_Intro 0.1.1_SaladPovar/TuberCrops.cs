namespace Epam_Intro_0._1._1_SaladPovar
{
    public class TuberCrops : Vegetables
    {
        public static Vegetables Potato = new Vegetables //картофель
        {
            Name = "Potato",
            proteins = 1.9,
            carbohydrates = 16.6,
            energy = 73,
            vitaminC = 11
        };

        public static Vegetables Batata = new Vegetables //батат
        {
            Name = "Batata",
            proteins = 1.6,
            carbohydrates = 20.1,
            energy = 86,
            vitaminC = 2.4
        };
    }

}
