using System;

namespace Promedio5Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float acumulador = new float(); 
            float valor = new float();

            Console.WriteLine("Ejercicio No.1: Promedio de 5 números." + Environment.NewLine);
            Console.WriteLine("Promedio de 5 numeros" + Environment.NewLine +  "Ingresa el valor de cada numero al solictarlo." + Environment.NewLine);

            for(int cont = 1; cont <= 5; cont++)
            {
                valor = 0;
                Console.WriteLine("Ingresa el valor del numero " + cont.ToString() + ":");
                if(! float.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("El valor ingresado es invalido, se asignara un valor nulo al número: " + cont.ToString());
                }
                acumulador += valor;
            }

            Console.WriteLine(Environment.NewLine + "La suma total de los numeros ingresados es: " + acumulador.ToString());
            Console.WriteLine("El promedio de la suma de los 5 números es: " + (acumulador / 5).ToString() + Environment.NewLine);
            Console.WriteLine("Presiona una tecla para finalizar el programa.");
            Console.ReadKey();
        }
    }
}
