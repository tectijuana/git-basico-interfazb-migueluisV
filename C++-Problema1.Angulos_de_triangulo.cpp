#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <math.h>

//El siguiente programa corresponde al problema 1 del capítulo Geometría:
//Dados los tres lados A, B y C de un triángulo, encontrar los tres ángu-
//los a, b y c. Suponer que todo los ángulos son agudos.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

class Triangulo
{
private:
    double A = 0.0, B = 0.0, C = 0.0, a, b, c;
public:
    Triangulo(double la, double lb, double lc) : a(la), b(lb), c(lc) {}
    ~Triangulo(){}
    void ObtenerAngulos()
    {
        A = (acos((pow(b, 2) + pow(c, 2) - pow(a, 2)) / (2 * b * c))) * 180 / M_PI;
        B = (acos((pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c))) * 180 / M_PI;
        C = (acos((pow(a, 2) + pow(b, 2) - pow(c, 2)) / (2 * a * b))) * 180 / M_PI;
    }
    void DesplegarDatosTriangulo()
    {
        ObtenerAngulos();

        system("cls");

        std::cout << "-" << char(181) << "NGULOS DE UN TRI" << char(181) << "NGULO-\n\n";
        std::cout << "Lado a: " << std::to_string(a) << "\n";
        std::cout << "Lado b: " << std::to_string(b) << "\n";
        std::cout << "Lado c: " << std::to_string(c) << "\n";
        std::cout << char(181) << "ngulo A: " << std::to_string(A) << "\n";
        std::cout << char(181) << "ngulo B: " << std::to_string(B) << "\n";
        std::cout << char(181) << "ngulo C: " << std::to_string(C) << "\n";
    }
};

int main()
{
    double a, b, c;

    std::cout << "LADOS DE UN TRI" << char(181) << "NGULO - \n\n";
    std::cout << "Lado a: "; std::cin >> a;
    std::cout << "Lado b: "; std::cin >> b;
    std::cout << "Lado c: "; std::cin >> c;

    Triangulo triangulo(a, b, c);
    triangulo.DesplegarDatosTriangulo();

    return 0;
}