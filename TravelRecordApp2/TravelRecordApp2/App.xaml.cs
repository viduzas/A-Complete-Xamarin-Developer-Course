﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TravelRecordApp2
{
	public partial class App : Application
	{
        public static string DatabaseLocation = string.Empty;
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

        public App(string databaseLocation) // Lesson 51
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}