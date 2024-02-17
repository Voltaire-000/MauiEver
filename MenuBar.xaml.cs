namespace MauiEver;

public partial class MenuBar : ContentPage
{
	public MenuBar()
	{
		InitializeComponent();
	}

    private async void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
		var result = await OpenPicker(PickOptions.Images);
    }
}