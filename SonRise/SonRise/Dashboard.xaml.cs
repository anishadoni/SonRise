using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SonRise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();
		}

        private void StageDev_Clicked(object sender, EventArgs e)
        {
            StageDevelopmentMain _stageDevelopment = new StageDevelopmentMain();
            Navigation.PushModalAsync(new NavigationPage(_stageDevelopment));
        }
    }
}