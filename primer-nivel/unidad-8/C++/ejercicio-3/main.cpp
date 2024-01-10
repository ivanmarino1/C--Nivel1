#include <iostream>

// Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

bool primo (int numero);

int main() {

    int numero;
    int promedio;
    int contador_primos = 0;
    int acumulador_primos = 0;

    std::cout << "Ingrese un numero: ";
    std::cin >> numero;
 
    while (numero != 0) {
        if (primo(numero)) {
            contador_primos++;
            acumulador_primos += numero;
        }

        std::cout << "Ingrese otro numero: ";
        std::cin >> numero;
    }

    promedio = acumulador_primos / contador_primos;

    std::cout << "El promedio de los primos es: " << promedio;

    return 0;
}

bool primo (int numero) {
    int contador = 0;
    for (int i = 1; i <= numero; i++) {
       if (numero % i == 0) {
            contador++;
        }
    }
    if (contador == 2) {
        return true;
    } else {
        return false;
    }
}