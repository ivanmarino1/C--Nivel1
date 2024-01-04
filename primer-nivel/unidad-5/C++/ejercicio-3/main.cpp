#include <iostream>

// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

int main() {

    int edad;
    int acumulador = 0;
    int mayor_18 = 0;

    for (int i = 0; i < 20; i++) {
        std::cout << "Ingresar tu edad: ";
        std::cin >> edad;

        if (edad > 18) {
            acumulador += edad;
            mayor_18++;
        }
    }

    int promedio;

    promedio = acumulador / mayor_18;

    std::cout << "El promedio de edad de las personas mayores a 18 años es: " << promedio;

    return 0;
}