using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamBanque.Objects;

namespace XamBanque.Views
{
    public partial class DetailAccountPage : ContentPage
    {
        public DetailAccountPage(Account selectedAccount)
        {
            InitializeComponent();

            this.Title = "Votre compte " + selectedAccount.AccountName;

            accountNameLabel.Text = selectedAccount.AccountName;
            accountNumberLabel.Text = selectedAccount.AccountNumber;
            accountCreditLabel.Text = selectedAccount.AccountCredit.ToString();

            switch (selectedAccount.AccountName)
            {
                case "Compte Courant":
                    diplayCurrentAccount();
                    break;
                case "Livret A":
                    displayLAAccount();
                    break;
                case "LDD":
                    displayLDDAccount();
                    break;
                default:
                    Label testText3 = new Label() { Text = "erreur" };
                    break;
            }
        }

        private void displayLDDAccount()
        {


        }

        private void displayLAAccount()
        {

        }

        private void diplayCurrentAccount()
        {

        }

    }
}
