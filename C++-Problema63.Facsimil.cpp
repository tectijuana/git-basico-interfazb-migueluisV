#include <iostream>
#include <string>
#include <cstdlib>

//El siguiente programa corresponde al problema 63 del capítulo Administración:
//Escribir un programa para producir un facsimil de un cheque. El programa
//introducirá al beneficiario, la fecha, el girador, el nombre del banco, la
//dirección del banco, los números de tránsito, el número de cheque y el importe

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

class Facsimil
{
private:
    std::string Beneficiario, Fecha, Girador, NombreBanco, DireccionBanco;
    int NumCheque, NumTransito;
    double Importe;
public:
    void GenerarDatosFacsimil()
    {
        system("cls");

        std::cout << "-INGRESA DATOS PARA EL FACSIMIL DEL CHEQUE-\n\n";
        std::cout << "Nombre del beneficiario: "; std::cin >> Beneficiario;
        std::cout << "Fecha del facsimil. Fecha en formato completo: "; std::cin >> Fecha;
        std::cout << "Girador del facsimil: "; std::cin >> Girador;
        std::cout << "Nombre del banco: "; std::cin >> NombreBanco;
        std::cout << "Direcci" << char(162) << "n del banco: "; std::cin >> DireccionBanco;
        std::cout << "Importe del facsimil: $"; std::cin >> Importe;

        NumTransito = 100000000 + (rand() % 100100000);
        NumCheque = 1000 + (rand() % 2000);
    }
    void GenerarFacsimil()
    {
        system("cls");

        std::cout << "-FACSIMIL DEL CHEQUE-\n\n";
        std::cout << NombreBanco << "\t\t\tFecha de emisi" << char(162) << "n: " << Fecha << "\n";
        std::cout << DireccionBanco << "\n" << Girador << "\n";
        std::cout << "\nPaguese a " << Beneficiario << " la cantidad de $" << std::to_string(Importe) << ".\n";
        std::cout << "\n" << std::to_string(NumTransito) << " - " << std::to_string(NumCheque) << "\n\n";

        system("pause");
    }
};

int main()
{
    Facsimil facsimil;
    facsimil.GenerarDatosFacsimil();
    facsimil.GenerarFacsimil();
}