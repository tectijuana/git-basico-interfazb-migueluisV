#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <math.h>

//El siguiente programa corresponde al problema 3 del capítulo Trigonometría:
//Introducir la medida en grados de un ángulo y calcular la medida en radianes.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

int main()
{
	double Grados, Radianes;

	std::cout << "-CONVERTIR RADIANES A GRADOS-\n\n";
	std::cout << "Ingresa una cantidad de radianes que quiera pasar a grados: "; std::cin >> Radianes;

	Grados = Radianes * (180 / M_PI);
	std::cout << "\n" << Radianes << "rad es igual a " << Grados << char(167) << ".\n";

	return 0;
}
