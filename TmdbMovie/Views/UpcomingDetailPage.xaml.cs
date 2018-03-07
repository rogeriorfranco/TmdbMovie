using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TmdbMovie.Models;
using TmdbMovie.ViewModels;

namespace TmdbMovie.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpcomingDetailPage : ContentPage
	{
        UpcomingDetailViewModel viewModel;

        public UpcomingDetailPage(UpcomingDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public UpcomingDetailPage()
        {
            InitializeComponent();

            var movie = new Movie();

            viewModel = new UpcomingDetailViewModel(movie);
            BindingContext = viewModel;
        }
    }
}