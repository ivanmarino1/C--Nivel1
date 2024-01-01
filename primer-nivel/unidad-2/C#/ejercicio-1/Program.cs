namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
        
        int numero1;
        int numero2;
        
        Console.WriteLine("Ingresar numero 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar numero 2: ");
        numero2 = int.Parse(Console.ReadLine());

        int resultado;
        resultado = numero1 + numero2;

        Console.WriteLine("La suma de los dos numeros da como resultado: " + resultado);
    }
}
