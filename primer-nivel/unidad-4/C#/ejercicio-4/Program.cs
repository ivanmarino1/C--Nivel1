namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        int numero1;
        int numero2;
        int numero3;

        Console.WriteLine("Ingresar numero 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 2: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 3: ");
        numero3 = int.Parse(Console.ReadLine());

        int suma;
        int producto;

        suma = numero1 + numero2;
        producto = numero2 * numero3;

        if (suma > producto) {
            Console.WriteLine("La suma es mayor a el producto...");
        } else {
            Console.WriteLine("La suma no es mayor al producto...");
        }
    }
}
