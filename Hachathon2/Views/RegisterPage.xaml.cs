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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private async void VolunterButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Congratulations", "Your Booking is confirm ", "OK");
            await Navigation.PushAsync(new CountryPage());
        }
    }
}