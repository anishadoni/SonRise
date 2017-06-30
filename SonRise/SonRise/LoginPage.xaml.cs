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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        void Login_Handle(object sender, System.EventArgs e)
        {
            var home = new SonRise.Home();
            Navigation.PushModalAsync(home);
            Console.Out.WriteLine("Login successful!");
        }
    }
}