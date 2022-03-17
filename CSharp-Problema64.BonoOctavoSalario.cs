using System;

//El siguiente programa corresponde al problema 64 del capítulo Administración:
//Una compañia decide dar a cada uno de sus empleados un bono de un octavo de su
//salario anual. Encontrar las bonificaciones pagadas por esta compañia, si los
//salarios anuales de sus empleados son: $12,000, $14,000, $9,000, $6,500, $10,400,
//8,200.

//Miguel Villegas Luis Enrique; migueluisV
//16 de marzo del 2022

namespace Problema64.BonoOctavoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bonos a empleados";

            double Salario, Bono;

            Console.WriteLine("-BONOS DE OCTAVOS A EMPLEADOS-\n");
            Console.Write("Escribe el salario anual del empleado al cual se le dará un bono: $"); Salario = Convert.ToDouble(Console.ReadLine());
            Bono = Salario / 8;
            Console.WriteLine("\nEl salario más bono del empleado es de: ${0}", (Salario + Bono));

            Console.ReadKey();
        }
    }
}
