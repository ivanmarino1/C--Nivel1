namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

        // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int numero;
        int minimo;
        int contador_numeros = 0;
        int contador_impares = 0;
        int contador_ordenados = 0;
        int grupo_impar_maximo = 0;
        float porcentaje_impares;
        float porcentaje_maximo = 0;
        bool numeros_ordenados;

        for (int i = 0; i < 5; i++) {

            contador_numeros = 0;
            contador_impares = 0;
            numeros_ordenados = true;

            Console.WriteLine("Ingresar numero: ");
            numero = int.Parse(Console.ReadLine());

            minimo = numero;

            while (numero != 0) {
                
                contador_numeros++;

                if (numero % 2 != 0) {
                    contador_impares++;
                }

                if (numero <= minimo) {
                    minimo = numero;
                } else {
                    numeros_ordenados = false;
                }

                Console.WriteLine("Ingresar numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            porcentaje_impares = contador_impares * 100 / contador_numeros;

            if (porcentaje_impares > porcentaje_maximo) {
                porcentaje_maximo = porcentaje_impares;
                grupo_impar_maximo = i + 1;
            }

            if (numeros_ordenados) {
                contador_ordenados++;
            }
        }

        Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupo_impar_maximo);
        Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + contador_ordenados);
    }
}
