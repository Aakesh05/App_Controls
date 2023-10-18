namespace App_Controls.Pages;

public partial class CommonControls : ContentPage
{
	public CommonControls()
	{
		InitializeComponent();
	}

    private void mainPageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}