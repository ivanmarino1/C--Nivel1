#include <iostream>

// Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

int main() {

    int nota1;
    int nota2;
    int nota3;

    std::cout << "Ingresar nota del primer examen: ";
    std::cin >> nota1;
    
    std::cout << "Ingresar nota del segundo examen: ";
    std::cin >> nota2;
    
    std::cout << "Ingresar nota del tercer examen: ";
    std::cin >> nota3;

    int promedio;

    promedio = (nota1 + nota2 + nota3) / 3;

    std::cout << "\nPromedio final: " << promedio << std::endl;

    return 0;
}