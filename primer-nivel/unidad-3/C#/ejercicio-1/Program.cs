﻿namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

        int numero;

        Console.WriteLine("Ingresar numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 10 ) {
            Console.WriteLine("Es mayor a 10");
        } else {
            Console.WriteLine("No es mayor a 10");
        }
    }
}
