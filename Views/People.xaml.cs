using MauiEver.Services;
using MauiEver.ViewModels;

namespace MauiEver.Views;

public partial class People : ContentPage
{
	public People()
	{
        InitializeComponent();
        PeopleService dataService = new();
        PeopleViewModel viewModel = new(dataService);
		collectionView.ItemsSource = viewModel.People;
    }
}