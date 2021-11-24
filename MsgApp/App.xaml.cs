using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Essentials;
using MsgApp.Pages;
using Application = Microsoft.Maui.Controls.Application;

namespace MsgApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var un = Preferences.Get("un", "null");
			if (un == "null") {
				MainPage = new SetupPage();
			} else { MainPage = new MainPage(); }
		}
	}
}
