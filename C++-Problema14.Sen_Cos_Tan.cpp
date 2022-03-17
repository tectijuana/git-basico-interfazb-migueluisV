#include <iostream>
#include <stdlib.h>
#include <cmath>

//El siguiente programa corresponde al problema 14 del capítulo Trigonometría:
//Introducir las longitudes de la hipotenusa y un cateto
//de un triángulo rectángulo. Determinar el seno, coseno
//y tangente de cualquera de los ángulos agudos

//Miguel Villegas Luis Enrique; migueluisV
//17 de marzo del 2022

class TriRec
{
private:
    double Hipo, Cat1, Cat2, Sin = 0.0, Cos = 0.0, Tan = 0.0, An = 0.0;
public:
    TriRec(double h, double c1, double c2)
    {
        Hipo = h;
        Cat1 = c1;
        Cat2 = c2;
    }
    ~TriRec() { }
    void Angulos()
    {
        Sin = Cat1 / Hipo;
        Cos = Cat2 / Hipo;
        Tan = Cat1 / Cat2;
        An = asin(Sin);
    }
    void DesplegarTriRec()
    {
        system("cls");
        std::cout << "-DATOS DE UN TRI" << char(181) << "NGULO RECT" << char(181) << "NGULO-\n\n";
        std::cout << "Cateto 1: " << Cat1 << "\n";
        std::cout << "Cateto 2: " << Cat2 << "\n";
        std::cout << "Hipotenusa: " << Hipo << "\n";
        std::cout << char(181) << "ngulo del cateto: " << An << "\n";
        std::cout << "Seno del " << char(181) << "ngulo: " << Sin << "\n";
        std::cout << "Coseno del " << char(181) << "ngulo: " << Cos << "\n";
        std::cout << "Tangente del " << char(181) << "ngulo: " << Tan << "\n";
    }
};

int main()
{
    double Hipo, Cat1, Cat2;

    std::cout << "-DATOS DE UN TRI" << char(181) << "NGULO RECT" << char(181) << "NGULO-\n\n";
    std::cout << "Hipotenusa: "; std::cin >> Hipo;
    std::cout << "Cateto: "; std::cin >> Cat1;

    Cat2 = cbrt(pow(Hipo, 2) - pow(Cat1, 2));

    TriRec triarect(Hipo, Cat1, Cat2);
    triarect.Angulos();
    triarect.DesplegarTriRec();

    return 0;
}
