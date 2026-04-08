using SchoolAppNew.Views;

namespace SchoolAppNew.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MarksheetPage());
    }

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Close", "Close button clicked", "OK");
    }
}