using System;

//El siguiente programa corresponde al problema 63 del capítulo Administración:
//Escribir un programa para producir un facsimil de un cheque. El programa
//introducirá al beneficiario, la fecha, el girador, el nombre del banco, la
//dirección del banco, los números de tránsito, el número de cheque y el importe

//Miguel Villegas Luis Enrique
//16 de marzo del 2022

namespace Problema63.Facsimil
{
    class Program
    {
        class Facsimil
        {
            private string Beneficiario, Fecha, Girador, NombreBanco, DireccionBanco;
            private int NumCheque;
            private double Importe, NumTransito;

            public void GenerarDatosFacsimil()
            {
                Console.Clear();

                Random aleatorio = new Random();

                Console.WriteLine("-INGRESA DATOS PARA EL FACSIMIL DEL CHEQUE-\n");
                Console.Write("Nombre del beneficiario: "); Beneficiario = Console.ReadLine();
                Console.Write("Fecha del facsimil [día de mes-completo del año]: "); Fecha = Console.ReadLine();
                Console.Write("Girador del facsimil: "); Girador = Console.ReadLine();
                Console.Write("Nombre del banco: "); NombreBanco = Console.ReadLine();
                Console.Write("Dirección del banco: "); DireccionBanco = Console.ReadLine();
                try
                {
                    Console.Write("Importe del facsimil: $"); Importe = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                    GenerarDatosFacsimil();
                }
                NumTransito = aleatorio.Next(100000000, 100100000);
                NumCheque = aleatorio.Next(1000, 2000);
            }
            
            public void GenerarFacsimil()
            {
                Console.Clear();

                Console.WriteLine("-FACSIMIL DEL CHEQUE-\n");
                Console.WriteLine("{0}\t\t\tFecha de emisión: {1}",NombreBanco, Fecha);
                Console.WriteLine("{0}\n{1}", DireccionBanco, Girador);
                Console.WriteLine("\nPaguese a {0} la cantidad de ${1}.", Beneficiario, Importe);
                Console.WriteLine("\n{0} - {1}", NumTransito.ToString(), NumCheque.ToString());

                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Facsimil de un cheque";

            Facsimil facsimil = new Facsimil();
            facsimil.GenerarDatosFacsimil();
            facsimil.GenerarFacsimil();
        }
    }
}
