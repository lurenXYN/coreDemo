using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreDemo.Models;

namespace coreDemo.Services
{
    public class CinemaMemoryService : ICinemaServices
    {
        private readonly List<Cinema> _cinemas = new List<Cinema>();
        public CinemaMemoryService()
        {
            _cinemas.Add(new Cinema { 
                id=1,
                Name = "万达",
                Location = "光谷世界城",
                Capacity = 1000
            });
            _cinemas.Add(new Cinema
            {
                id=2,
                Name = "成龙影城",
                Location = "光谷天地",
                Capacity = 500
            });
        }
        public Task AddAsync(Cinema cinema)
        {
            var id = _cinemas.Max(t => t.id);
            cinema.id = id + 1;
            _cinemas.Add(cinema);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Cinema>> GetAllAsync()
        {
            return Task.Run(() =>  _cinemas.AsEnumerable() );
        }

        public Task<Cinema> GetByIdAsync(int id)
        {
            return Task.Run(() => _cinemas.FirstOrDefault(t => t.id == id));
        }

        //public Task<Sales> GetSalesAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
