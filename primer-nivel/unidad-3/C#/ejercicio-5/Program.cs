namespace ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

        int numero1;
        int numero2;
        int numero3;
        int numero4;

        Console.WriteLine("Ingresar numero 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 2: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 3: ");
        numero3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 4: ");
        numero4 = int.Parse(Console.ReadLine());

        if (numero1 > 100) {
            Console.WriteLine("El numero: " + numero1 + " es mayor a 100");
        }

        if (numero2 > 100) {
            Console.WriteLine("El numero: " + numero2 + " es mayor a 100");
        }

        if (numero3 > 100) {
            Console.WriteLine("El numero: " + numero3 + " es mayor a 100");
        }

        if (numero4 > 100) {
            Console.WriteLine("El numero: " + numero4 + " es mayor a 100");
        }
    }
}
