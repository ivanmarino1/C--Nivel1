namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

        int numero;
        int maximo = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingresar numero: ");
            numero = int.Parse(Console.ReadLine());

            if (i == 0) {
                maximo = numero;
            }

            if (numero > maximo) {
                maximo = numero;
            }
        }

        Console.WriteLine("El numero mas grande es: " + maximo);
    }
}
