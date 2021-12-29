using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PIC_BIANCA_LAB12.Data;

namespace PIC_BIANCA_LAB12
{
    public partial class App : Application
    {

        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
