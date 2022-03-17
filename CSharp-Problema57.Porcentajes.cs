using System;

//El siguiente programa corresponde al problema 57 del capítulo Administración:
//Hacer un programa que facilite al estudiante la solución
//de problemas de porcentajes

//Miguel Villegas Luis Enrique
//11 de marzo del 2022

namespace Problema57.Porcentajes
{
    class Program
    {
        static void Menu()
        {
            char Op;

            Console.Clear();

            Console.WriteLine("-PROBLEMAS DE PORCENTAJES-\n");
            try
            {
                Console.WriteLine("Selecciona una opción:\n1)Porcentaje de una cantidad.\n2)Porcentaje a decimal.\n3)Decimal a porcentaje.\n4)Salir.\n");
                Console.Write("Opcion: "); Op = Convert.ToChar(Console.ReadLine());
                switch (Op)
                {
                    case '1':
                        PorcentajeCantidad();
                        break;
                    case '2':
                        PorcentajeDecimal();
                        break;
                    case '3':
                        DecimalPorcentaje();
                        break;
                    case '4':
                        Console.Write("Presione cualquier tecla para finalizar...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Esa opción no está en el menú.");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }
            catch(FormatException)
            {
                Console.Write("El valor ingresado no es aceptado.");
                Console.ReadKey();
                Menu();
            }
        }

        static void PorcentajeCantidad()
        {
            double Cantidad, Porcentaje, Resultado;
            char Op = 's';

            while (Op == 's')
            {
                Console.Clear();
                Console.WriteLine("-PROBLEMAS DE PORCENTAJES. PORCENTAJE DE X CANTIDAD-\n");
                try
                {
                    Console.Write("Ingresa una cantidad: "); Cantidad = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa un porcentaje para calcular: "); Porcentaje = Convert.ToDouble(Console.ReadLine());
                    Resultado = Cantidad * (Porcentaje / 100);
                    Console.WriteLine("El {0}% de {1} es {2}", Porcentaje, Cantidad, Resultado);
                    Console.Write("\n¿Calcular otro porcentaje? [s/n]: "); Op = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                    Menu();
                }
            }

            Menu();
        }

        static void PorcentajeDecimal()
        {
            double Porcentaje, Decimal;
            char Op = 's';

            while (Op == 's')
            {
                Console.Clear();
                Console.WriteLine("-PROBLEMAS DE PORCENTAJES. PORCENTAJE A DECIMAL-\n");
                try
                {
                    Console.Write("Ingresa un porcentaje: "); Porcentaje = Convert.ToDouble(Console.ReadLine());
                    Decimal = Porcentaje / 100;
                    Console.WriteLine("El decimal del {0}% es {1}", Porcentaje, Decimal);
                    Console.Write("\n¿Calcular otro porcentaje? [s/n]: "); Op = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                    Menu();
                }
            }

            Menu();
        }

        static void DecimalPorcentaje()
        {
            double Porcentaje, Decimal;
            char Op = 's';

            while (Op == 's')
            {
                Console.Clear();
                Console.WriteLine("-PROBLEMAS DE PORCENTAJES. PORCENTAJE A DECIMAL-\n");
                try
                {
                    Console.Write("Ingresa un decimal: "); Decimal = Convert.ToDouble(Console.ReadLine());
                    Porcentaje = Decimal * 100;
                    Console.WriteLine("El porcentaje de {0} es {1}%", Decimal, Porcentaje);
                    Console.Write("\n¿Calcular otro porcentaje? [s/n]: "); Op = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("El valor ingresado no es aceptado.");
                    Console.ReadKey();
                    Menu();
                }
            }

            Menu();
        }

        static void Main(string[] args)
        {
	    Console.Title = "Herramienta para resolver problemas de porcentajes";
            Menu();
        }
    }
}
