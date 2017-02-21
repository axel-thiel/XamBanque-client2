using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamBanque.DTO;
using XamBanque.WebServices;

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

            LoginDTO loginDto = new LoginDTO();

            if (loginEditText.Text != null && passwordEditText.Text != null)
            {
                loginDto.login = Convert.ToInt64(loginEditText.Text);
            loginDto.password = Convert.ToInt64(passwordEditText.Text);

            UserDTO userDto = await RestServices.connectionAsync(loginDto);

            if(userDto != null)
            {
                loginEditText.Text = null;
                passwordEditText.Text = null;

                App.connectedUserDto = userDto;

                await Navigation.PushModalAsync(new MainPage());

                connexionButton.IsEnabled = true;
            } else
                {
                    await DisplayAlert(null, "Mot de passe ou Login incorrect", "OK");
                    connexionButton.IsEnabled = true;
                }     
            } else
            {
                await DisplayAlert(null, "Merci de remplir votre Login ET votre mot de passe", "OK");
                connexionButton.IsEnabled = true;

            }

        }

        private void checkLoginAndPass()
        {
            
        }
    }
}
