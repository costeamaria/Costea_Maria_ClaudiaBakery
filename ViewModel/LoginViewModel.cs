using Costea_Maria_ClaudiaBakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Costea_Maria_ClaudiaBakery.ViewModel
{
    public class LoginViewModel
    {
        private string _username, _password;
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public ICommand RegisterCommand { private get; set; }
        public ICommand LoginCommand { private get; set; }
        private INavigation Navigation;

        public LoginViewModel(INavigation navigation)
        {
            RegisterCommand = new Command(OnRegisterCommand);
            LoginCommand = new Command(OnLoginCommand);
            Navigation = navigation;
        }

        private async void OnLoginCommand(object obj)
        {
            var loginData = await App.Database.GetLoginDataAsync(Username);
            if(loginData != null)
            {
                if(string.Equals(loginData.Password,Password))
                {
                    //Navigation Next Page
                    //await Navigation.PushModelAsync(new ProductPage());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("failure", "Invalid Password", "OK");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("failure", "Invalid Username", "OK");
            }
        }

        private void OnRegisterCommand(object obj)
        {
            LoginModel lm = new LoginModel();
            lm.Username = Username;
            lm.Password = Password;
            App.Database.SaveLoginDataAsync(lm);
            App.Current.MainPage.DisplayAlert("success", "Registration Successful", "OK");
        }
    }
}
