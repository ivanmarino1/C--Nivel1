namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

        // Si vende menos de 100 litros, no hay descuento.
        // Si vende entre 101 y 300 litros, el descuento es del 10%.
        // Si vende entre 301 y 500 litros, el descuento es del 15%.
        // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.

        int importe;
        int litros_vendidos;

        Console.WriteLine("Ingresar importe: $");
        importe = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar cantidad de litros: ");
        litros_vendidos = int.Parse(Console.ReadLine());

        if (litros_vendidos < 100) {
            Console.WriteLine("No hay descuento, el importe total es: $" + importe);
        } else if (litros_vendidos > 100 && litros_vendidos <= 300) {
            int descuento_10 = importe * 0.90;
            Console.WriteLine("Hay descuento del 10%, el importe total es: $" + descuento_10);
        } else if (litros_vendidos > 300 && litros_vendidos <= 500) {
            int descuento_15 = importe * 0.85;
            Console.WriteLine("Hay descuento del 15%, el importe total es: $" + descuento_15);
        } else if (litros_vendidos > 500) {
            int descuento_25 = importe * 0.75;
            Console.WriteLine("Hay descuento del 25%, el importe total es: $" + descuento_25);
        }
    }
}
