using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TmdbMovie.Services
{
    public interface IReqService
    {
        Task<TResult> GetAsync<TResult>(string url);
        
    }
}
