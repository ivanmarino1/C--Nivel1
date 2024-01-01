namespace ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

        int nota1;
        int nota2;
        int nota3;

        Console.WriteLine("Ingresar nota del primer examen: ");
        nota1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingresar nota del segundo examen: ");
        nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingresar nota del tercer examen: ");
        nota3 = int.Parse(Console.ReadLine());

        int promedio;

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Promedio final: " + promedio); 
    }
}
