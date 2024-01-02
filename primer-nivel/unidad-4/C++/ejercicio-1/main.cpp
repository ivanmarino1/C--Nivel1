#include <iostream>

// Hacer un programa que solicite el ingreso de dos números y luego calcular:

// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.

// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

int main() {

    int numero1;
    int numero2;

    std::cout << "Ingresar numero 1: ";
    std::cin >> numero1;

    std::cout << "Ingresar numero 2: ";
    std::cin >> numero2;

    if (numero1 > numero2) {
        std::cout << "El primer numero es mayor al segundo | RESTA: " << numero1 - numero2;
    }

    if (numero1 == numero2) {
        std::cout << "Los dos numeros son iguales | SUMA: " << numero1 + numero2;
    }

    if (numero1 < numero2) {
        std::cout << "El primer numero es menor al segundo | MULTIPLICACION: " << numero1 * numero2;
    }

    return 0;
}