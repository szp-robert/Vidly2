using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly2.DTOs;
using Vidly2.Models;

namespace Vidly2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/newrentals      
        [HttpPost] //because im creating a resource można tego nie dawać i w nazwie akcji dać PostCustomer, ale nie zalecane przez Mosha
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRentalDTO)
        {
            //if (newRentalDTO.MoviesIds.Count == 0)
            //    return BadRequest("No movies ids have been given."); OPTIMISTIC APPROACH :)

            //var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDTO.CustomerId);

            var customer = _context.Customers.Single(c => c.Id == newRentalDTO.CustomerId);

            //if (customer == null)
            //    return BadRequest("CustomerId is not valid."); OPTIMISTIC APPROACH :)



            var movies = _context.Movies.Where(m => newRentalDTO.MovieIds.Contains(m.Id)).ToList();

            //if (movies.Count != newRentalDTO.MoviesIds.Count)
            //    return BadRequest("One or more movies was invalid."); OPTIMISTIC APPROACH :)

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available"); //we need to check that because a hacker can call this api and reduce the number available to negative which cant happen

                movie.NumberAvailable--;

                var newRental = new Rental();

                newRental.Customer = customer;


                newRental.Movie = movie;
                newRental.DateRented = DateTime.Now;
                

                _context.Rental.Add(newRental);

                var movieInDb = movie;

                    
                
                
            }
            
            _context.SaveChanges();

            return Ok();//nie zwracam methody Created bo ona jest używana kiedy zwaracam 1 utworzony obiekt(resource). Tutaj mamy wiele utworzonych obiektów.
        }
    }
}
