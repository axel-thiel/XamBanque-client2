using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamBanque.Views
{
    public partial class BankTransferPage : ContentPage
    {
        public BankTransferPage()
        {
            InitializeComponent();
        }

        private async void NewTransfert_OnClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransfertForm());
        }

    }
}
