namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

        int numero;
        int promedio;
        int contador_primos = 0;
        int acumulador_primos = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0) {
            if (primo(numero)) {
                contador_primos++;
                acumulador_primos += numero;
            }

            Console.WriteLine("Ingrese otro numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        promedio = acumulador_primos / contador_primos;

        Console.WriteLine("El promedio de los primos es: " + promedio);
    }

        static bool primo (int numero) {
        int contador = 0;
        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                contador++;
            }
        }
        if (contador == 2) {
            return true;
        } else {
            return false;
        }
    }
}
