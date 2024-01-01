#include <iostream>

// Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

int main() {

    int numero1;
    int numero2;

    std::cout << "Ingresar numero 1: ";
    std::cin >> numero1;

    std::cout << "Ingresar numero 2: ";
    std::cin >> numero2;

    int resultado;
    resultado = numero1 + numero2;

    std::cout << "\nLa suma de los dos numeros da como resultado: " << resultado << std::endl;

    return 0;
}