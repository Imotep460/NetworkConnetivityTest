using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NetworkConnetivityTest.Data;

namespace NetworkConnetivityTest
{
    public partial class MainPage : ContentPage
    {
        // IMDB Json
        //private OpenDataManager openDataManager = new OpenDataManager();

        // Itunes Json
        private OpenDataITunesManager openDataITunesManager = new OpenDataITunesManager();


        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            OpenDataITunes itemCollection = await openDataITunesManager.GetAll();
            //lvIMDB.ItemsSource = itemCollection.d;
        }
    }
}
