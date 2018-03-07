using System;

using TmdbMovie.Models;

namespace TmdbMovie.ViewModels
{
    public class UpcomingDetailViewModel : BaseViewModel
    {
        public Movie Movie { get; set; }
        public UpcomingDetailViewModel(Movie movie = null)
        {            
            Movie = movie;
        }
    }
}
