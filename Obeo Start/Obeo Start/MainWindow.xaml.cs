using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Obeo_Start
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        String url = "https://maps.googleapis.com/maps/api/distancematrix/json?";
        String API_KEY = "&key=AIzaSyDOyS263waxSPC1syxc0SPu-vDQkCjufCw";
        String units = "&units=metric";
        String origin = "&origins=";
        String destination = "&destinations=";
        String mode = "&mode=driving";
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            origin = origin + Origin_Box.Text;
            destination = destination + Destination_Box.Text;

            url = url + units + origin + destination + mode + API_KEY;

            ObeoRestClient o = new ObeoRestClient(url,httpRequestType.GET);
            String response = o.executeRequest();
            Response_Box.Text = response;

            RootObject r = JsonConvert.DeserializeObject<RootObject>(response);

            City_Box.Text = r.destination_addresses[0];
        }

        private void Origin_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
