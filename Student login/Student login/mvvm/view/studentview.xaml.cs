using Student_login.NewFolder;

namespace Student_login.mvvm.view;

public partial class studentview : ContentPage
{
	public studentview()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewPage1());
	}

}