#include <iostream>
#include <string>

//El siguiente programa corresponde al problema 64 del capítulo Administración:
//Una compañia decide dar a cada uno de sus empleados un bono de un octavo de su
//salario anual. Encontrar las bonificaciones pagadas por esta compañia, si los
//salarios anuales de sus empleados son: $12,000, $14,000, $9,000, $6,500, $10,400,
//8,200.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

int main()
{
    double Bono, Salario;

    std::cout << "-BONOS DE OCTAVOS A EMPLEADOS-\n\n";
    std::cout << "Escribe el salario anual del empleado al cual se le dar" << char(160) << " un bono: $"; std::cin >> Salario;

    Bono = Salario / 8;

    std::cout << "\nEl salario m" << char(160) << "s bono del empleado es de: $" << std::to_string(Salario + Bono);
    
    return 0;
}
