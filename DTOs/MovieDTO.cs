using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly2.Models;

namespace Vidly2.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }        

        [Required]        
        public byte GenreId { get; set; }

        [Required]        
        public DateTime ReleaseDate { get; set; }        
        
       
        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}