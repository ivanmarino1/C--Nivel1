namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int numero;
        int contador;
        int numero_de_grupo = 0;

        Console.WriteLine("Ingresar numero: ");
        numero = int.Parse(Console.ReadLine());

        do {

            numero_de_grupo++;
            contador = 0;

            Console.WriteLine("Ingresar numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero > 0) {
                contador++;

                Console.WriteLine("Ingresar numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La cantidad de numeros positivos del grupo " + numero_de_grupo + " es: " + contador);

        } while (numero >= 0);
    }
}
