using MauiEver.Services;
using MauiEver.ViewModels;

namespace MauiEver.Views;

public partial class ReactantsView : ContentPage
{
	public ReactantsView()
	{
		InitializeComponent();
		ReactantService reactantService = new();
		ReactantViewModel reactantViewModel = new(reactantService);
		reactantsCollectionView.ItemsSource = reactantViewModel.Reactants;
	}
}