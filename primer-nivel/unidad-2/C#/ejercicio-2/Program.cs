namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

        int numero;

        Console.WriteLine("Ingresar numero: ");
        numero = int.Parse(Console.ReadLine());

        int cubo;
        cubo = numero * numero * numero;

        Console.WriteLine("Numero elevado al cubo: " + cubo);
    }
}
