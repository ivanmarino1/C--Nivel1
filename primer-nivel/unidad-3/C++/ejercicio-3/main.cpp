#include <iostream>

// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.

// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

int main() {

    int importe;

    std::cout << "Ingresar importe de la venta: $";
    std::cin >> importe;

    if (importe < 1000) {
        std::cout << "No hay descuento, el importe final es: $" << importe;
    } else if (importe >= 1000 && importe < 5000) {
        std::cout << "Se aplica un 10% de descuento, el importe final es: $" << importe * 0.90;
    } if (importe >= 5000) {
        std::cout << "Se aplica un 18% de descuento, el importe final es: $" << importe * 0.82;
    }

    return 0;
}