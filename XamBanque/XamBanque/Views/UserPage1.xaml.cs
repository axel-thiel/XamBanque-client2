using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamBanque.Views
{
    public partial class UserPage1 : ContentPage
    {
        public UserPage1()
        {
            InitializeComponent();

            userFirstName.Text = App.connectedUserDto.firstName;
            userLastName.Text = App.connectedUserDto.lastName;
            userPhone.Text = App.connectedUserDto.phone;
            userEmail.Text = App.connectedUserDto.email;

        }
    }
}
