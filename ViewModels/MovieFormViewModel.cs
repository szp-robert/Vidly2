using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
               
        [Required]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        

        [Display(Name = "Number in stock")]
        [Required]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        public string Title 
        { get
            {
                if(Id!=0)                
                    return "Edit Movie";
                return "New Movie";
                
            }  
        }

        public MovieFormViewModel()
        {
            Id = 0;

        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;

        }
    }
}