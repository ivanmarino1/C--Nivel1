namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

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

        int menor;

        menor = numero1;

        if (numero2 < menor) {
        menor = numero2;
        } 

        if (numero3 < menor) {
            menor = numero3;
        }

        if (numero4 < menor) {
            menor = numero4;
        }

        Console.WriteLine("El numero mas chico es: " + menor);
    }
}
