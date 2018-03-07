using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TmdbMovie.Models;

namespace TmdbMovie.Services
{
    public interface IServiceMovie
    {
        Task<Response<Movie>> GetUpcomingAsync(int pageNumber);
    }
}
