#include <iostream>

// Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

int main() {

    int numero;

    std::cout << "Ingresar numero: ";
    std::cin >> numero;

    int cubo;
    cubo = numero * numero * numero;

    std::cout << "\nNumero elevado al cubo: " << cubo << std::endl;

    return 0;
}