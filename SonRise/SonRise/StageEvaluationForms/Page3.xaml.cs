using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SonRise.StageEvaluationForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            BindingContext = EvaluationModelLocator.MainViewModel;
		}

        private void Next_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}