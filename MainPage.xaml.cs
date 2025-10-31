namespace ERP.Mobile;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnProductosBtnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ProductosPage");
    }
}
