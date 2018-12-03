using System;

namespace Divisas
{
    class Program
    {
        static void Main(string[] args)
        {
            int intOperacion = new int();
            double dblMontoMonedaNacional = new double();
            double dblMontoMonedaAmericana = new double();
            double dblValorDolarVenta = new double();
            double dblValorDolarCompra = new double();

            Console.WriteLine("Ejercicio No. 5: Casa de cambio." + Environment.NewLine);


            Console.WriteLine("Buen día, bienvenido al sistema de divisas." + Environment.NewLine);
            
            Console.WriteLine("Ingrese el valor del dolar venta.");
            while (double.TryParse(Console.ReadLine(), out dblValorDolarVenta) == false)
            {
                Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo.");
            }

            Console.WriteLine();

            Console.WriteLine("Ingrese el valor del dolar compra.");
            while (double.TryParse(Console.ReadLine(), out dblValorDolarCompra) == false)
            {
                Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo.");
            }


            do
            {
                Console.WriteLine("Seleccione la transacción que desea realizar: " + Environment.NewLine);
                Console.WriteLine("Presione: 1 para Venta de Dolares.");
                Console.WriteLine("Presione: 2 para compra de dolares");
                Console.WriteLine("Presione: 3 para salir del programa.");

                if(int.TryParse(Console.ReadLine(), out intOperacion) == false || ! (intOperacion >= 1 && intOperacion <= 3))
                {
                    Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo." + Environment.NewLine);
                    Console.WriteLine("---------------------------------------------" + Environment.NewLine);
                    continue;
                }

                switch (intOperacion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto en moneda nacional.");

                        while (double.TryParse(Console.ReadLine(), out dblMontoMonedaNacional) == false)
                        {
                            Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo.");
                        }

                        dblMontoMonedaAmericana = dblMontoMonedaNacional / dblValorDolarVenta;

                        Console.WriteLine("El total de dolares es: " + Math.Round(dblMontoMonedaAmericana, 2).ToString());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto en moneda americana.");

                        while (double.TryParse(Console.ReadLine(), out dblMontoMonedaAmericana) == false)
                        {
                            Console.WriteLine("El valor ingresado es incorrecto, intente de nuevo.");
                        }

                        dblMontoMonedaNacional = dblMontoMonedaAmericana * dblValorDolarCompra;

                        Console.WriteLine("El total de pesos mexicanos es: " + Math.Round(dblMontoMonedaNacional, 2).ToString());
                        break;
                }

                Console.WriteLine("---------------------------------------------" + Environment.NewLine);

            } while(intOperacion != 3);          
            

            Console.WriteLine("Presione una tecla para salir del programa.");
            Console.ReadLine();

        }
    }
}
