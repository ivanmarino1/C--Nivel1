namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        int numero;
        int estado = 5;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        positivoNegativoCero(numero, ref estado);

        Console.WriteLine("El estado del valor " + numero + " es: " + estado);
    }

    static bool positivoNegativoCero (int numero, ref int estado) {
        if (numero > 0) {
            estado = 1;
        } else if (numero == 0) {
            estado = 0;
        } else {
            estado = -1;
        }
    }
}
