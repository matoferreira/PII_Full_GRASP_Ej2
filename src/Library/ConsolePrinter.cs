using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /* Para cumplir con el Principio de SRP, Recipe no puede ser la responsable de hacer el Print final, ya que si en un futuro debemos cambiar la forma en que se haga el Print,
        ejemplo: cambiando el output a un ticket, le estamos dando otra razón de cambio a Recipe y vulnerando el Principio de SRP. Dada esta razón creamos una clase que se encargue de 
        realizar el Print de la receta.*/
        public void PrintRecipe(Recipe texto)
        {
            texto.GetRecipeDetails();
        }
        
    }
}