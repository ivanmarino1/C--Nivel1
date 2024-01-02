#include <iostream>

// Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

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

    int menor;

    menor = numero1;

    if (numero2 < menor) {
        menor = numero2;
    } 

    if (numero3 < menor) {
        menor = numero3;
    }

    if (numero4 < menor) {
        menor = numero4;
    }

    std::cout << "El numero mas chico es: " << menor;

    return 0;
}