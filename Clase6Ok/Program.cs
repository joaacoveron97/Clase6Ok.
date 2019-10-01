using System;

namespace Clase6Ok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ObjetoRandom = new Random();
            int numero = 0;

            for (int i = 0; i < 10; i++) 
            {
                numero += ObjetoRandom.Next(1000); 
            }
            Console.WriteLine("El promedio de los diez numeros soretados es:  " + (numero / 10)); 
        }
    }
}

        
    

