using System;

//El siguiente programa corresponde al problema 1 del capítulo Trigonometría:
//Pasar de grados a radianes, usando múltiplos de 10 grados, desde 0 grados
//hasta 360 grados.

//Miguel Villegas Luis Enrique; migueluisV
//16 de marzo del 2022

namespace Problema1.Grados_Radianes
{
    class Program
    {
        static void GradosRadianes()
        {
            char Op = 's';
            int Grados;
            double Radianes;

            while (Op == 's')
            {
                Console.Clear();

                Console.WriteLine("-PASAR GRADOS A RADIANES CON MÚLTIPLOS DE 10-\n");
                try
                {
                    Console.Write("Escribe una cantidad de grados que un múltiplo de 10: "); Grados = Convert.ToInt32(Console.ReadLine());
                    if ((Grados % 10) != 0)
                    {
                        Console.Write("El número ingresado no es un múltiplo de 10.");
                        Console.ReadKey();
                        GradosRadianes();
                    }
                    else
                    {
                        Radianes = Math.Round(Grados * (Math.PI / 180), 4);
                        Console.WriteLine("\n{0}° es igual a {1}rad.", Grados.ToString(), Radianes.ToString());
                    }
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                    GradosRadianes();
                }

                Console.Write("\n¿Ingresar otra cantidad? [s/n]: "); Op = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Grados a radianes";
            GradosRadianes();
        }
    }
}
