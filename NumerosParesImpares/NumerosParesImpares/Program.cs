using System;

namespace NumerosParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumero = new int();
            bool bolEsPar = true;
            string strMensaje = new string("");

            Console.WriteLine("Ejercicio 3: Números Pares e Impares.");

            do
            {
                Console.WriteLine(Environment.NewLine + "Ingresa un número entero a valuar, para saber si es par o impar.");

                intNumero = 0;
                if(int.TryParse(Console.ReadLine(), out intNumero) == false)
                {
                    Console.WriteLine("El dato ingresado es incorrecto, se asignara el número 0 ");
                }

                if (intNumero % 2 == 0)
                {
                    bolEsPar = true;
                    strMensaje = Environment.NewLine + "El número ingresado es: " + intNumero.ToString() + " y es numero par.";
                }
                else
                {
                    bolEsPar = false;
                    strMensaje = Environment.NewLine + "El número ingresado es: " + intNumero.ToString() + " y es numero impar.";
                    strMensaje += Environment.NewLine;
                    strMensaje += "El programa ha terminado.";
                }
                Console.WriteLine(strMensaje);
                Console.WriteLine("----------------------------------------------");

            } while (bolEsPar == true );

            Console.WriteLine(Environment.NewLine + "Presione una tecla para salir.");
            Console.ReadLine();
        }
    }
}
