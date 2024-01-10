namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int numero;
        int contador = 0;

        for (int i = 0; i < 20; i++) {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (par(numero)) {
                contador++;
            }
        }

        Console.WriteLine("La cantidad de numeros pares es: " + contador);
    }

    static bool par (int numero) {
        if (numero % 2 == 0) {
            return true;
        } else {
            return false;
        }
    }
}
