using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using MsgApp_Client.Models;
using MsgApp_Client.Pages;
using Microsoft.Maui.Graphics;
using MsgApp_Client.Services;
using System.Text.Json;
using System.Text;

namespace MsgApp_Client
{
	public partial class MainPage : ContentPage
	{

		private readonly MsgApp_Client.Services.DataContext _context;

		private List<Person> People = new List<Person>();

		public MainPage()
		{
			_context = new Services.DataContext();
			InitializeComponent();
			GetContacts();
		}
		//			NetService net = new NetService();
		//			NetService.StartClient();
		private void OnAddContact(object sender, EventArgs e)
		{
			Message msg = new Message
			{
				Body = "test",
				Token = "54asda6",
				Sender = "1010",
				Recipient = "2525"
			};
			string jsonString = JsonSerializer.Serialize(msg);
			Console.WriteLine(jsonString);
			byte[] vs = Encoding.ASCII.GetBytes(jsonString);
			NetService.StartTransmission(vs);


			//App.Current.MainPage = new AddContact();	
		}

		private void GetContacts()
		{
			var token = "0101";
			personalToken.Text = $"Personal Token: {token}";
			People = _context.People.ToList();
			if (People.Count > 0)
			{
				AddContactsToPage();
			}
		}
		private void AddContactsToPage()
		{
			for (int i = 0; i < People.Count; i++)
			{
				var button = new Button
				{
					Text = People[i].Name,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					TextColor = Colors.White,
					BackgroundColor = Color.FromArgb("#097ef0"),

				};
				button.Clicked += (sender, e) =>
				{

				};
				verticalStack.Add(button);
			}

		}
		private async void OnPurgeContacts(object sender, EventArgs e)
		{
			foreach (Person person in People)
			{
				_context.People.Remove(person);
			}
			await _context.SaveChangesAsync();
			App.Current.MainPage = new MainPage();
			await Navigation.PopAsync();
		}

	}
}

