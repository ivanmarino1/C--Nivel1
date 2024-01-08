#include <iostream>

// Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

int main() {

    int vector[10];
    int acumulador = 0;
    int promedio;

    for (int i = 0; i < 10; i++) {
        std::cout << "Ingresar numero: ";
        std::cin >> vector[i];

        acumulador += vector[i];
    }

    promedio = acumulador / 10;

    std::cout << "El promedio es: " << promedio << std::endl;

    for (int i = 0; i < 10; i++) {
        if (vector[i] > promedio) {
            std::cout << "El numero " << vector[i] << " es mayor al promedio." << std::endl;
        }
    }

    return 0;
}