using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtendedEntryControl.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace TestAndSampleApp
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new MainContentPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}


	public class MainContentPage : ContentPage
	{
		public MainContentPage()
		{
			var extendedEntry = new ExtendedEntry();

			var extended1 = new ExtendedEntry()
			{
				PlaceholderTextColor = Color.Fuchsia,
				Placeholder = "Hello from placeholder"
			};

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Label
					{
						XAlign = TextAlignment.Center,
						Text = "Welcome to Xamarin Forms!"
					},
					extendedEntry,
					extended1
				}
			};
		}
	}
}
