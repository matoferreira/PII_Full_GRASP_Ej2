//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
/* Como Recipe es la única que conoce el producto final que se va a realizar, y a su vez, conoce cada paso que se realiza para la receta:
    Es la experta para imprimir que Receta estamos elaborando. Para cumplir con el Principio de SRP, Recipe solo cambiaría si cambia la receta final, no si cambian los pasos,
    es por esta razón que Steps se encarga de hacer el print de cada línea. */
        public void GetRecipeDetails()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                step.GetStepDetails();
            }
        }
    }
}