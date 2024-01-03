namespace ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

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

        if (numero1 > numero2 && numero2 > numero3 && numero3 > numero4) {
            Console.WriteLine("Estan ordenados de forma decreciente: ");
        } else {
            Console.WriteLine("No estan ordenados...");
        }
    }
}
