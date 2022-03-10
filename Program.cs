using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema55.Tecla_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int tecla, i, j, tempT, tempV;
            int[,] Teclas_Valores = new int[10, 2];

            Console.WriteLine("-INSERTA NÚMEROS POR TECLADO-\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}-Valor por tecla: ", (i + 1)); tecla = Convert.ToInt16(Console.ReadLine());
                Teclas_Valores[i, 0] = tecla;

                if (Teclas_Valores[i, 0] == 2)
                    Teclas_Valores[i, 1] = 14;
                if (Teclas_Valores[i, 0] == 6)
                    Teclas_Valores[i, 1] = 301;
                if (Teclas_Valores[i, 0] == 32)
                    Teclas_Valores[i, 1] = 1632;
                if (Teclas_Valores[i, 0] == 4)
                    Teclas_Valores[i, 1] = 171;
                if (Teclas_Valores[i, 0] == 11)
                    Teclas_Valores[i, 1] = 6321;
                if (Teclas_Valores[i, 0] == 1)
                    Teclas_Valores[i, 1] = 148;
                if (Teclas_Valores[i, 0] == 15)
                    Teclas_Valores[i, 1] = 7;
                if (Teclas_Valores[i, 0] == 9)
                    Teclas_Valores[i, 1] = 23;
                if (Teclas_Valores[i, 0] == 25)
                    Teclas_Valores[i, 1] = 666;
                if (Teclas_Valores[i, 0] == 17)
                    Teclas_Valores[i, 1] = 31;
            }

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (Teclas_Valores[j, 0] > Teclas_Valores[(j + 1), 0])
                    {
                        tempT = Teclas_Valores[(j + 1), 0];
                        tempV = Teclas_Valores[(j + 1), 1];
                        Teclas_Valores[(j + 1), 0] = Teclas_Valores[j, 0];
                        Teclas_Valores[(j + 1), 1] = Teclas_Valores[j, 1];
                        Teclas_Valores[j, 0] = tempT;
                        Teclas_Valores[j, 1] = tempV;
                    }
                }
            }

            Console.WriteLine("\n-DESPLIEGUE DE TABLA-\n");
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(Teclas_Valores[i, j] + " - ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
