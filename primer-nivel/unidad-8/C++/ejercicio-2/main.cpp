#include <iostream>

// Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

bool par (int numero);

int main() {

    int numero;
    int contador = 0;

    for (int i = 0; i < 20; i++) {
        std::cout << "Ingrese un numero: ";
        std::cin >> numero;
        if (par(numero)) {
            contador++;
        }
    }

    std::cout << "La cantidad de numeros pares es: " << contador;

    return 0;
}

bool par (int numero) {
    if (numero % 2 == 0) {
        return true;
    } else {
        return false;
    }
}