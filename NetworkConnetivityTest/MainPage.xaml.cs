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
        private OpenDataManager openDataManager = new OpenDataManager();


        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            OpenDataItem itemCollection = await openDataManager.GetAll();
            lvIMDB.ItemsSource = itemCollection.d;
        }
    }
}
