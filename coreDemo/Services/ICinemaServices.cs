using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreDemo.Models;

namespace coreDemo.Services
{
    public interface ICinemaServices
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task<Cinema> GetByIdAsync(int id);
        //Task<Sales> GetSalesAsync();
        Task AddAsync(Cinema cinema);
    }
}
