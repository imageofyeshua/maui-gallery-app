namespace MauiGalleryApp.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Pressed : {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Released : {DateTime.Now}";
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Clicked : {DateTime.Now}";
    }
}