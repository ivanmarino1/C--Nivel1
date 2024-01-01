#include <iostream>

// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

int main() {

    float distancia_kilometros;
    float velocidad;

    std::cout << "Ingresar la distancia: ";
    std::cin >> distancia_kilometros;
    
    std::cout << "Ingresar la velocidad promedio: ";
    std::cin >> velocidad;

    float resultado;
    resultado = distancia_kilometros / velocidad;

    std::cout << "\nEl tiempo aproximado para llegar de un punto a otro es: " << resultado << " horas." << std::endl;

    return 0;
}