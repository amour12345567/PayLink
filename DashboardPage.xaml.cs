namespace PayLink;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private async void OnAjouterTransactionTapped(object sender, EventArgs e)
    {
        // Navigation vers la page d'ajout de transaction
        await Shell.Current.GoToAsync("AjoutTransactionPage");
    }
}