using MauiEver.Services;
using MauiEver.ViewModels;

namespace MauiEver.Views;

public partial class People : ContentPage
{
	public People()
	{
		InitializeComponent();
		var dataService = new PeopleService();
		var viewModel = new PeopleViewModel(dataService);
		//BindingContext = viewModel;
		//collectionView.BindingContext = viewModel;
		collectionView.ItemsSource = viewModel.People;

	}
}