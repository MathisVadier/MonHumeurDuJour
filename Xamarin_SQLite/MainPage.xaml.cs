using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XamarinForms_SQLite.Repositories;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void HumeurButton_Clicked(object sender, EventArgs e)
        {
            int note = 0;
            // Appel de la méthode AjouterHumeurAsync de la classe HumeurRepository
            if (bonneHumeurRadio.IsChecked)
            {
                note = 1;
            }
            
            await App.HumeurRepository.AjouterHumeurAsync(humeurEntry.Text,note,DateTime.Now);
        }
    }
}
