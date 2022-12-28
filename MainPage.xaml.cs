using MauiBreakfast.ViewModels;

namespace MauiBreakfast;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyBreakfastsViewModel();
	}

}

