using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamBanque.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected virtual void OnResume()
        {
            
        }

        private async void ConnexionButton_OnClickedAsync(object sender, EventArgs e)
        {
            connexionButton.IsEnabled = false;

            var login = loginEditText.Text;
            var passWord = passwordEditText.Text;

       

            if ("user".Equals(login))
            {
                if ("user".Equals(passWord))
                {
                    loginEditText.Text = "";
                    passwordEditText.Text = "";
                    await Navigation.PushModalAsync(new MainPage());
                    connexionButton.IsEnabled = true;

                }
                else
                {
                    await DisplayAlert(null, "Mot de passe incorrect", "OK");
                    connexionButton.IsEnabled = true;
                }
            }
            else
            {
                await DisplayAlert(null, "Login incorrect", "OK");
                connexionButton.IsEnabled = true;
            }
        }

    }
}
