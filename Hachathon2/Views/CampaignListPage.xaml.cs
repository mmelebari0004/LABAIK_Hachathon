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
	public partial class CampaignListPage : ContentPage
	{

       
        campaignDatabaseTest campaignDatabaseTest = new campaignDatabaseTest();
        private List<campaignDatabase> SaudiList;
        private List<campaignDatabase> EygptList;
        public CampaignListPage (int index)
		{
			InitializeComponent ();
            BindingContext = new campaignDatabaseTest();
            SaudiList = campaignDatabaseTest.SaudicampaignList;
            EygptList = campaignDatabaseTest.EygptcampaignList;
            if (index == 0)
            {
                CampaignListView.ItemsSource = SaudiList;
                selectedCounty.Text = "Saudi Arabia";


            }
            else if (index == 1)
            {
                CampaignListView.ItemsSource = EygptList;
                selectedCounty.Text = "Eygpt";
            }


        }

        private async void CampaignListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync( new SelectedCampaignPage( e.SelectedItem as campaignDatabase));
        }
    }
}