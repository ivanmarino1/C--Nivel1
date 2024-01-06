namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

        int numero;
        int contador = 0;
        int contador_de_primos = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingresar numero: ");
            numero = int.Parse(Console.ReadLine());

            contador = 0;

            for (int x = 1; x <= numero; x++) {
                if (numero % x == 0) {
                    contador++;
                }
            }

            if (contador == 2) {
                contador_de_primos++;
            }
        }

        Console.WriteLine("La cantidad de primos es: " + contador_de_primos);
    }
}
