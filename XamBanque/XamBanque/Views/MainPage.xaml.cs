using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamBanque.DTO;
using XamBanque.MenuItems;

namespace XamBanque.Views
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItems> MenuList { get; set; }

        public MainPage()
        {

            InitializeComponent();

            MenuList = new List<MasterPageItems>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItems() { Title = "Vos comptes", Icon = null, TargetType = typeof(AccountPage) };
            var page2 = new MasterPageItems() { Title = "Virements", Icon = null, TargetType = typeof(BankTransferPage) };
            var page3 = new MasterPageItems() { Title = "Statistiques", Icon = null, TargetType = typeof(GraphPage) };
            var page4 = new MasterPageItems() { Title = "Nous contacter", Icon = null, TargetType = typeof(ContactPage) };
            var page5 = new MasterPageItems() { Title = "Vos Informations", Icon = null, TargetType = typeof(UserPage1) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage(new AccountPage());

        }

        protected virtual void OnResume()
        {

        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItems)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));

            IsPresented = false;
        }

    }
}
