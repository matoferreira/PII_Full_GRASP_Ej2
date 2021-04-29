//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }


/* Como Step es el expert de la información sobre como se compone cada paso, dado que conoce las cantidades de productos, el equipo que se utiliza y por cuanto tiempo:
    Creemos que es la clase que debe tener la responsabilidad de hacer el Print de cada paso que se realiza. Para cumplir con el principio de SRP, Step es el que 
    imprime cada paso, ya que si cambia de alguna manera como se compone cada paso, no afecta ni a Recipe ni a ConsolePrinter*/
        public void GetStepDetails()
        {
            Console.WriteLine($"{this.Quantity} de {Input.Description} usando {Equipment.Description} por {this.Time} horas");
        }
    }
    
}