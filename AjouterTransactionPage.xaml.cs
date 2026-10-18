namespace PayLink;

public partial class AjoutTransactionPage : ContentPage
{
    public AjoutTransactionPage()
    {
        InitializeComponent();
    }

    private async void OnEnregistrerClicked(object sender, EventArgs e)
    {
        // Affiche une petite popup de succès
        await DisplayAlert("Succès", "Transaction enregistrée avec succès !", "OK");

        // Retourne à la page précédente (le Dashboard)
        await Shell.Current.GoToAsync("..");
    }
}