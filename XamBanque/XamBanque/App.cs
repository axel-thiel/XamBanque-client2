using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamBanque.DTO;
using XamBanque.Views;

namespace XamBanque
{
    public class App : Application
    {

        public static UserDTO connectedUserDto { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new LoginPage());
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            connectedUserDto = null;
           
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
