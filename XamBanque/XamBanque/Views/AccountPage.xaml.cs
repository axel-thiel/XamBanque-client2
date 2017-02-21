using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamBanque.Objects;

namespace XamBanque.Views
{
    public partial class AccountPage : ContentPage
    {
        private List<Account> ListOfAccount;
        private List<Publicity> ListOfPublicity;

        public AccountPage()
        {
            InitializeComponent();

            CreateAccountList();

            CreatPublicityList();

            CreditCalculation(ListOfAccount);

            accountListView.ItemsSource = ListOfAccount;

            publicityListView.ItemsSource = ListOfPublicity;

            accountListView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as Account;
                if (item == null) return;
                await Navigation.PushAsync(new DetailAccountPage(item));
                accountListView.SelectedItem = null;
            };

            publicityListView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as Publicity;
                if (item == null) return;
                await Navigation.PushAsync(new PublicityPage(item));
                accountListView.SelectedItem = null;
            };
        }

        private void CreatPublicityList()
        {

            Publicity pub1 = new Publicity()
            {
                pubName = "Annonce n° 1",
                pubText = "Quaestione igitur per multiplices dilatata fortunas cum ambigerentur quaedam, non nulla levius actitata constaret, post multorum clades Apollinares ambo pater et filius in exilium acti cum ad locum Crateras nomine pervenissent, villam scilicet suam"
            };

            Publicity pub2 = new Publicity()
            {
                pubName = "Annonce n° 2",
                pubText = "Exilium acti cum ad locum Crateras nomine pervenissent, villam scilicet suam quae ab Antiochia vicensimo et quarto disiungitur lapide, ut mandatum est, fractis cruribus occiduntur."
            };

            Publicity pub3 = new Publicity()
            {
                pubName = "Annonce n° 3",
                pubText = "Exilium acti cum ad locum Crateras nomine pervenissent, villam scilicet suam quae ab Antiochia vicensimo et quarto disiungitur lapide, ut mandatum est, fractis cruribus occiduntur."
            };

            ListOfPublicity = new List<Publicity> {
                pub1,
                pub2,
                pub3
            };

        }

        public void CreateAccountList()
        {

            Account account1 = new Account()
            {
                AccountName = "Compte Courant",
                AccountNumber = "xxx 031",
                AccountCredit = 810
            };

            Account account2 = new Account()
            {
                AccountName = "Livret A",
                AccountNumber = "xxx 032",
                AccountCredit = 2442
            };

            Account account3 = new Account()
            {
                AccountName = "LDD",
                AccountNumber = "xxx 033",
                AccountCredit = 3656
            };

            ListOfAccount = new List<Account>
            {
                account1,
                account2,
                account3
            };

        }

        private void CreditCalculation(List<Account> listOfAccount)
        {

            long AllCredit = 0;

            foreach (Account account in listOfAccount)
            {
                AllCredit += account.AccountCredit;
            }

            Label AllCreditAccount = this.FindByName<Label>("AllAccountsCredit");
            AllCreditAccount.Text = AllCredit.ToString();

        }

    }
}
