using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamBanque.Objects;

namespace XamBanque.Views
{
    public partial class PublicityPage : ContentPage
    {
        public PublicityPage(Publicity selectedPublicity)
        {

            InitializeComponent();
            pubTitle.Text = selectedPublicity.pubName;
            pubDescription.Text = selectedPublicity.pubText;

        }
    }
}
