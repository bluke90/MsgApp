using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MsgApp_Client.Pages
{
	public partial class SetupPage : ContentPage
	{

		public SetupPage()
		{
			InitializeComponent();
		}

		private void OnGoClicked(object sender, EventArgs e) {
			var un = userName.Text;

            Preferences.Set("un", un);
			App.Current.MainPage = new MainPage();

        }

	}
}
