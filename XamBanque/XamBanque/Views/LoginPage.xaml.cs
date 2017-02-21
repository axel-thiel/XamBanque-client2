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
                   // await Navigation.PushModalAsync(new MainPage());
                    connexionButton.IsEnabled = true;

                }
                else
                {
                    await DisplayAlert(null, "Incorrect password", "OK");
                }
            }
            else
            {
                await DisplayAlert(null, "Incorrect Login", "OK");
            }
        }

    }
}
