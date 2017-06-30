using SonRise.StageEvaluationForms;
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
	public partial class StageDevelopmentMain : ContentPage
	{
		public StageDevelopmentMain ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Page1 _stageevalPage1 = new Page1();
            Navigation.PushAsync(_stageevalPage1);
        }
    }
}