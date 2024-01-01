#include <iostream>

// Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

int main() {

    float total_facturado;
    const float sueldo_fijo = 15000;
    const float porcentaje_comision = 0.05F;

    std::cout << "Total facturado: $";
    std::cin >> total_facturado;

    float comision;
    float sueldo_final;

    comision = total_facturado * porcentaje_comision;

    sueldo_final = sueldo_fijo + comision;

    std::cout << "\nEl sueldo final es: $" << sueldo_final << std::endl;

    return 0;
}