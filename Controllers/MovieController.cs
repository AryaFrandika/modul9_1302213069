using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using System.Reflection;

namespace modul9_1302213069.Controllers
{
    
    public class MovieController
    {
        private static LiteralPathSegment<Movie> _movie = new List<Movie>
        {
            new Movie

            {
               Title = "The Shawshank Redemption",
               Director = "Frank Darabont",
               Starts = new List<string> {"Tim Robbins","Morgan Freeman"},
               Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
            },
            new Movie

            {
               Title = "The Godfather",
               Director = "Francis Ford Coppola",
               Starts = new List<string> { "Marlon Brando", "Al Pacino", "James Caan"},
               Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
            },
            new Movie

            {
               Title = "The Dark Knight",
               Director = "Christopher Nolan",
               Starts = new List<string> { "Christian Bale", "Heath Ledger"},
               Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice"
            }

    };


       
        public IEnumerable<Movie> Get()
        {
            return Movie;
        }

       
        public Movie Get(int id)
        {
            return Movie[id];
        }

        
        public void Post([FromBody] Movie value)
        {
            Movie.Add(value);
        }

       
        public void Delete(int id)
        {
            Movie.RemoveAt(id);
        }
    }
}