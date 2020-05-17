using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreDemo.Models;

namespace coreDemo.Services
{
    public class MovieMemoryService : IMovieServices
    {
        private readonly List<Movie> _movies = new List<Movie>();
        public MovieMemoryService()
        {
            _movies.Add(new Movie
            {
                Id = 1,
                Name = "了不起的盖茨比",
                CinemaId = 1,
                ReleaseDate = new DateTime(2020, 04, 04),
                Starring = "小李子"
            });
            _movies.Add(new Movie
            {
                Id = 2,
                Name = "飞鹰计划",
                CinemaId = 2,
                ReleaseDate = new DateTime(2020, 01, 01),
                Starring = "成龙"
            }); _movies.Add(new Movie
            {
                Id = 3,
                Name = "饥饿站台",
                CinemaId = 1,
                ReleaseDate = new DateTime(2020, 01, 24),
                Starring = "匿名"
            });
        }
        public Task AddAsync(Movie movie)
        {
            var id = _movies.Max(t => t.Id);
            movie.Id = id + 1;
            _movies.Add(movie);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Movie>> GetByCinemaAsync(int cinemaId)
        {
            return Task.Run(()=>_movies.Where(t=>t.CinemaId == cinemaId));
        }
    }
}
