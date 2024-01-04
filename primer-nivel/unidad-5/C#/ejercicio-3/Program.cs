namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

        int edad;
        int acumulador = 0;
        int mayor_18 = 0;

        for (int i = 0; i < 20; i++) {
            Console.WriteLine("Ingresar tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18) {
                acumulador += edad;
                mayor_18++;
            }
        }

        int promedio;

        promedio = acumulador / mayor_18;

        Console.WriteLine("El promedio de edad de las personas mayores a 18 años es: " + promedio);
    }
}
