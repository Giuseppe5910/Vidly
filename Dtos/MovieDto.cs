using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? AddedDate { get; set; }
        public int NumberInStock { get; set; }
        public GenreDto Genre { get; set; }
    }
}