using System;
using System.Collections.Generic;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;



namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageFilename = "Movie1.jpg" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", ImageFilename = "Movie2.jpg" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", ImageFilename = "Movie3.jpg" },
              new MovieViewModel { Id = 4, Name = "Starship Odyssey", Rating = "5", ReleaseYear = 2020, Genre = "Science/Fiction", ImageFilename = "Movie4.jpg" },
            new MovieViewModel { Id = 5, Name = "The Secret Garden", Rating = "5", ReleaseYear = 2020, Genre = "Drama", ImageFilename = "Movie5.jpg" },
            new MovieViewModel { Id = 6, Name = "Lost in Time", Rating = "5", ReleaseYear = 2019, Genre = "Adventure", ImageFilename = "Movie6.jpg" },
            new MovieViewModel { Id = 7, Name = "City of Shadows", Rating = "5", ReleaseYear = 2018, Genre = "Mystery", ImageFilename = "Movie7.jpg" },
            new MovieViewModel { Id = 8, Name = "Eternal Sunshine", Rating = "5", ReleaseYear = 2004, Genre = "Romance/Drama", ImageFilename = "Movie8.jpg" },
            new MovieViewModel { Id = 9, Name = "The Great Escape", Rating = "5", ReleaseYear = 1963, Genre = "War", ImageFilename = "Movie9.jpg" },
            new MovieViewModel { Id = 10, Name = "The Dark Knight", Rating = "5", ReleaseYear = 2008, Genre = "Action", ImageFilename = "Movie10.jpg" },
            new MovieViewModel { Id = 11, Name = "Inception", Rating = "5", ReleaseYear = 2010, Genre = "Science and Fiction", ImageFilename = "Movie11.jpg" },
            new MovieViewModel { Id = 12, Name = "Forrest Gump", Rating = "5", ReleaseYear = 1994, Genre = "Romance/Drama", ImageFilename = "Movie12.jpg" },
            new MovieViewModel { Id = 13, Name = "Jurassic Park", Rating = "5", ReleaseYear = 1993, Genre = "Science and Fiction", ImageFilename = "Movie13.jpg" },
            new MovieViewModel { Id = 14, Name = "Avatar", Rating = "5", ReleaseYear = 2007, Genre = "Adventure", ImageFilename = "Movie14.jpg" },
            new MovieViewModel { Id = 15, Name = "The Gentlemen", Rating = "5", ReleaseYear = 2020, Genre = "Action/Comedy", ImageFilename = "Movie15.jpg" },
            new MovieViewModel { Id = 16, Name = "Extraction", Rating = "5", ReleaseYear = 2020, Genre = " Action/Thriller", ImageFilename = "Movie16.jpg" },
            new MovieViewModel { Id = 17, Name = "The Invisible Man", Rating = "5", ReleaseYear = 2020, Genre = "Horror/Sci-Fi", ImageFilename = "Movie17.jpg" },
            new MovieViewModel { Id = 18, Name = "Tenet", Rating = "5", ReleaseYear = 2020, Genre = "Horror/Sci-Fi", ImageFilename = "Movie18.jpg" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

