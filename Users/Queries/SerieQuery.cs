using GraphAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAPI.Queries
{
    public class SerieQuery
    {
        private List<Serie> series; // Lista de series simulada

        public SerieQuery()
        {
            // Inicializar la lista de series con algunos datos de ejemplo
            series = new List<Serie>
            {
                new Serie
                {
                    Id = 1,
                    Name = "Mejores Secuelas",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    plataform = new List<Plataform>
                    {
                        new Plataform
                        {
                            name = "Kunfu Panda 2",
                            followers = 100000
                        },
                        new Plataform
                        {
                            name = "Sherk 2",
                            followers = 200000
                        }
                    }
                },
                new Serie
                {
                    Id = 2,
                    Name = "Secuelas que no existen",
                    ReleaseDate = DateTime.UtcNow.AddDays(-20),
                    plataform = new List<Plataform>
                    {
                        new Plataform
                        {
                            name = "The promised neverland temporada 2",
                            followers = 150
                        },
                        new Plataform
                        {
                            name = "Ultimas temporadas de nanatsu no taizai",
                            followers = 180
                        }
                    }
                }
                // Puedes agregar más series si lo deseas
            };
        }

        public List<Serie> GetSeries()
        {
            // Retorna todas las series
            return series;
        }

        public Serie GetSerieById(int id)
        {
            // Retorna una serie por su ID
            return series.FirstOrDefault(s => s.Id == id);
        }
    }
}
