#include <iostream>

// Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

int main() {

    int numero;
    int contador;
    int numero_de_grupo = 0;

    std::cout << "Ingresar numero: ";
    std::cin >> numero;

    do {

        numero_de_grupo++;
        contador = 0;

        std::cout << "Ingresar numero: ";
        std::cin >> numero;

        while (numero > 0) {
            contador++;

            std::cout << "Ingresar numero: ";
            std::cin >> numero;
        }

        std::cout << "La cantidad de numeros positivos del grupo " << numero_de_grupo << " es: " << contador << std::endl;

    } while (numero >= 0);

    return 0;
}