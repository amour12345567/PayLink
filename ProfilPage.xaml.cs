namespace PayLink;

public partial class ProfilPage : ContentPage
{
    public ProfilPage()
    {
        InitializeComponent();
    }

    private async void OnSeDeconnecterClicked(object sender, EventArgs e)
    {
        // Retourne à l'écran de connexion principal
        await Shell.Current.GoToAsync("//MainPage");
    }
}