#include <iostream>

// Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.

int main() {

    int importe;
    int litros_vendidos;

    std::cout << "Ingresar importe: $";
    std::cin >> importe;

    std::cout << "Ingresar cantidad de litros: ";
    std::cin >> litros_vendidos;

    if (litros_vendidos < 100) {
        std::cout << "No hay descuento, el importe total es: $" << importe;
    } else if (litros_vendidos > 100 && litros_vendidos <= 300) {
        std::cout << "Hay descuento del 10%, el importe total es: $" << importe * 0.90;
    } else if (litros_vendidos > 300 && litros_vendidos <= 500) {
        std::cout << "Hay descuento del 15%, el importe total es: $" << importe * 0.85;
    } else if (litros_vendidos > 500) {
        std::cout << "Hay descuento del 25%, el importe total es: $" << importe * 0.75;
    }

    return 0;
}