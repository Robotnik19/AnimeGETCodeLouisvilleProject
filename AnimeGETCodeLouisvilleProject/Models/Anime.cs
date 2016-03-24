using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeGETCodeLouisvilleProject.Models
{
    public class Anime
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Genre { get; set; }
        public int EpisodeID { get; set; }
        public string EpisodeReleaseDate { get; set; }
    }
    public class AnimeDBContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }
    }
}
