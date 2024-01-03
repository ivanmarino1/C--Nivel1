#include <iostream>

// Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

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

    if (numero1 > numero2 && numero2 > numero3 && numero3 > numero4) {
        std::cout << "Estan ordenados de forma decreciente: ";
    } else {
        std::cout << "No estan ordenados...";
    }

    return 0;
}