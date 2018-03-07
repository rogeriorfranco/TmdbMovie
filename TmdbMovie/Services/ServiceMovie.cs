using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TmdbMovie.Models;

namespace TmdbMovie.Services
{
    public class ServiceMovie : IServiceMovie
    {
        private readonly IReqService reqService = new ReqService();
       
        public async Task<Response<Movie>> GetUpcomingAsync(int pageNumber)
        {
            Response<Movie> response = await reqService.GetAsync<Response<Movie>>($"{Settings.UrlApi}movie/upcoming?api_key={Settings.TokenKey}&language=en&page={pageNumber}");
            return response;
        }


    }
}
