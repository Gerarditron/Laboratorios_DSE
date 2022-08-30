using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        [Display(Name ="Fecha ")]
        public DateTime FechaLanzamiento { get; set; }
        public string Gener { get; set; }
        public decimal Precio { get; set; }
    }

    public class PeliculaDBContext: DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}