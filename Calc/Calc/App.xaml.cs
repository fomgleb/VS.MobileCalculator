﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calc
{
    public partial class App : Application
    {
        public static int ScreenWidth;
        public static int ScreenHeight;
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
