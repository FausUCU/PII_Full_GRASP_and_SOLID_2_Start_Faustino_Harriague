 using System;

   namespace Full_GRASP_And_SOLID.Library
{
    /*Aqui cre una nueva clase llamada PrintConsole, a la que simplemente se le da como imput un string y lo escrive en la consola*/
   
    public class PrintConsole
    {
        public PrintConsole()
    
        {

        }

        public void PrinttoConsole(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}