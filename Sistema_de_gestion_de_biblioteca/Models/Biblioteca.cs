using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        var vistaLibros = libros.Select(libro => new{
            titulo = libro.Titulo,
            autor = libro.Autor,
            año = libro.AñoPublicacion,
            genero = libro.Genero
        }).ToList();

    Console.WriteLine(@$"###############################################################################################
#                                   LISTADO DE LIBROS                                         #
###############################################################################################
| Nro |           Título           |          Autor          |     Año     |      Género      |
-----------------------------------------------------------------------------------------------");
    int i = 1;
    foreach (var item in vistaLibros)
    {
        Console.WriteLine(@$"|  {i,-3}| {item.titulo,-27}| {item.autor,-24}| {item.año,-12}| {item.genero,-17}|");
        i++;
    }
    Console.WriteLine(@"-----------------------------------------------------------------------------------------------");
}
    
}
