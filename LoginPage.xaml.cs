using Costea_Maria_ClaudiaBakery.ViewModel;

namespace Costea_Maria_ClaudiaBakery;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel(this.Navigation);
	}
}