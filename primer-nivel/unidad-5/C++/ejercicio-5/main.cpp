#include <iostream>

// Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

int main() {

    int numero;
    int maximo = 0;
    int minimo = 0;
    int contador_par = 0;
    int contador_impar = 0;

    for (int i = 0; i < 20; i++) {
        std::cout << "Ingresar numero: ";
        std::cin >> numero;

        if (numero % 2 == 0) {
            contador_par++;
            if (contador_par == 1) {
                maximo = numero;
            } else if (numero > maximo) {
                maximo = numero;
            } 
        } else {
            contador_impar++;
            if (contador_impar == 1) {
                minimo = numero;
            } else if (numero < minimo) {
                minimo = numero;
            }
        }  
    }

    std::cout << "El maximo par es: " << maximo << std::endl;
    std::cout << "El minimo impar es: " << minimo;

    return 0;
}