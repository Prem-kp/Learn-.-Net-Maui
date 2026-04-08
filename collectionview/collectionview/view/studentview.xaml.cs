using collectionview.viewmodel;

namespace collectionview.view;

public partial class studentview : ContentPage
{
	public studentview()
	{
		InitializeComponent();
        BindingContext = new studentviewmodel();
	}
}