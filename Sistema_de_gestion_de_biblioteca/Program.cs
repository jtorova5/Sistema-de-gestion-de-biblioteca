using Sistema_de_gestion_de_biblioteca.Models;

Console.Clear();

Libro libro = new Libro("100 años de soledad", new DateOnly(1967, 05, 15), "Gabriel García Márquez", "Novela", 68000);
Libro libro2 = new Libro("Romeo y Julieta", new DateOnly(1597, 06, 15), "William Shakespeare", "Tragedia", 54000);
Libro libro3 = new Libro("El principito", new DateOnly(1943, 04, 06), "Antoine de Saint-Exupéry", "Fábula", 47500);


Biblioteca biblioteca = new Biblioteca();
biblioteca.libros.Add(libro);
biblioteca.libros.Add(libro2);
biblioteca.libros.Add(libro3);

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





