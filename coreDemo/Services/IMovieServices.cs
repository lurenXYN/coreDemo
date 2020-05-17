using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreDemo.Models;

namespace coreDemo.Services
{
    public interface IMovieServices
    {
        Task AddAsync(Movie movie);

        Task<IEnumerable<Movie>> GetByCinemaAsync(int cinemaId);
    }
}
