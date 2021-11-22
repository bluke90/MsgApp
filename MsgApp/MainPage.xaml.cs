using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MsgApp
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			var un = Preferences.Get("un", "");

			count++;
			CounterLabel.Text = $"Username: {un}";

			SemanticScreenReader.Announce(CounterLabel.Text);
		}
	}
}
