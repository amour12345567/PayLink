namespace PayLink;

public partial class HistoriquePage : ContentPage
{
    public HistoriquePage()
    {
        InitializeComponent();
    }

    private async void OnTransactionTapped(object sender, TappedEventArgs e)
    {
        // Navigue vers l'écran des détails
        await Shell.Current.GoToAsync("DetailsTransactionPage");
    }
}