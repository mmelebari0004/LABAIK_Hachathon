using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hachathon2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckCampaignDatabase : ContentPage
	{
		public CheckCampaignDatabase ()
		{
			InitializeComponent ();
            BindingContext = new campaignDatabase();
		}

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}