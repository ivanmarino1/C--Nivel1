#include <iostream>

// Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.

void positivoNegativoCero(int numero, int& estado);

int main() {
    int numero;
    int estado = 5;

    std::cout << "Ingrese un numero: ";
    std::cin >> numero;

    positivoNegativoCero(numero, estado);

    std::cout << "El estado del valor " << numero << " es: " << estado << std::endl;

    return 0;
}

void positivoNegativoCero(int numero, int& estado) {
    if (numero > 0) {
        estado = 1;
    } else if (numero == 0) {
        estado = 0;
    } else {
        estado = -1;
    }
}