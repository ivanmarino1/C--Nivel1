#include <iostream>

// Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"

int main() {

    char frase[30];
    char letra;
    char letra_actual;
    char letra_nueva;

    int indice = 0;
    
    std::cout << "Ingresar una letra para la frase: ";
    std::cin >> letra;

    while (letra != '0' && indice < 30) {
        frase[indice] = letra;

        std::cout << "Ingresar otra letra para la frase: ";
        std::cin >> letra;

        indice++;
    }

    frase[indice] = '\0';
    
    std::cout << "La frase completa es: ";
    indice = 0;

    while (frase[indice] != '\0') {
        std::cout << frase[indice];
        indice++;
    }

    std::cout << std::endl;

    std::cout << "Ingrese letra a reemplazar: ";
    std::cin >> letra_actual;

    std::cout << "Ingrese la letra nueva: ";
    std::cin >> letra_nueva;

    indice = 0;

    while (frase[indice] != '\0') {
        if (frase[indice] == letra_actual) {
            frase[indice] == letra_nueva;
        }
        indice++;
    }

    std::cout << "La frase nueva es: ";
    indice = 0;

    while (frase[indice] != '\0') {
        std::cout << frase[indice];
        indice++;
    }

    return 0;
}