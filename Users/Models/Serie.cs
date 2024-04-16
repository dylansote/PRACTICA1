//Serie.cs
using System;
using System.Collections.Generic;

namespace GraphAPI.Models
{
    public class Serie
    {
        public int Id { get; set; } // Propiedad Id agregada
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Plataform> plataform { get; set; }
    }
}
