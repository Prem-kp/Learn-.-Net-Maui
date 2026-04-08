namespace student_login_app.view;

public partial class Loginpage : ContentPage
{
	public Loginpage()
	{
		InitializeComponent();
		BindingContext = new StudentViewModel();



    }
}