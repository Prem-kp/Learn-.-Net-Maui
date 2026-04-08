using SchoolAppNew.Views;

namespace SchoolAppNew;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new LoginPage());
    }
}