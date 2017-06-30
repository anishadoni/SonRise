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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            BindingContext = EvaluationModelLocator.MainViewModel;
        }

        private void Finish_Clicked(object sender, EventArgs e)
        {




            Navigation.PopToRootAsync();
        }

    }
}