using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_biblioteca.Models;

public class Libro : Publicacion
{
    public string? Autor { get; set; }
    public Guid ISBN { get; set; }
    public string? Genero { get; set; }
    public double Precio { get; set; }

    public Libro(string titulo, DateOnly añoPublicacion, string autor, string genero, double precio)
    {
        Titulo = titulo.ToLower().Trim();
        AñoPublicacion = añoPublicacion;
        Autor = autor;
        ISBN = Guid.NewGuid();
        Genero = genero;
        Precio = precio;
    }
    

}
