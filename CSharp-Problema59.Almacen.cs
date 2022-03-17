using System;

//El siguiente programa corresponde al problema 59 del capítulo Administración:
//Un almacen tiene un artículo de vestir en bodega, clasificado como pequeño, mediano,
//y grande, en colores rojo, blanco y amarillo. La existencia a mano (por tamaño
//y color) se da en la tabla A, donde las filas representan tamaño y las columnas color.
//El precio por unidad se da también en el mismo esquema de clasificación en la tabla
//B. ¿Qué inventario por tamaño y color debe tener el comerciante a mano en doláres?
//     Tabla A                      Tabla B
//      R   B   A               R       B       A
//P     6   14  2           P   3.95    3.95    4.25
//M     12  22  8           M   4.95    4.95    5.25
//G     7   3   4           G   5.45    5.95    6.5

//Miguel Villegas Luis Enrique
//16 de marzo del 2022

namespace Problema59.Almacen
{
    class Program
    {
        struct Articulo
        {
            public ushort CantA;
            public double PrecioPA;
            public double PrecioDA;
        }

        static void IngresarDatos()
        {
            const double Dolar = 21.35;
            int Cont = 0;
            Articulo[] articulos = new Articulo[9];

            Console.Clear();

            Console.WriteLine("-INGRESAR ARTÍCULOS DE VESTIR A ALMACÉN-\n");
            Console.WriteLine("Ingresa los siguientes datos sobre el artículo:");
            while (Cont < 9)
            {
                Console.WriteLine("Quedan [{0}] espacios.", (9 - Cont));
                try
                {
                    Console.Write("Cantidad en piezas del artículo: "); articulos[Cont].CantA = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Precio en pesos por unidad del artículo: "); articulos[Cont].PrecioPA = Math.Round(Convert.ToDouble(Console.ReadLine()), 3);
                    articulos[Cont].PrecioDA = Math.Round(articulos[Cont].PrecioPA / Dolar, 3);

                    Console.WriteLine();
                    Cont++;
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                }
            }
            DesplegarDatos(articulos);
        }

        static void DesplegarDatos(Articulo[] ar)
        {
            Console.Clear();

            Console.WriteLine("Tabla cantidad de piezas artículo\nTamArt\tR\tB\tA\n");
            Console.WriteLine("C\t{0}\t{1}\t{2}\n", ar[0].CantA.ToString(), ar[1].CantA.ToString(), ar[2].CantA.ToString());
            Console.WriteLine("M\t{0}\t{1}\t{2}\n", ar[3].CantA.ToString(), ar[4].CantA.ToString(), ar[5].CantA.ToString());
            Console.WriteLine("G\t{0}\t{1}\t{2}\n", ar[6].CantA.ToString(), ar[7].CantA.ToString(), ar[8].CantA.ToString());

            Console.WriteLine("Tabla precio en pesos de piezas artículo\nTamArt\tR\tB\tA\n");
            Console.WriteLine("C\t{0}\t{1}\t{2}\n", ar[0].PrecioPA.ToString(), ar[1].PrecioPA.ToString(), ar[2].PrecioPA.ToString());
            Console.WriteLine("M\t{0}\t{1}\t{2}\n", ar[3].PrecioPA.ToString(), ar[4].PrecioPA.ToString(), ar[5].PrecioPA.ToString());
            Console.WriteLine("G\t{0}\t{1}\t{2}\n", ar[6].PrecioPA.ToString(), ar[7].PrecioPA.ToString(), ar[8].PrecioPA.ToString());

            Console.WriteLine("Tabla  precio en dólares de piezas artículo\nTamArt\tR\tB\tA\n");
            Console.WriteLine("C\t{0}\t{1}\t{2}\n", ar[0].PrecioDA.ToString(), ar[1].PrecioDA.ToString(), ar[2].PrecioDA.ToString());
            Console.WriteLine("M\t{0}\t{1}\t{2}\n", ar[3].PrecioDA.ToString(), ar[4].PrecioDA.ToString(), ar[5].PrecioDA.ToString());
            Console.WriteLine("G\t{0}\t{1}\t{2}\n", ar[6].PrecioDA.ToString(), ar[7].PrecioDA.ToString(), ar[8].PrecioDA.ToString());

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Title = "Inventario de artículos de vestir en almacén";

            IngresarDatos();
        }
    }
}
