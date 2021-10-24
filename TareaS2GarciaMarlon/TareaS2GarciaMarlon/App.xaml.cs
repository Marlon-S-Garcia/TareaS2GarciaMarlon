using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS2GarciaMarlon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habilita la navegacion entre ventanas
            MainPage = new  NavigationPage (new MainPage());
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
