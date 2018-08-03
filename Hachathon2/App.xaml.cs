using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Hachathon2
{
    public partial class App : Application
    {
        // static campaignDatabaseMethods campaigndatabase;
        static CommentDatabaseMethod Commentdatabase;

        //static PilgrimDatabaseMethods Pilgrimdatabase;
        public App()
        {
            InitializeComponent();
            NavigationPage navPage = new NavigationPage { BarBackgroundColor = Color.Gray };
            MainPage = new NavigationPage(new CountryPage());
        }

        /* public static campaignDatabaseMethods campaignDatabase
         {
             get
             {
                 if (campaigndatabase == null)
                 {
                     campaigndatabase = new campaignDatabaseMethods(DependencyService.Get<ICampaignLocalDatabase>().GetLocalFilePath("campaign.dp3"));
                 }
                 return campaignDatabase;
             }
         }
         */
        public static CommentDatabaseMethod CommentDatabase
        {
            get
            {
                if (Commentdatabase == null)
                {
                    Commentdatabase = new CommentDatabaseMethod(DependencyService.Get<ICampaignLocalDatabase>().GetLocalFilePath("Comment.dp3"));
                }
                return Commentdatabase;
            }
        }
        /*  public static PilgrimDatabase PilgrimDatabase
          {
              get
              {
                  if (Pilgrimdatabase == null)
                  {
                      Pilgrimdatabase = new PilgrimDatabaseMethods(DependencyService.Get<ICampaignLocalDatabase>().GetLocalFilePath("order2.dp3"));
                  }
                  return PilgrimDatabase;
              }
    }*/

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
