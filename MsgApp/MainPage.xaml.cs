using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MsgApp
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnAddContact(object sender, EventArgs e)
		{
			var un = Preferences.Get("un", "");


		}
	}
}
