namespace Epam_Intro_0._1._1_SaladPovar
{
    public abstract class Vegetables : Ingridients, IVegetable
    {

        public abstract double proteins { get; }

        public abstract double carbohydrates { get; }

        public abstract double energy { get; }

        public abstract double vitaminC { get; }
    }
}
