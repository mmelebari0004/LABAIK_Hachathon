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
	public partial class EnterCampaignData : ContentPage
	{
        campaignDatabase campaignDatabaseObj;
        public EnterCampaignData ()
		{
			InitializeComponent ();
            campaignDatabaseObj = new campaignDatabase();
		}

        private async void SubmetButton_Clicked(object sender, EventArgs e)
        {
            campaignDatabaseObj.CampaignID = Int32.Parse( CampaignIDEntry.Text);
            campaignDatabaseObj.CampaignName = CampaignNameEntry.Text;
            campaignDatabaseObj.CampaignCountryOfResidence = CampaignCountryOfResidenceEntry.Text;
         //   campaignDatabaseObj.CampaignPhone = Int32.Parse( CampaignPhoneEntry.Text);
           // campaignDatabaseObj.CampaignEmail = CampaignEmailEntry.Text;
            campaignDatabaseObj.CampaignImagePath = CampaignImagePathEntry.Text;
            campaignDatabaseObj.CampaignNoStars = Int32.Parse( CampaignNoStarsEntry.Text);
            campaignDatabaseObj.CampaignAveREview =Int32.Parse( CampaignAveREviewEntry.Text);
            campaignDatabaseObj.CampaignAvaVIP = Int32.Parse( CampaignAvaVIPEntry.Text);
            campaignDatabaseObj.CampaignVIPPrice = Int32.Parse( CampaignVIPPriceEntry.Text);
            campaignDatabaseObj.CampaignAvaEco = Int32.Parse( CampaignAvaEcoEntry.Text);
            campaignDatabaseObj.CampaignEcoPrice =Int32.Parse( CampaignEcoPriceEntry.Text);
            campaignDatabaseObj.CampaignAvaBus = Int32.Parse( CampaignAvaBusEntry.Text);
            campaignDatabaseObj.CampaignBusPrice = Int32.Parse( CampaignBusPriceEntry.Text);
        //    await App.campaignDatabase.SavecampaignAsync(campaignDatabaseObj);
          //  await Navigation.PushAsync(new CheckCampaignDatabase());






        }
    }
}