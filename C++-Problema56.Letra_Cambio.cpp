#include <iostream>
#include<ctime>
#include<string>

//El siguiente programa corresponde al problema 56 del capítulo Administración:
//Generar un programa que imprima letras de cambio mensuales para una compañia
//de tarjetas de crédito. Debe agregar pagos hechos en el mes anterior; resta
//el costo de compras realizadas y sustraer un cargo financiero mensual del 1.5%
//sobre el balance no pagado.

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

class LetraCambio
{
private:
    std::string Librador, Librado, FechaEmision, FechaPago, LugarPago, Moneda;
    double CantidadPago = 0.0;
    int MesesRetraso = 0;
    double PagosMensuales[10];
public:
    ~LetraCambio(){}
    std::string FormatoFecha(int dia, int diames, int mes, int a)
    {
        std::string FechaCompleta = "";
        int y;

        if (a < 1000)
            y = a + 1900;
        else
            y = a;

        switch (dia)
        {
        case 0:
            FechaCompleta += "Domingo, ";
            break;
        case 1:
            FechaCompleta += "Lunes, ";
            break;
        case 2:
            FechaCompleta += "Martes, ";
            break;
        case 3:
            FechaCompleta += "Miercoles, ";
            break;
        case 4:
            FechaCompleta += "Jueves, ";
            break;
        case 5:
            FechaCompleta += "Viernes, ";
            break;
        case 6:
            FechaCompleta += "Sabado, ";
            break;
        }
        FechaCompleta += std::to_string(diames);
        switch (mes)
        {
        case 0:
            FechaCompleta += " de enero del ";
            break;
        case 1:
            FechaCompleta += " de febrero del ";
            break;
        case 2:
            FechaCompleta += " de marzo del ";
            break;
        case 3:
            FechaCompleta += " de abril del ";
            break;
        case 4:
            FechaCompleta += " de mayo del ";
            break;
        case 5:
            FechaCompleta += " de junio del ";
            break;
        case 6:
            FechaCompleta += " de julio del ";
            break;
        case 7:
            FechaCompleta += " de agosto del ";
            break;
        case 8:
            FechaCompleta += " de septiembre del ";
            break;
        case 9:
            FechaCompleta += " de octubre del ";
            break;
        case 10:
            FechaCompleta += " de noviembre del ";
            break;
        case 11:
            FechaCompleta += " de diciembre del ";
            break;
        }
        return FechaCompleta += std::to_string(y);
    }
    void ValoresPagosMensuales()
    {
        int Pos = -1;
        char Op = 's';

        system("cls");

        std::cout << "-PAGOS PREVIOS DE LA LETRA-\n\n";
        std::cout << "Registra pagos con a tarjeta que se hayan hecho meses antes de la realizaci" << char(162) << "n de la letra:\n";
        while (Op=='s' && Pos < 9)
        {
            Pos++;
            std::cout << "\nQuedan " << 10 - Pos << " espacios.\n";
            std::cout << "Cantidad pagada: "; std::cin >> PagosMensuales[Pos];
            CantidadPago += PagosMensuales[Pos];
            std::cout << char(168) << "Agregar otro pago? [s/n]: "; std::cin >> Op;
        }

        system("cls");

        struct tm tapersonalizado;
        time_t ahora = time(0);
        localtime_s(&tapersonalizado, &ahora);
        FechaEmision = FormatoFecha(tapersonalizado.tm_wday, tapersonalizado.tm_mday, tapersonalizado.tm_mon, tapersonalizado.tm_year);

        std::cout << "-PAGOS PREVIOS DE LA LETRA-\n\n";
        std::cout << "Fecha actual: " << FechaEmision << "\n";
        std::cout << "N" << char(163) << "mero de meses que pasaron desde que se hicieron las anteriores compras: ";
        std::cin >> MesesRetraso;

        system("cls");
        DesplegarPagosMensuales(Pos);
    }
    void DesplegarPagosMensuales(int pos)
    {
        int i;

        std::cout << "-PAGOS PREVIOS DE LA LETRA-\n\n";
        for (i = 0; i <= pos; i++)
        {
            std::cout << (i + 1) << "- " << PagosMensuales[i] << "\n";
        }
        std::cout << "Total de los pagos sin inter" << char(130) << "s mensual: " << CantidadPago << "\n";
    }
    void ValoresCarta()
    {
        int i, Interes;
        struct tm fechapago;

        system("cls");

        std::cout << "-DATOS DE LA LETRA-\n\n";
        std::cout << "Nombre del librado: "; std::cin >> Librado;
        std::cout << "Nombre del librador: "; std::cin >> Librador;
        std::cout << "D" << char(161) << "a de la semana del pago. Domingo a lunes. 1-7: "; std::cin >> fechapago.tm_wday;
        std::cout << "D" << char(161) << "a del mes del pago. 1 - 31: "; std::cin >> fechapago.tm_mday;
        std::cout << "Mes del pago. 1 - 12: "; std::cin >> fechapago.tm_mon;
        std::cout << "A" << char(164) << "o del pago: "; std::cin >> fechapago.tm_year;
        std::cout << "Lugar acordado para el pago. Ciudad-Estado-Pa" << char(161) << "s: "; std::cin >> LugarPago;
        std::cout << "Moneda en la cual se efectuar" << char(160) << " el pago: "; std::cin >> Moneda;

        FechaPago = FormatoFecha(fechapago.tm_wday - 1, fechapago.tm_mday, fechapago.tm_mon - 1, fechapago.tm_year);
        Interes = abs(fechapago.tm_mon - MesesRetraso);
        MesesRetraso += Interes;
        for (i = 1; i <= MesesRetraso; i++)
        {
            CantidadPago += (CantidadPago * 0.015);
        }
    }
    void GenerarCarta()
    {
        std::cout << "\n\n-LETRA DE CAMBIO-\n\n";
        std::cout << "La presente carta, emitida el d" << char(161) << "a " << FechaEmision << " en " << LugarPago << ", la persona " << Librado << "\n";
        std::cout << "se compromete a pagar el d" << char(161) << "a " << FechaPago << ", a la \n";
        std::cout << "orden de " << Librador << " la cantidad de " << std::to_string(CantidadPago) << " " << Moneda << ", el cual incluye un inter" << char(130) << "s \n";
        std::cout << "mensual del 1.5%, con una cantidad de " << std::to_string(MesesRetraso) << " meses de retraso.";
    }
};

int main()
{
    LetraCambio letracambio;
    letracambio.ValoresPagosMensuales();
    system("pause");
    letracambio.ValoresCarta();
    letracambio.GenerarCarta();
}