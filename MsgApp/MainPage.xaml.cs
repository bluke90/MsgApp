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
using MsgApp.Models;
using MsgApp.Pages;
using Microsoft.Maui.Graphics;

namespace MsgApp
{
	public partial class MainPage : ContentPage
	{

		private readonly MsgApp.Services.DataContext _context;

		private List<Person> People { get; set; }

		public MainPage()
		{
			_context = new Services.DataContext();
			InitializeComponent();
			Task.Run(() => GetContacts());
			if (People.Count > 0)
			{
				AddContactsToPage();
			}
		}

		private void OnAddContact(object sender, EventArgs e)
		{
			App.Current.MainPage = new AddContact();
		}

		private async Task GetContacts()
		{
			People = await _context.People.ToListAsync();
		}
		private void AddContactsToPage()
		{
			for (int i = 0; i < People.Count; i++)
			{
				var button = new Button
				{
					Text = People[i].Name,
					HorizontalOptions = LayoutOptions.Center,
					TextColor = Colors.White,
					BackgroundColor = Colors.AliceBlue
				};
				button.Clicked += (sender, e) =>
				{

				};
				grid.Add(button);
			}
		}

	}
}

