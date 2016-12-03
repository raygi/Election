﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Election.SharedView;
using Xamarin.Forms;
//using Election.SharedModel.Context;

namespace Election
{
    public class App : Application
    {
        //public static ElectionDbContext Election { get; private set; }

        public App()
        {
            //Election = new ElectionDbContext(dbPath);

            MainPage = new SharedView.StartPage();
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
}
