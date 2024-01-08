﻿namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 

        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.

        int numero_de_articulo;
        int cantidad_vendida;

        int [] total_cantidad_vendidas = new int [15];

        for (int i = 0; i < 15; i++) {
            total_cantidad_vendidas[i] = 0;
        }

        Console.WriteLine("Ingrese el numero de articulo: ");
        numero_de_articulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad vendida: ");
        cantidad_vendida = int.Parse(Console.ReadLine());

        while (numero_de_articulo != 0) {

            total_cantidad_vendidas[numero_de_articulo - 1] += cantidad_vendida;

            Console.WriteLine("Ingrese el numero de articulo: ");
            numero_de_articulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad_vendida = int.Parse(Console.ReadLine());
        }

        //Punto A)
        int maximo_articulo = total_cantidad_vendidas[0];
        int posicion_maximo = 1;

        for (int i = 0; i < 15; i++) {
            if (total_cantidad_vendidas[i] > maximo_articulo) {
                maximo_articulo = total_cantidad_vendidas[i];
                posicion_maximo = i + 1;
            }
        }

        Console.WriteLine("El producto mas vendido es el: " + posicion_maximo + " con la cantidad de: " + maximo_articulo);

        //Punto B)
        for (int i = 0; i < 15; i++) {
            if (total_cantidad_vendidas[i] == 0) {
                Console.WriteLine("El producto " + (i + 1) " no tuvo ventas");
            }
        }

        //Punto C)
        Console.WriteLine("La cantidad vendida del articulo es: " + total_cantidad_vendidas[9]);
    }
}
