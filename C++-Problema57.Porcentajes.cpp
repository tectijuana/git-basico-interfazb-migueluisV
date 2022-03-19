#include <iostream>
#include <string>

//El siguiente programa corresponde al problema 57 del capítulo Administración:
//Hacer un programa que facilite al estudiante la solución
//de problemas de porcentajes

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

void Menu();
void PorcentajeCantidad();
void DecimalPorcentaje();
void PorcentajeDecimal();

void Menu()
{
    char Op;

    system("cls");

    std::cout << "-PROBLEMAS DE PORCENTAJES-\n\n";
    std::cout << "Selecciona una opci" << char(162) << "n:\n";
    std::cout << "1) Porcentaje de una cantidad.\n";
    std::cout << "2) Porcentaje a decimal.\n";
    std::cout << "3) Decimal a porcentaje.\n";
    std::cout << "4) Salir.\n";
    std::cout << "Opci" << char(162) << "n: "; std::cin >> Op;
    switch (Op)
    {
    case '1':
        PorcentajeCantidad();
        break;
    case '2':
        PorcentajeDecimal();
        break;
    case '3':
        DecimalPorcentaje();
        break;
    case '4':
        system("pause");
        exit(EXIT_SUCCESS);
        break;
        default:
            std::cout << "\nEsa opci" << char(162) << "no est" << char(160) << " en el men" << char(163) << ".";
            system("pause");
            Menu();
            break;
    }
}

void PorcentajeCantidad()
{
    double Cantidad, Porcentaje, Resultado;
    char Op = 's';

    while (Op == 's')
    {
        system("cls");
        std::cout << "-PROBLEMAS DE PORCENTAJES. PORCENTAJE DE X CANTIDAD-\n\n";
        std::cout << "Ingresa una cantidad: "; std::cin >> Cantidad;
        std::cout << "Ingresa un porcentaje a calcular: "; std::cin >> Porcentaje;

        Resultado = Cantidad * (Porcentaje / 100);

        std::cout << "El " << std::to_string(Porcentaje) << "% de " << std::to_string(Cantidad) << " es " << std::to_string(Resultado) << ".\n\n";

        std::cout << char(168) << "Calcular otro porcentaje? s/n: "; std::cin >> Op;
    }

    Menu();
}

void PorcentajeDecimal()
{
    double Decimal, Porcentaje;
    char Op = 's';

    while (Op == 's')
    {
        system("cls");
        std::cout << "-PROBLEMAS DE PORCENTAJES. PORCENTAJE A DECIMAL-\n\n";
        std::cout << "Ingresa una porcentaje: "; std::cin >> Porcentaje;

        Decimal = Porcentaje / 100;

        std::cout << "El decimal de " << std::to_string(Porcentaje) << "% es " << std::to_string(Decimal) << "\n\n";

        std::cout << char(168) << "Calcular otro porcentaje? s/n: "; std::cin >> Op;
    }

    Menu();
}

void DecimalPorcentaje()
{
    double Porcentaje, Decimal;
    char Op = 's';

    while (Op == 's')
    {
        system("cls");
        std::cout << "-PROBLEMAS DE PORCENTAJES. DECIMAL A PORCENTAJE-\n\n";
        std::cout << "Ingresa una decimal: "; std::cin >> Decimal;

        Porcentaje = Decimal * 100;

        std::cout << "El porcentaje de" << std::to_string(Decimal) << " es " << std::to_string(Porcentaje) << "%\n\n";

        std::cout << char(168) << "Calcular otro decimal? s/n: "; std::cin >> Op;
    }

    Menu();
}

int main()
{
    Menu();

    return 0;
}