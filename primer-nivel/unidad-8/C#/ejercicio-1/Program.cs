namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

        int numero1;
        int numero2;

        Console.WriteLine("Ingrese el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());

        int resultado;

        resultado = producto(numero1, numero2);

        Console.WriteLine("El resultado de la multiplicacion seria: " + resultado);
    }

    static int producto (int numero1, int numero2) {
        int resultado = numero1 * numero2;
        return resultado;
    }
}
