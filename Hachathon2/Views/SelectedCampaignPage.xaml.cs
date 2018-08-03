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
	public partial class SelectedCampaignPage : ContentPage
	{
        private campaignDatabase campaignDatabaseObj;
        private CommentsDatabase CommentsDatabaseObj;


        public SelectedCampaignPage(campaignDatabase campaignDatabase)
		{
			InitializeComponent ();
            campaignDatabaseObj = campaignDatabase;
            CommentsDatabaseObj = new CommentsDatabase();
            BindingContext = new CommentsDatabase();
            CampaignImagePath.Source = campaignDatabaseObj.CampaignImagePath;
            CampaignName.Text = campaignDatabaseObj.CampaignName;
            CampaignAveREview.Text = ""+ campaignDatabaseObj.CampaignAveREview;
            VIPPrice.Text = "" + campaignDatabaseObj.CampaignVIPPrice;
            BusinessPrice.Text = "" + campaignDatabaseObj.CampaignBusPrice;
            Economyprice.Text = "" + campaignDatabaseObj.CampaignEcoPrice;
            




        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
           // CommentsListView.ItemsSource = await App.CommentDatabase.Comments(campaignDatabaseObj.CampaignID);
        }

            private void AddCommentButton_Clicked(object sender, EventArgs e)
        {
            AddCommentEntry.IsVisible = true;
            SendCommentButton.IsVisible = true;
        }

        private async void NextBuutonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private async void SendCommentButton_Clicked(object sender, EventArgs e)
        {
            CommentsDatabaseObj.Comment = AddCommentEntry.Text;
            CommentsDatabaseObj.CampaignID_C = campaignDatabaseObj.CampaignID;
            await App.CommentDatabase.SavecampaignAsync(CommentsDatabaseObj);


        }
    }
}