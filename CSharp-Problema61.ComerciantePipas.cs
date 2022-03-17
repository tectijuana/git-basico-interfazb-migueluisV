using System;

//El siguiente programa corresponde al problema 61 del capítulo Administración:
//Un comerciante en pipas puede vender a un dólar 1,000 pipas que le costaron 50
//centavos cada una. Por cada centavo que él reduzca al precio, puede aumentar el número
//vendido en 50. ¿Qué precio maximizará las ganancias? Sugerencia:
//Ganancias = ventas - costos. Obviamente, el precio correcto queda entre .50 y
//1. Calcular las ganancias en cada uno de los precios en este rango y escoger
//el que dé la ganancia máxima.

//Miguel Villegas Luis Enrique; migueluisV
//16 de marzo del 2022

namespace Problema61.ComerciantePipas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ganancia, PrecioPipa = 1.01, Ventas = 950.0, MaxGanancia = 0.0, MejorPrecio = 0.0;

            while (PrecioPipa > 0.5)
            {
                PrecioPipa = PrecioPipa - 0.01;
                Ventas += 50;
                Ganancia = (PrecioPipa * Ventas) - 500.0;
                Console.WriteLine("Ganancia con pipas en ${0}: {1}", PrecioPipa.ToString(), Ganancia.ToString());
                if (Ganancia > MaxGanancia)
                {
                    MejorPrecio = PrecioPipa;
                    MaxGanancia = Ganancia;
                }
            }
            Console.WriteLine("\nLa mayor ganancia en todo el rango de precios es: ${0} con precio de ${1}.", MaxGanancia.ToString(), MejorPrecio.ToString());
            Console.ReadKey();
        }
    }
}
