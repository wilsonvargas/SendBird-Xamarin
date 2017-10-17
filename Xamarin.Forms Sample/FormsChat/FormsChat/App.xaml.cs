using FormsChat.Helpers;
using FormsChat.Resources;
using FormsChat.Views;
using SendBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormsChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SendBirdClient.Init(Resource.APP_ID);
            MainPage = new NavigationPage(new MainPage());
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
