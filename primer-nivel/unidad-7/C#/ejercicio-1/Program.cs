namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int[] vector = new int [10];

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingresar numero: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        int maximo = vector[0];
        int posicion = 0;

        for (int i = 0; i < 10; i++) {
            if (vector[i] >= maximo) {
                maximo = vector[i];
                posicion = i + 1;
            }
        }

        Console.ReadLine("El numero maximo del vector es: " + maximo + " y su posicion es: " + posicion);
    }
}
