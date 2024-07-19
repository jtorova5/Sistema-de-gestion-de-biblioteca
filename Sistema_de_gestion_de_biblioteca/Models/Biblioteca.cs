using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Sistema_de_gestion_de_biblioteca.Models;

public class Biblioteca
{
    public List<Libro> libros;

    public Biblioteca()
    {
        libros = new List<Libro>();
    }

    public void MostrarLibros()
    {
        var vistaLibros = libros.Select(libro => new
        {
            titulo = libro.Titulo,
            autor = libro.Autor,
            isbn = libro.ISBN,
            año = libro.AñoPublicacion,
            genero = libro.Genero
        }).ToList();

        Console.WriteLine(@$"###############################################################################################
#                                   LISTADO DE LIBROS                                         #
###############################################################################################
| Nro |        Título        |          Autor          |                 ISBN                 |
-----------------------------------------------------------------------------------------------");
        int i = 1;
        foreach (var item in vistaLibros)
        {
            Console.WriteLine(@$"|  {i,-3}| {item.titulo,-21}| {item.autor,-24}| {item.isbn,-37}|");
            i++;
        }
        Console.WriteLine(@"-----------------------------------------------------------------------------------------------");
    }

    public Libro? libroEncontrado;
    public void Descripcionlibro()
    {
        do
        {
            Console.Write(@"
Ingrese el título del libro que desea ver: ");
            string vistaLibro = Console.ReadLine().ToLower().Trim();

            libroEncontrado = libros.FirstOrDefault(libro => libro.Titulo == vistaLibro);

            if (libroEncontrado != null)
            {
                Console.WriteLine($@"
-----------------------------------------------------------------------------------------------

Título: {libroEncontrado.Titulo}
Autor: {libroEncontrado.Autor}
Género: {libroEncontrado.Genero}
Año: {libroEncontrado.AñoPublicacion}
ISBN: {libroEncontrado.ISBN}
Precio: ${libroEncontrado.Precio.ToString("#,##0.00")}

-----------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El libro no se encontró en la lista. Intente nuevamente.");
            }

        } while (libroEncontrado == null);
    }

    public void AgregarLibro()
    {
        Console.Write(@"-----------------------------------------------------------------------------------------------
                                        AGREGAR LIBRO
-----------------------------------------------------------------------------------------------
        
Título: ");
        var titulo = Console.ReadLine().ToLower().Trim();
        Console.Write("Autor: ");
        var autor = Console.ReadLine().Trim();
        Console.Write("Año de publicación (YYYY-MM-DD): ");
        DateOnly añoPublicacion = DateOnly.Parse(Console.ReadLine());
        Console.Write("Género: ");
        var genero = Console.ReadLine().Trim();
        Console.Write("Precio: ");
        var precio = Convert.ToDouble(Console.ReadLine());

        var nuevoLibro = new Libro(titulo, añoPublicacion, autor, genero, precio);
        libros.Add(nuevoLibro);
    }

    public Libro? libroElegido;

    public void EliminarLibro()
    {
        do
        {
            Console.Write(@"
Ingrese el ISBN del libro que desea eliminar: ");
            string libroAEliminar = Console.ReadLine().Trim();
            libroElegido = libros.FirstOrDefault(libro => libro.ISBN == libroAEliminar);

            if (libroElegido != null)
            {
                libros.Remove(libroElegido);
                Console.WriteLine($@"
-----------------------------------------------------------------------------------------------

{libroElegido.Titulo} eliminado correctamente!

-----------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El libro no se encontró en la lista. Intente nuevamente.");
            }
            
        } while (libroElegido == null);
    }
}


