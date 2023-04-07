using LoginApp.Models;
using LoginApp.Pages;
using LoginApp.Services;
using LoginApp.UserControl;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        readonly ILoginRepository loginRepository = new LoginService();

        [ICommand]
        public async void Login()
        {
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                var userInfo = await loginRepository.Login(new LoginRequest
                {
                    UserName = UserName,
                    Password = Password
                });


                if (Preferences.ContainsKey(nameof(App.UserInfo)))
                {
                    Preferences.Remove(nameof(App.UserInfo));  
                }
                await SecureStorage.SetAsync(nameof(App.Token), userInfo.Token);
                string userDetails = JsonConvert.SerializeObject(userInfo.UserDetail);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo.UserDetail;
                App.Token = userInfo.Token;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                await AppShell.Current.DisplayAlert("Invalid User Name Or Password", "Invalid UserName or Password", "OK");
            }
        }
    }
}
