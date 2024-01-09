#include <iostream>

// Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

int producto(int numero1, int numero2);

int main() {

    int numero1;
    int numero2;

    std::cout << "Ingrese el primer numero: ";
    std::cin >> numero1;

    std::cout << "Ingrese el segundo numero: ";
    std::cin >> numero2;

    int resultado;

    resultado = producto(numero1, numero2);

    std::cout << "El resultado de la multiplicacion seria: " << resultado << std::endl;

    return 0;
}

int producto(int numero1, int numero2) {
    int resultado = numero1 * numero2;
    return resultado;
}