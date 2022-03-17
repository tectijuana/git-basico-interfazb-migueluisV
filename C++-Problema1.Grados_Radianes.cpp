#include <iostream>
#include <stdlib.h>
#include <cmath>

//El siguiente programa corresponde al problema 1 del capítulo Trigonometría:
//Pasar de grados a radianes, usando múltiplos de 10 grados, desde 0 grados
//hasta 360 grados.

//Miguel Villegas Luis Enrique; migueluisV
//17 de marzo del 2022

#define MY_PI 3.14159265358979323846

void GradosRadianes()
{
    char Op = 's';
    int Grados;
    double Radianes;

    while (Op == 's')
    {
        system("cls");

        std::cout << "-PASAR GRADOS A RADIANTES CON M" << char(233) << "LTIPLOS DE 10 - \n\n";
        std::cout << "Escribe una cantidad de grados que sea un m" << char(163) << "ltiplo de 10: "; std::cin >> Grados;
        if ((Grados % 10) != 0)
        {
            std::cout << "El n" << char(163) << "mero ingresado no es un m" << char(163) << "ltiplo de 10.";
            system("pause");
            GradosRadianes();
        }
        else
        {
            Radianes = Grados * (MY_PI / 180);
            std::cout << "\n" << Grados << char(167) << " es igual a " << Radianes << "rad.\n";
        }

        std::cout << "\n" << char(168) << "Ingresar otra cantidad? [s/n]: "; std::cin >> Op;
    }
}

int main()
{
    GradosRadianes();

    return 0;
}