using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StubbornIcon
{
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();

			Message.Text = Device.OnPlatform<String> (
				iOS: "I'm happy, as the drawer icon is visible.",
				Android: "I'm an unhappy label, crying over the unchanged drawer icon on Android.",
				WinPhone: "I've got no Windows devices to check this."
			);
		}
	}
}

