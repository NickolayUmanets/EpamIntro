using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam_Intro_0._1._1_SaladPovar
{
    public class Beans: Vegetables
    {
        public override string Name
        {
            get
            {
                return "Bean";
            }
        }

        public override double carbohydrates
        {
            get 
            {
                return 0;
            }
        }       

        public void Test()
        {

        }
    }
}
