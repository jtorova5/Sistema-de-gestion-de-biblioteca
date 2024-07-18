﻿using Sistema_de_gestion_de_biblioteca.Models;

Console.Clear();

Libro libro = new Libro("Librito", new DateOnly(1990, 10, 03), "Gabito", "Comedia", 25000);
Biblioteca biblioteca = new Biblioteca();
biblioteca.libros.Add(libro);

void MostrarLibros()
{
    Console.Clear();
    biblioteca.MostrarLibros();
    Console.Write(@"

Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void AgregarLibro()
{
    Console.Clear();
    Console.WriteLine(@"Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void EliminarLibro()
{
    Console.Clear();
    Console.WriteLine(@"Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void Salir()
{
    Console.Clear();
    Console.WriteLine(@"-----------------------------------------------------------------------------------------------

Saliendo del programa...
Gracias por usar el sistema de gestión de bibliotecas.

----------------------------------------------------------------------------------------------");
    Environment.Exit(0);
}

void Main()
{
    Console.Write(@"###############################################################################################
#                                        BIBLIOTECA                                           #
###############################################################################################
1. Mostrar libros
2. Agregar libro
3. Eliminar libro
4. Salir
-----------------------------------------------------------------------------------------------
INGRESE OPCIÓN: ");
    byte accion = Convert.ToByte(Console.ReadLine());
    switch (accion)
    {
        case 1:
            MostrarLibros();
            break;
        case 2:
            AgregarLibro();
            break;
        case 3:
            EliminarLibro();
            break;
        case 4:
            Salir();
            break;
        default:
            Main();
            break;
    }
}

Main();





