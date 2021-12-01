using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using MsgApp.Models;
using MsgApp.Services;

namespace MsgApp.Pages
{
	public partial class MessageDialog : ContentPage
	{
		private Person Person = null;
		private readonly DataContext _context = new DataContext();
		public MessageDialog (Person person)
		{
			InitializeComponent();
			Person = _context.People.FirstOrDefault(m => m.Id == person.Id);
		}

		private void GetMessages(object sender, EventArgs e)
		{

        }

		private void OnSendMessage(object sender, EventArgs e)
        {
			// Get message from entry
			var data = dataEntry.Text;
			// Build Message


        }

	}
}