using System;

namespace PuntoDeVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 intCodigoProducto = new Int32();
            int intCantidad = new int();
            double dblPrecio = new float();
            double dblTotal = new float();


            Console.WriteLine("Ejercicio No. 4: Punto de venta.");

            do
            {
                Console.WriteLine(Environment.NewLine +  "Ingresa código de producto a cobrar." + Environment.NewLine + "Presione enter para finalizar");
                intCodigoProducto = 0;
                Int32.TryParse(Console.ReadLine(), out intCodigoProducto);

                if(intCodigoProducto > 0)
                {
                    Console.WriteLine("Ingresa el precio del producto capturado.");
                    dblPrecio = 0;
                    intCantidad++;
                    bool bolPrecio = false;

                    while (bolPrecio == false)
                    {
                        bolPrecio = double.TryParse(Console.ReadLine(), out dblPrecio);

                        if(bolPrecio == false)
                        {
                            Console.WriteLine("El valor ingresado para precio, es incorrecto. Intenta de nuevo.");
                        }
                        else
                        {
                            dblTotal += dblPrecio;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El total a cobrar es: " + dblTotal);
                    Console.WriteLine("El numero total de productos es: " + intCantidad);
                }
            } while (intCodigoProducto != 0);

            Console.WriteLine(Environment.NewLine + "Presione una tecla para salir.");
            Console.ReadLine();

        }
    }
}
