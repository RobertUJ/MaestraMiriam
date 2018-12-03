using System;

namespace TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla, resultado = 0;
            Console.WriteLine("Ejercicio 2: Tabla de multiplicar.");

            Console.WriteLine("Ingresa el número de la tabla que deseas obtener.");
            tabla = int.Parse(Console.ReadLine());
            Console.WriteLine("A continuación se mostrara la tabla del " + tabla.ToString() + ":" + Environment.NewLine);
            for (int i = 0; i <= 10; i++)
            {
                resultado = tabla * i;
                Console.WriteLine(tabla.ToString() + " x " + i.ToString() + " = " + resultado.ToString());
            }
            Console.WriteLine(Environment.NewLine + "Presiona una tecla para terminar el programa.");
            Console.ReadLine();
        }
    }
}
