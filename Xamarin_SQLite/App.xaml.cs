using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_SQLite.Repositories;

namespace Xamarin_SQLite
{
    public partial class App : Application
    {
        protected string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        public static HumeurRepository HumeurRepository { get; set; }
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
