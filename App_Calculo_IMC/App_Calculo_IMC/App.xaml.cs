using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Calculo_IMC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImcView();
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
