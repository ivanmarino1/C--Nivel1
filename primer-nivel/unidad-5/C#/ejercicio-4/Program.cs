namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        int numero;
        int contador = 0;

        Console.WriteLine("Ingresar numero: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                contador++;
            }
        }

        if (contador == 2) {
            Console.WriteLine("El numero ingresado es primo.");
        } else {
            Console.WriteLine("El numero ingresado no es primo.");
        }
    }
}
