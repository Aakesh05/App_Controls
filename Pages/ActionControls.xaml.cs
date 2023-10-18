namespace App_Controls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}


    private void randomButton_Clicked_1(object sender, EventArgs e)
    {
		DisplayAlert("Ari Alert", "You are in trouble, go see SIR!", "Aw man");
    }

    private void homePageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Ask Ari", $"You've asked him {searchBar.Text} and he says...  Ask the ChatGPT", "Aw Man"); 
    }

    private void teamsSwipeImage_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Ari Teams Link", "You wanna team up with him?", "Yes!");
    }

    private void linkedinSwipeImage_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Ari LinkedIn Link", "You wanna Link up with him?", "Yes!");
    }
}