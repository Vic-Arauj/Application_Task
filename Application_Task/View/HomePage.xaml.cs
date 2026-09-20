namespace Application_Task.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		

		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new EditTaskPage());
    }
	

    private void SerchBarHomePage(object sender, TappedEventArgs e)
    {
		Entry_search.Focus();
    }
}