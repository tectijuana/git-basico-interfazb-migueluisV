using System;

//El siguiente programa corresponde al problema 56 del capítulo Administración:
//Generar un programa que imprima letras de cambio mensuales para una compañia
//de tarjetas de crédito. Debe agregar pagos hechos en el mes anterior; resta
//el costo de compras realizadas y sustraer un cargo financiero mensual del 1.5%
//sobre el balance no pagado.

//Miguel Villegas Luis Enrique
//11 de marzo del 2022

namespace Problema56.Letra_Cambio
{
    class LetraCambio
    {
        private string Librador, Librado, FechaEmision, LugarPago, Moneda;
        private DateTime FechaPago;
        private double CantidadPago;
        private int MesesRetraso;
        private float[] PagosMensuales = new float[10];

        public LetraCambio() { }

        public void ValoresPagosMensuales()
        {
            int Pos = -1;
            char Op = 's';

            Console.Clear();

            Console.WriteLine("-PAGOS PREVIOS DE LA LETRA-");
            Console.WriteLine("Registra pagos con la tajeta que se hayan hecho meses antes de la realización de la letra:");

            while (Op == 's' && Pos < 9)
            {
                Pos++;
                Console.WriteLine("\nQuedan [{0}] espacios", (10 - Pos));
                Console.Write("Cantidad pagada: "); PagosMensuales[Pos] = Convert.ToSingle(Console.ReadLine());
                CantidadPago += PagosMensuales[Pos];
                Console.Write("¿Agregar otro pago? [s/n]: "); Op = Convert.ToChar(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("-PAGOS PREVIOS DE LA LETRA-\n");
            Console.WriteLine("Fecha actual: {0}.", DateTime.Today.ToString("dd/MM/yyyy"));
            Console.Write("Número de meses que pasaron desde que se hicieron las anteriores compras: "); MesesRetraso = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            DesplegarPagosMensuales(Pos);
        }

        public void DesplegarPagosMensuales(int pos)
        {
            int i;

            Console.WriteLine("-PAGOS PREVIOS DE LA LETRA-");
            for (i = 0; i <= pos; i++)
            {
                Console.WriteLine("{0}- {1}", (i + 1), PagosMensuales[i]);
            }
            Console.WriteLine("Total de los pagos sin interés mensual: {0}", CantidadPago.ToString());
        }

        public void ValoresCarta()
        {
            int i, Interes;

            Console.Clear();

            Console.WriteLine("\n\n-DATOS DE LA LETRA-\n");
            FechaEmision = DateTime.Today.ToString("D");
            Console.Write("Nombre del librado: "); Librado = Console.ReadLine();
            Console.Write("Nombre del librador: "); Librador = Console.ReadLine();
            Console.Write("Fecha acordada para el pago [dd/mm/aaaa]: "); FechaPago = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Lugar acordado de pago [ciudad, estado, país]: "); LugarPago = Console.ReadLine();
            Console.Write("Moneda en la cual se efectuará el pago: "); Moneda = Console.ReadLine();

            Interes = FechaPago.Month - MesesRetraso;
            MesesRetraso += Interes;

            for (i = 1; i <= MesesRetraso; i++)
            {
                CantidadPago += (CantidadPago * 0.015);
            }
        }

        public void GenerarCarta()
        {
            Console.WriteLine("\n-LETRA DE CAMBIO-\n");
            Console.WriteLine(
                "La presente carta, emitida el día {0} en {1}, la persona {2}\n" +
                "se compromete a pagar el día {3}, a la \n" +
                "orden de {4} la cantidad de {5:N4} {6}, el cual incluye un interés \n" +
                "mensual del 1.5%, con una cantidad de {7} meses de retraso."
                , FechaEmision, LugarPago, Librado, FechaPago.ToString("D"), Librador, CantidadPago, Moneda, MesesRetraso.ToString()
            );
        }

        ~LetraCambio() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
	    Console.Title = "Creación de letras de cambio";

            LetraCambio letracambio = new LetraCambio();
            letracambio.ValoresPagosMensuales();
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            letracambio.ValoresCarta();
            letracambio.GenerarCarta();

            Console.ReadKey();
        }
    }
}
