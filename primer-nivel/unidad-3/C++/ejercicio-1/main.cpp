#include <iostream>

// Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

int main() {

    int numero;

    std::cout << "Ingresar numero: ";
    std::cin >> numero;

    if (numero > 10) {
        std::cout << "Es mayor a 10";
    } else {
        std::cout << "No es mayor a 10";
    }

    return 0;
}