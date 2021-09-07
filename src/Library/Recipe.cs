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
        /*Elimine La funcion de imprimir line de la clase receta, cre una clase que imprima consola en su 
        propia clase (PrintConsole.cs) que simplemente imprime un string que se le de.
        Mantuve en la clase Recepie la funcion de generar el texto a imprmir ya que toda la informacion que deve ser impresa
        se obtiene de esta clase.
        */
        public String PrintRecipe()
        {
            String texto="";
           texto=($"Receta de {this.FinalProduct.Description}:");
           foreach (Step step in this.steps)
            {
                texto+=($"\n{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            return texto;
        }
    }
   
    
    
}