using System;

//El siguiente programa corresponde al problema 56 del capítulo Administración:
//Introducir la siguiente tabla; ordenar las entradas
//por teclas e impirmir una tabla de vaores en orden de
//teclas.
//Teclas | Valor
//2      |14
//6      |301
//32     |1632
//4      |171
//11     |6321
//1      |148
//15     |7
//9      |23
//25     |666
//17     |31

//Miguel Villegas Luis Enrique
//11 de marzo del 2022

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

                switch(Teclas_Valores[i, 0])
                {
                    case 2:
                        Teclas_Valores[i, 1] = 14;
                        break;
                    case 6:
                        Teclas_Valores[i, 1] = 301;
                        break;
                    case 32:
                        Teclas_Valores[i, 1] = 1632;
                        break;
                    case 4:
                        Teclas_Valores[i, 1] = 171;
                        break;
                    case 11:
                        Teclas_Valores[i, 1] = 6321;
                        break;
                    case 1:
                        Teclas_Valores[i, 1] = 148;
                        break;
                    case 15:
                        Teclas_Valores[i, 1] = 7;
                        break;
                    case 9:
                        Teclas_Valores[i, 1] = 23;
                        break;
                    case 25:
                        Teclas_Valores[i, 1] = 666;
                        break;
                    case 17:
                        Teclas_Valores[i, 1] = 31;
                        break;
                }
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
