using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using MsgApp.Models;

namespace MsgApp.Pages
{
	public partial class AddContact : ContentPage
	{
		private readonly MsgApp.Services.DataContext _context;

		public AddContact()
		{
			_context = new MsgApp.Services.DataContext();
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
