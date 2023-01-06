using Costea_Maria_ClaudiaBakery.ViewModel;
using Plugin.LocalNotification;

namespace Costea_Maria_ClaudiaBakery;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel(this.Navigation);
	}
	
}