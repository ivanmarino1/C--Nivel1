#include <iostream>

// Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

int main() {

    int numero1;
    int numero2;
    int numero3;

    std::cout << "Ingresar numero 1: ";
    std::cin >> numero1;

    std::cout << "Ingresar numero 2: ";
    std::cin >> numero2;

    std::cout << "Ingresar numero 3: ";
    std::cin >> numero3;

    int suma;
    int producto;

    suma = numero1 + numero2;
    producto = numero2 * numero3;

    if (suma > producto) {
        std::cout << "La suma es mayor a el producto...";
    } else {
        std::cout << "La suma no es mayor al producto...";
    }

    return 0;
}