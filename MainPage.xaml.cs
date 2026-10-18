namespace PayLink;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSeConnecterClicked(object sender, EventArgs e)
    {
        
        await Shell.Current.GoToAsync("//DashboardPage");
    }
    
    private async void OnCreerCompteTapped(object sender, TappedEventArgs e)
    {
       
        await Shell.Current.GoToAsync("InscriptionPage");
    }
}