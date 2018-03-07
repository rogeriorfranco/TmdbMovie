using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TmdbMovie.Models;
using TmdbMovie.Views;
using TmdbMovie.ViewModels;

namespace TmdbMovie.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpcomingPage : ContentPage
	{
        UpcomingViewModel viewModel;

        public UpcomingPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new UpcomingViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var movie = args.SelectedItem as Movie;
            if (movie == null)
                return;

            await Navigation.PushAsync(new UpcomingDetailPage(new UpcomingDetailViewModel(movie)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

     
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Upcoming.Count == 0)
                viewModel.LoadMoviesCommand.Execute(null);
        }
    }
}