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
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Finance_App.Pages
{
    public partial class LookUp : Page
    {
        public LookUp()
        {
            InitializeComponent();
        }

        private async void Search(object sender, RoutedEventArgs e)
        {
            string Posturl = "https://junhyeokyoon.xyz/api/stock/";
            IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
{
            new KeyValuePair<string, string>("ticker", lookupticker.Text),
};
            HttpContent postdata = new FormUrlEncodedContent(data);
            using (HttpClient PostClient = new HttpClient())
            {
                using (HttpResponseMessage response = await PostClient.PostAsync(Posturl, postdata))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic ApiData = JObject.Parse(content);

                    if (ApiData.status == "pass")
                    { 
                        ticker.Content = ApiData.Ticker;
                        price.Content = "$" + ApiData.price_container;
                        openprice.Content = "$" + ApiData.openprice_container;
                        hightoday.Content = "$" + ApiData.hightoday_container;
                        lowtoday.Content = "$" + ApiData.lowtoday_container;
                        yearhigh.Content = "$" + ApiData.high52_container;
                        yearlow.Content = "$" + ApiData.low52_container;
                    }
                    else
                    {
                        ticker.Content = "This stock does not exist";
                        price.Content = "";
                        openprice.Content = "";
                        hightoday.Content = "";
                        lowtoday.Content = "";
                        yearhigh.Content = "";
                        yearlow.Content = "";
                    }

                }
            }

        }
    }
}
