#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <math.h>

//El siguiente programa corresponde al problema 2 del capítulo Trigonometría:
//Introducir la medida en grados de un ángulo y calcular la medida en radianes.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

int main()
{
    double Grados, Radianes;

    std::cout << "-CONVERTIR GRADOS A RADIANES-\n\n";
    std::cout << "Ingresa una cantidad de grados que quiera pasar a radianes: "; std::cin >> Grados;

    Radianes = Grados * (M_PI / 180);
    std::cout << "\n" << Grados << char(167) << " es igual a " << Radianes << "rad.\n";

    return 0;
}