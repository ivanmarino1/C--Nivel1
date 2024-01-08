#include <iostream>

// Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.

int main() {

    int numero_de_articulo;
    int cantidad_vendida;

    int total_cantidad_vendidas[15]; 

    for (int i = 0; i < 15; i++) {
        total_cantidad_vendidas[i] = 0;
    }

    std::cout << "Ingrese el numero de articulo: ";
    std::cin >> numero_de_articulo;

    std::cout << "Ingrese la cantidad vendida: ";
    std::cin >> cantidad_vendida;

    while (numero_de_articulo != 0) {

        total_cantidad_vendidas[numero_de_articulo - 1] += cantidad_vendida; 

        std::cout << "Ingrese el numero de articulo: ";
        std::cin >> numero_de_articulo;

        std::cout << "Ingrese la cantidad vendida: ";
        std::cin >> cantidad_vendida;

    }

    //Punto A)
    int maximo_articulo = total_cantidad_vendidas[0];
    int posicion_maximo = 1;

    for (int i = 0; i < 15; i++) {
        if (total_cantidad_vendidas[i] > maximo_articulo) {
            maximo_articulo = total_cantidad_vendidas[i];
            posicion_maximo = i + 1;
        }
    }

    std::cout << "El producto mas vendido es el: " << posicion_maximo << " con la cantidad de: " << maximo_articulo << std::endl;

    //Punto B)
    for (int i = 0; i < 15; i++) {
        if (total_cantidad_vendidas[i] == 0) {
            std::cout << "El producto " << i + 1 << " no tuvo ventas" << std::endl; 
        }
    }

    //Punto C)
    std::cout << "La cantidad vendida del articulo es: " << total_cantidad_vendidas[9];

    return 0;
}