using System;

//El siguiente programa corresponde al problema 1 del capítulo Geometría:
//Dados los tres lados A, B y C de un triángulo, encontrar los tres ángu-
//los a, b y c. Suponer que todo los ángulos son agudos.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

namespace Problema1.Angulos_de_triangulo
{
    class Triangulo
    {
        private double A = 0.0, B = 0.0, C = 0.0, a, b, c;
        public Triangulo(double la, double lb, double lc)
        {
            a = la;
            b = lb;
            c = lc;
        }
        ~Triangulo() { }
        public void ObtenerAngulos()
        {
            A = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * 180 / Math.PI;
            B = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * 180 / Math.PI;
            C = (Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b))) * 180 / Math.PI;
        }
        public void DesplegarDatosTriangulo()
        {
            ObtenerAngulos();

            Console.Clear();

            Console.WriteLine("-ÁNGULOS DE UN TRIÁNGULO-\n");
            Console.WriteLine("Lado a: {0}", a.ToString());
            Console.WriteLine("Lado b: {0}", b.ToString());
            Console.WriteLine("Lado c: {0}", c.ToString());
            Console.WriteLine("Ángulo A: {0}", A.ToString());
            Console.WriteLine("Ángulo B: {0}", B.ToString());
            Console.WriteLine("Ángulo C: {0}", C.ToString());

            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lados y ángulos de un triángulo";

            double a, b, c;

            Console.WriteLine("-LADOS DE UN TRIÁNGULO-\n");

            Console.Write("Lado a: "); a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado b: "); b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado c: "); c = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(a, b, c);
            triangulo.DesplegarDatosTriangulo();
        }
    }
}
