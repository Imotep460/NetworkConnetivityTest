using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetworkConnetivityTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
        {
            InitializeComponent();
            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                // Active WiFi connection.
            }
        }
    }
}