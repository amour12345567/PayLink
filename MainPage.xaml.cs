namespace PayLink;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Fonction appelée quand on tape sur le Label "Créer un compte"
    private async void OnCreerCompteTapped(object sender, TappedEventArgs e)
    {
        // Navigation vers la page d'inscription
        await Shell.Current.GoToAsync("InscriptionPage");
    }
}