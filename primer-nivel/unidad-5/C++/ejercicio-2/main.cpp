#include <iostream>

// Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

int main() {

    int numero;
    int maximo;

    for (int i = 0; i < 10; i++) {
        std::cout << "Ingresar numero: ";
        std::cin >> numero;

        if (i == 0) {
            maximo = numero;
        }

        if (numero > maximo) {
            maximo = numero;
        }
    }

    std::cout << "El numero mas grande es: " << maximo;

    return 0;
}