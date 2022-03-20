#include <iostream>
#include <string>

//El siguiente programa corresponde al problema 60 del capítulo Administración:
//Al Sr. López se le ofrece un empleo en una planta manufacturera y se le da la
//oportunidad de seleccionar dos formas de recibir su salario. Puede recibir su
//sueldo mensual de $500 y un aumento de $5 mensual o bien, un salario mensual
//de $500 con un aumento anual de $80. Redactar un programa para determinar los
//salarios mensuales para los 10 años próximos en cada caso. El programa deter-
//minará los salarios acumulativos despuéa de cada mes y, de esa información
//decidirá cuál método de pago es mejor

//Miguel Villegas Luis Enrique; migueluisv
//19 de marzo del 2022

void Menu();
void DesplegarSalario(double);

void Menu()
{
    char Op;

    system("cls");

    std::cout << "-SALARIO MENSUAL Y ANUAL EN MANUFACTURERA-\n\n";
    std::cout << "Paquete A - $500 mensual m" << char(160) << "aumento de $5 por mes.\n";
    std::cout << "Paquete B - $500 mensual m" << char(160) << "aumento de $80 por a" << char(164) << "o.\n";
    std::cout << char(168) << "Qu" << char(130) << " opci" << char(162) << "n desea? A/B: "; std::cin >> Op;
    std::toupper(Op);
    if (Op == 'A')
        DesplegarSalario((double)5);
    else
        DesplegarSalario((double)80 / (double)12);
}

void DesplegarSalario(double aumento)
{
    double Salario = 500;
    int i, j;
    std::string Meses[12] = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    double SalarioAnual[10] = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

    system("cls");

    for (i = 1; i <= 10; i++)
    {
        std::cout << "El " << std::to_string(i) << char(167) << " a" << char(164) << "o trabajando en la manufacturera tendr" << char(160) << "s los siguientes salarios con aumento:\n";
        for (j = 0; j < 12; j++)
        {
            std::cout << Meses[j] << "\t\t-\t" << std::to_string(Salario) << "\n";
            Salario += aumento;
            SalarioAnual[i - 1] += Salario;
        }
        std::cout << "\n";
    }

    std::cout << "\n-TABLA DE SALARIOS ANUALES DURANTE 10 A" << char(165) << "OS-\n";
    std::cout << "Estos son los salarios totales que recibir" << char(161) << "as cada a" << char(164) << "o:\n\n";
    std::cout << "A" << char(164) << "o\t\tSalario acumulado\n";
    for (i = 1; i <= 10; i++)
    {
        std::cout << std::to_string(i) << "\t\t" << std::to_string(SalarioAnual[i - 1]) << "\n";
    }
    std::cout << "\nPresiona cualquier tecla para regresar al men" << char(163) << ".\n";
    system("pause");
    Menu();
}

int main()
{
    Menu();
    
    return 0;
}
