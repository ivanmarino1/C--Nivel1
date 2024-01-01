#include <iostream>

// Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

int main() {

    int numero;

    std::cout << "Ingresar numero: ";
    std::cin >> numero;

    if (numero > 0) {
        std::cout << "Positivo";
    } else if (numero < 0) {
        std::cout << "Negativo";
    } else {
        std::cout << "Cero";
    }

    return 0;
}