namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int[] vector = new int [10];
        int acumulador = 0;
        int promedio;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingresar numero: ");
            vector[i] = int.Parse(Console.ReadLine());

            acumulador += vector[i];
        }

        promedio = acumulador / 10;

        Console.WriteLine("El promedio es: " + promedio);

        for (int i = 0; i < 10; i++) {
            if (vector[i] > promedio) {
                Console.WriteLine("El numero " + vector[i] + " es mayor al promedio.");
            }
        }
    }
}
