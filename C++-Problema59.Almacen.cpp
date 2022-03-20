#include <iostream>
#include<string>

//El siguiente programa corresponde al problema 59 del capítulo Administración:
//Un almacen tiene un artículo de vestir en bodega, clasificado como pequeño, mediano,
//y grande, en colores rojo, blanco y amarillo. La existencia a mano (por tamaño
//y color) se da en la tabla A, donde las filas representan tamaño y las columnas color.
//El precio por unidad se da también en el mismo esquema de clasificación en la tabla
//B. ¿Qué inventario por tamaño y color debe tener el comerciante a mano en doláres?
//     Tabla A                      Tabla B
//      R   B   A               R       B       A
//P     6   14  2           P   3.95    3.95    4.25
//M     12  22  8           M   4.95    4.95    5.25
//G     7   3   4           G   5.45    5.95    6.5

//Miguel Villegas Luis Enrique; migueluisV
//19 de marzo del 2022

struct Articulo
{
public:
    short CantA;
    double PrecioPA;
    double PrecioDA;
};

void DesplegarDatos(Articulo ar[])
{
    system("cls");
    std::cout << "Tabla cantidad de piezas art" << char(161) << "culos\nTamArt\tR\tB\tA\n";
    std::cout << "C\t" << std::to_string(ar[0].CantA) << "\t" << std::to_string(ar[1].CantA) << "\t" << std::to_string(ar[2].CantA) << "\n";
    std::cout << "C\t" << std::to_string(ar[3].CantA) << "\t" << std::to_string(ar[4].CantA) << "\t" << std::to_string(ar[5].CantA) << "\n";
    std::cout << "C\t" << std::to_string(ar[6].CantA) << "\t" << std::to_string(ar[7].CantA) << "\t" << std::to_string(ar[8].CantA) << "\n";

    std::cout << "\nTabla precio en pesos de piezas art" << char(161) << "culos\nTamArt\tR\tB\tA\n";
    std::cout << "C\t" << std::to_string(ar[0].PrecioPA) << "\t" << std::to_string(ar[1].PrecioPA) << "\t" << std::to_string(ar[2].PrecioPA) << "\n";
    std::cout << "C\t" << std::to_string(ar[3].PrecioPA) << "\t" << std::to_string(ar[4].PrecioPA) << "\t" << std::to_string(ar[5].PrecioPA) << "\n";
    std::cout << "C\t" << std::to_string(ar[6].PrecioPA) << "\t" << std::to_string(ar[7].PrecioPA) << "\t" << std::to_string(ar[8].PrecioPA) << "\n";

    std::cout << "\nTabla precio en d" << char(162) << "lares de piezas art" << char(161) << "culos\nTamArt\tR\tB\tA\n";
    std::cout << "C\t" << std::to_string(ar[0].PrecioDA) << "\t" << std::to_string(ar[1].PrecioDA) << "\t" << std::to_string(ar[2].PrecioDA) << "\n";
    std::cout << "C\t" << std::to_string(ar[3].PrecioDA) << "\t" << std::to_string(ar[4].PrecioDA) << "\t" << std::to_string(ar[5].PrecioDA) << "\n";
    std::cout << "C\t" << std::to_string(ar[6].PrecioDA) << "\t" << std::to_string(ar[7].PrecioDA) << "\t" << std::to_string(ar[8].PrecioDA) << "\n";
}

void IngresarDatos()
{
    const double Dolar = 21.35;
    int Cont = 0;
    Articulo articulos[9];

    system("cls");

    std::cout << "-INGRESAR ARTÍCULOS DE VESTIR A ALMAC" << char(144) << "N-\n\n";
    std::cout << "Ingresa los siguientes datos sobre el art" << char(161) << "culos:\n";
    while (Cont < 9)
    {
        std::cout << "Quedan " << (9 - Cont) << " espacios.\n";
        std::cout << "Cantidad en piezas del art" << char(161) << "culos: "; std::cin >> articulos[Cont].CantA;
        std::cout << "Precio en pesos por unidad del art" << char(161) << "culos: "; std::cin >> articulos[Cont].PrecioPA;

        articulos[Cont].PrecioDA = articulos[Cont].PrecioPA / Dolar;

        std::cout << "\n";
        Cont++;
    }
    DesplegarDatos(articulos);
}

int main()
{
    IngresarDatos();
    
    return 0;
}
