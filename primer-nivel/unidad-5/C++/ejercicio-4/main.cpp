#include <iostream>

// Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.

int main() {

    int numero;
    int contador = 0;

    std::cout << "Ingresar numero: ";
    std::cin >> numero;

    for (int i = 1; i <= numero; i++) {
        if (numero % i == 0) {
            contador++;
        }
    }

    if (contador == 2) {
        std::cout << "El numero ingresado es primo.";
    } else {
        std::cout << "El numero ingresado no es primo.";
    }

    return 0;
}