#include <iostream>

// Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

int main() {

    int vector[10] = {0};

    for (int i = 0; i < 10; i++) {
        std::cout << "Ingresar numero: ";
        std::cin >> vector[i];
    }

    int maximo = vector[0];
    int posicion = 0;

    for (int i = 0; i < 10; i++) {
        if (vector[i] >= maximo) {
            maximo = vector[i];
            posicion = i + 1;
        }
    }

    std::cout << "El numero maximo del vector es: " << maximo << " y su posicion es: " << posicion;

    return 0;
}