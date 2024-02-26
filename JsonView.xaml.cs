using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text.Json;

namespace MauiEver;

public partial class JsonView : ContentPage
{

    public JsonView()
	{
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shortThermo.json");
		string json = File.ReadAllText(path);

		//JObject json = JObject.Parse(json);
		//Func<JToken, bool> filter = r => (string)r["reactant"] == "ALC";

		//var options = new JsonSerializerOptions
		//{
		//	PropertyNameCaseInsensitive = true,
		//};

		var settings = new JsonSerializerSettings
		{
			TraceWriter = new ConsoleTraceWriter()
		};

		var mThermo = JsonConvert.DeserializeObject<ThermoDataContext>(json, settings);

        //ThermoDataContext thermoSource = JsonConvert.DeserializeObject<ThermoDataContext>(json);
        ThermoDataContext thermoSource = JsonConvert.DeserializeObject<ThermoDTO>(json);
		List<ThermoDTO> thermos = JsonConvert.DeserializeObject<List<ThermoDTO>>(json);

        InitializeComponent();

		StackLayout stackLayout = new StackLayout();
		stackLayout.Add(new Label { Text = "No results matched your filter." });
		stackLayout.Add(new Label { Text = "Try a different filter." });

		SearchBar searchBar = new SearchBar();
		

		//CollectionView collectionView = new CollectionView();

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