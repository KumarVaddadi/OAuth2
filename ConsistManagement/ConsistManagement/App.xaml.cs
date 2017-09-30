using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsistManagement.Helpers;
using ConsistManagement.ViewModel;
using ConsistManagement.Views;
using Xamarin.Forms;

namespace ConsistManagement
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ConsistManagement.MainPage();
            //MainPage = new ConsistManagement.Views.ResgisterPage();
            MainPage = new NavigationPage(new ResgisterPage());
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
