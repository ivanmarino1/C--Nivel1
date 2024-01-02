namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite el ingreso de dos números y luego calcular:

        // La resta si el primero es mayor que el segundo.
        // La suma si son iguales.
        // El producto si el primero es menor.

        // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

        int numero1;
        int numero2;

        Console.WriteLine("Ingresar numero 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 2: ");
        numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2) {
            int resta = numero1 - numero2;
            Console.WriteLine("El primer numero es mayor al segundo | RESTA: " + resta);
        }

        if (numero1 == numero2) {
            int suma = numero1 + numero2;
            Console.WriteLine("Los dos numeros son iguales | SUMA: "+ suma);
        }

        if (numero1 < numero2) {
            int multiplicacion = numero1 * numero2;
            Console.WriteLine("El primer numero es menor al segundo | MULTIPLICACION: " + multiplicacion);
        }
    }
}
