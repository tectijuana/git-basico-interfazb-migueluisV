using System;

//El siguiente programa corresponde al problema 60 del capítulo Administración:
//Al Sr. López se le ofrece un empleo en una planta manufacturera y se le da la
//oportunidad de seleccionar dos formas de recibir su salario. Puede recibir su
//sueldo mensual de $500 y un aumento de $5 mensual o bien, un salario mensual
//de $500 con un aumento anual de $80. Redactar un programa para determinar los
//salarios mensuales para los 10 años próximos en cada caso. El programa deter-
//minará los salarios acumulativos despuéa de cada mes y, de esa información
//decidirá cuál método de pago es mejor

//Miguel Villegas Luis Enrique
//16 de marzo del 2022

namespace Problema60.Salario
{
    class Program
    {
        static void Menu()
        {
            char Op;

            Console.Clear();

            Console.WriteLine("-SALARIO MENSUAL Y ANUAL EN MANUFACTURERA-\n");
            Console.WriteLine("Paquete A - $500 mensual más aumento de $5 por mes.\nPaquete B - $500 mensual más aumento de $80 por año.");
            Console.Write("¿Qué opción desea? [A, B]: "); Op = Convert.ToChar(Console.ReadLine().ToUpper());
            if (Op == 'A')
                DesplegarSalario((double)5);
            else
                DesplegarSalario(Math.Round(((double)80 / (double)12), 3));
        }

        static void DesplegarSalario(double aumento)
        {
            double Salario = 500;
            int i, j;
            string[] Meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            double[] SalarioAnual = new double[10];

            Console.Clear();

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("El año {0} trabajando en la manufacturera tendrás los siguientes salarios con aumentos:", i);
                for (j = 0; j < 12; j++)
                {
                    Console.WriteLine("{0}\t\t-\t${1}", Meses[j], Salario.ToString());
                    Salario += aumento;
                    SalarioAnual[i - 1] += Salario;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-TABLA DE SALARIOS ANUALES DURANTE 10 AÑOS-");
            Console.WriteLine("Estos son los salarios totales que recibirías cada año:\n");
            Console.WriteLine("Año\t\tSalario acumulado");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t\t{1}", i.ToString(), SalarioAnual[i - 1].ToString());
            }

            Console.Write("\nPresiona cualquier tecla para regresar al Menú.");
            Console.ReadKey();
            Menu();
        }

        static void Main(string[] args)
        {
            Console.Title = "Salario de manufacturera";

            Menu();
        }
    }
}
