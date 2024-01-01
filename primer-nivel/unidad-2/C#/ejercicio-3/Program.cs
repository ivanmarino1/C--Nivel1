namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

        float distancia_kilometros;
        float velocidad;

        Console.WriteLine("Ingrese la distancia: ");
        distancia_kilometros = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la velocidad promedio: ");
        velocidad = float.Parse(Console.ReadLine());

        float resultado = distancia_kilometros / velocidad;

        Console.WriteLine("El tiempo aproximado para llegar de un punto a otro es: " + resultado.ToString("0.0") + " horas.");

    }
}
