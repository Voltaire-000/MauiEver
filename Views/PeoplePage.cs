using MauiEver.Services;
using MauiEver.ViewModels;

namespace MauiEver.Views;

public class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		var peopleService = new PeopleService();
		var viewModel = new PeopleViewModel(peopleService);

		// create a collectionView
		var collectionView = new CollectionView
		{
			ItemTemplate = new DataTemplate(() =>
			{
				// create a stack layout
				var stackLayout = new StackLayout
				{
					Orientation = StackOrientation.Horizontal,
					Padding = 10
				};
				// create labels
				var nameLabel = new Label { FontAttributes = FontAttributes.Bold };
				var ageLabel = new Label { HorizontalTextAlignment = TextAlignment.Center };
				var cityLabel = new Label { HorizontalTextAlignment = TextAlignment.Center };

				// bind the labels to the person properties
				nameLabel.SetBinding(Label.TextProperty, "Name");
				ageLabel.SetBinding(Label.TextProperty, "Age");
				cityLabel.SetBinding(Label.TextProperty, "City");

				// add the labels to the stack layout
				stackLayout.Children.Add(nameLabel);
				stackLayout.Children.Add(ageLabel);
				stackLayout.Children.Add(cityLabel);
				// return the stackLayout as the itemTemplate
				return stackLayout;
			}),
			ItemsSource = viewModel.people
		};

		// create content page
		var page = new ContentPage
		{
			Title = "Persons Data",
			Content = collectionView
		};

	}
}