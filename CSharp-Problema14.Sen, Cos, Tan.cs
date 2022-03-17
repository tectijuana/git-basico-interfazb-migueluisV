using System;

//El siguiente programa corresponde al problema 14 del capítulo Trigonometría:
//Introducir las longitudes de la hipotenusa y un cateto
//de un triángulo rectángulo. Determinar el seno, coseno
//y tangente de cualquera de los ángulos agudos

//Miguel Villegas Luis Enrique; migueluisV
//11 de marzo del 2022

namespace ConsoleApp1
{
    class Program
    {
        public class TriRec
        {
            private double Hipo, Cat1, Cat2, Sin, Cos, Tan, An;

            public TriRec(double hipo, double cat1, double cat2)
            {
                Hipo = hipo;
                Cat1 = cat1;
                Cat2 = cat2;
            }

            public void Angulos()
            {
                Sin = Cat1 / Hipo;
                Cos = Cat2 / Hipo;
                Tan = Cat1 / Cat2;
                An = Math.Asin(Sin);
            }

            public void DesplegarTriRec()
            {
                Console.WriteLine("\n-DATOS DE UN TRIÁNGULO RECTÁNGULO-\n");
                Console.WriteLine("Cateto 1: {0}", Cat1);
                Console.WriteLine("Cateto 2: {0}", Cat2);
                Console.WriteLine("Hipotenusa: {0}", Hipo);
                Console.WriteLine("Ángulo del cateto: {0}", An);
                Console.WriteLine("Seno del ángulo: {0}", Sin);
                Console.WriteLine("Coseno del ángulo: {0}", Cos);
                Console.WriteLine("Tangente del ángulo: {0}", Tan);
            }

            ~TriRec() { }
        }

        public static void Main(string[] args)
        {
	    Console.Title = "Seno, coseno y tangente de un triángulo rectángulo";

            double Hipo, Cat1, Cat2;

            TriRec triarect;

            Console.WriteLine("-DATOS DE UN TRIÁNGULO RECTÁNGULO-\n");
            Console.Write("Hipotenusa: "); Hipo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cateto: "); Cat1 = Convert.ToDouble(Console.ReadLine());

            Cat2 = Math.Sqrt(Math.Pow(Hipo, 2) - Math.Pow(Cat1, 2));

            triarect = new TriRec(Hipo, Cat1, Cat2);
            triarect.Angulos();
            triarect.DesplegarTriRec();

            Console.ReadKey();
        }
    }
}
