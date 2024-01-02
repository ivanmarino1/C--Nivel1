#include <iostream>

// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

int main() {

    int numero1;
    int numero2;
    int numero3;
    int numero4;

    std::cout << "Ingresar numero 1: ";
    std::cin >> numero1;

    std::cout << "Ingresar numero 2: ";
    std::cin >> numero2;

    std::cout << "Ingresar numero 3: ";
    std::cin >> numero3;

    std::cout << "Ingresar numero 4: ";
    std::cin >> numero4;

    if (numero1 > 100) {
        std::cout << "El numero: " << numero1 << " es mayor a 100" << std::endl;
    }

    if (numero2 > 100) {
        std::cout << "El numero: " << numero2 << " es mayor a 100" << std::endl;
    }

    if (numero3 > 100) {
        std::cout << "El numero: " << numero3 << " es mayor a 100" << std::endl;
    }

    if (numero4 > 100) {
        std::cout << "El numero: " << numero4 << " es mayor a 100" << std::endl;
    }

    return 0;
}