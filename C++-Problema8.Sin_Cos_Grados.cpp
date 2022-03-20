#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <math.h>

//El siguiente programa corresponde al problema 3 del capítulo Trigonometría:
//Encontrar el valor de sen x y cos x para x = 30, 45, 60, 90 y cualquier grado.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

int main()
{

    std::cout << "-ENCONTRAR EL SENO Y COSENO DE UN GRADO-\n\n";

    std::cout << "Grado\t\tSeno\t\tCoseno\n";
    std::cout << "30\t\t(1/4)^(1/2)\t(3/4)^(1/2)\n";
    std::cout << "45\t\t(1/2)^(1/2)\t(1/2)^(1/2)\n";
    std::cout << "60\t\t(3/4)^(1/2)\t(1/4)^(1/2)\n";
    std::cout << "90\t\t(4/4)^(1/2)\t(0/4)^(1/2)\n";
    return 0;
}