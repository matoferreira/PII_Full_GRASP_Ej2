using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe texto)
        {
            texto.GetRecipeDetails();
        }
        
    }
}