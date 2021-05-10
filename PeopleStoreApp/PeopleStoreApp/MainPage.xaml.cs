using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PeopleStoreApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IPeopleClient client;
        private Person person = new Person();
        public MainPage()
        {
           // InitializeComponent();

            btnPhoto.Clicked += btnPhoto_Clicked;

        }

        private async void btnPhoto_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {

            });

            if (photo == null)
                return;
        }
    }
}
