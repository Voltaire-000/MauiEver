using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace MauiEver;

public partial class JsonView : ContentPage
{

    public JsonView()
	{
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shortThermo.json");
		string json = File.ReadAllText(path);

		//JObject json = JObject.Parse(json);
		//Func<JToken, bool> filter = r => (string)r["reactant"] == "ALC";

		var settings = new JsonSerializerSettings
		{
			TraceWriter = new ConsoleTraceWriter()
		};

		var mThermo = JsonConvert.DeserializeObject<thermo>(json, settings);

		thermo thermoSource = JsonConvert.DeserializeObject<thermo>(json);



		InitializeComponent();

		StackLayout stackLayout = new StackLayout();
		stackLayout.Add(new Label { Text = "No results matched your filter." });
		stackLayout.Add(new Label { Text = "Try a different filter." });

		SearchBar searchBar = new SearchBar();
		

		CollectionView collectionView = new CollectionView();

		//CollectionView collectionView = new CollectionView
		//{
		//	EmptyView = new ContentView
		//	{
		//		Content = stackLayout
		//	}

		//};

	
        collectionView.SetBinding(ItemsView.ItemsSourceProperty, "thermoSource");

	}
}