namespace MauiEver;

public partial class JsonView : ContentPage
{
	public JsonView()
	{
		InitializeComponent();

		StackLayout stackLayout = new StackLayout();
		stackLayout.Add(new Label { Text = "No results matched your filter." });
		stackLayout.Add(new Label { Text = "Try a different filter." });

		SearchBar searchBar = new SearchBar();
		CollectionView collectionView = new CollectionView
		{
			EmptyView = new ContentView
			{
				Content = stackLayout
			}

		};
		collectionView.SetBinding(ItemsView.ItemsSourceProperty, "thermoSource");

	}
}