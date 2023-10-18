namespace App_Controls.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void commonControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CommonControls());
    }

    private void commonActionsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }

    private void commonInputsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControls());
    }
}