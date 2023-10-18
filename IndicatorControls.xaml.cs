namespace App_Controls.Pages;

public partial class IndicatorControls : ContentPage
{
	public IndicatorControls()
	{
		InitializeComponent();
	}

    private void activityindicatorbutton_Clicked(object sender, EventArgs e)
    {
        activityindicator.IsRunning = !activityindicator.IsRunning;
    }
}