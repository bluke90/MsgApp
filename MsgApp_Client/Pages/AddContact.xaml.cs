using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using MsgApp_Client.Models;

namespace MsgApp_Client.Pages
{
	public partial class AddContact : ContentPage
	{
		private readonly MsgApp_Client.Services.DataContext _context;

		public AddContact()
		{
			_context = new MsgApp_Client.Services.DataContext();
			InitializeComponent();
		}

		private async void OnAddContact(object sender, EventArgs e) {
			var person = new Person();
			person.Name = ContactName.Text;
			person.ContactToken = ContactID.Text;

			_context.People.Add(person);
			await _context.SaveChangesAsync();
			App.Current.MainPage = new MainPage();
        }
		private void OnGoBack(object sender, EventArgs e)
        {
			App.Current.MainPage = new MainPage();
        }

	}
}
