namespace Epam_Intro_0._1._1_SaladPovar
{
    public interface INotVegetable: IIngridients
    {
        double proteins { get; set; } //per 100 grams in grams
        double carbohydrates { get; set; } //per 100 grams in grams
        double fat { get; set; } // per 100 grams in grams
        double energy { get; set; } //per 100 grams in KiloCalories        
    }
}
