namespace Epam_Intro_0._1._1_SaladPovar
{
    public interface IVegetable: IIngridients
    {
        double proteins { get; set; } //per 100 grams in grams
        
        double carbohydrates { get; set; } //per 100 grams in grams
        

        double energy { get; set; } //per 100 grams in KiloCalories


        double vitaminC { get; set; } //per 100 grams in grams
        
    }
}
