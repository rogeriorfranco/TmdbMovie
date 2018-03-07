using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using TmdbMovie.Services;
using Xamarin.Forms;
using System.Linq;
using TmdbMovie.Models;
using TmdbMovie.Views;

namespace TmdbMovie.ViewModels
{
    public class UpcomingViewModel : BaseViewModel
    {
        
        private ObservableCollection<Movie> upcoming;
        public ObservableCollection<Movie> Upcoming
        {
            get { return upcoming; }
            set
            {
                upcoming = value;
                OnPropertyChanged();
            }
        }

        public Command LoadMoviesCommand { get; set; }
        private IServiceMovie _moviesService = new ServiceMovie();

        public UpcomingViewModel()
        {
            Title = "The movie database";
            
            Upcoming = new ObservableCollection<Movie>();
            LoadMoviesCommand = new Command(async () => await ExecuteLoadMoviesCommand());

        }

        
        async Task ExecuteLoadMoviesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {                      
                var upcomings = await _moviesService.GetUpcomingAsync(1);
                Upcoming = new ObservableCollection<Movie>(
                    upcomings.results
                    .OrderBy(m => m.release_date));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}