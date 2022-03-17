#include <iostream>

//El siguiente programa corresponde al problema 56 del capítulo Administración:
//Introducir la siguiente tabla; ordenar las entradas por teclas e impirmir una
//tabla de vaores en orden de teclas.
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

//Miguel Villegas Luis Enrique; migueluisV
//17 de marzo del 2022

int main()
{
	int i, j, tempT, tempV;
	int Teclas_Valores[10][2];

	std::cout << "-INSERTA N" << char(233) << "EROS POR TECLADO-\n\n";
	for (i = 0; i < 10; i++)
	{
		std::cout << (i + 1) << "- Valor por tecla: "; std::cin >> Teclas_Valores[i][0];
		switch (Teclas_Valores[i][0])
		{
            case 2:
                Teclas_Valores[i][1] = 14;
                break;
            case 6:
                Teclas_Valores[i][1] = 301;
                break;
            case 32:
                Teclas_Valores[i][1] = 1632;
                break;
            case 4:
                Teclas_Valores[i][1] = 171;
                break;
            case 11:
                Teclas_Valores[i][1] = 6321;
                break;
            case 1:
                Teclas_Valores[i][1] = 148;
                break;
            case 15:
                Teclas_Valores[i][1] = 7;
                break;
            case 9:
                Teclas_Valores[i][1] = 23;
                break;
            case 25:
                Teclas_Valores[i][1] = 666;
                break;
            case 17:
                Teclas_Valores[i][1] = 31;
                break;
		}
	}

    for (i = 0; i < 10; i++)
    {
        for (j = 0; j < 9; j++)
        {
            if (Teclas_Valores[j, 0] > Teclas_Valores[(j + 1), 0])
            {
                tempT = Teclas_Valores[j + 1][0];
                tempV = Teclas_Valores[j + 1][1];
                Teclas_Valores[j + 1][0] = Teclas_Valores[j][0];
                Teclas_Valores[j + 1][1] = Teclas_Valores[j][1];
                Teclas_Valores[j][0] = tempT;
                Teclas_Valores[j][1] = tempV;
            }
        }
    }

    system("cls");

    std::cout << "\n-DESPLIEGUE DE TABLA-\n\nTeclas\tValor\n";
    for (i = 0; i < 10; i++)
    {
        for (j = 0; j < 2; j++)
        {
            std::cout << Teclas_Valores[i][j] << "\t";
        }
        std::cout << "\n";
    }
}

