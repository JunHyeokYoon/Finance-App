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
using Newtonsoft.Json.Linq;
using System.Net.Http;
namespace Finance_App.Pages
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void RegisterBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.MainFrame.Content = new Register();
        }

        private async void LogInBtn(object sender, RoutedEventArgs e)
        {


            string Posturl = "https://junhyeokyoon.xyz/api/";
            IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
{
            new KeyValuePair<string, string>("username", UsernameField.Text),
            new KeyValuePair<string, string>("password", PasswordField.Text)
};
            HttpContent postdata = new FormUrlEncodedContent(data);
            using (HttpClient PostClient = new HttpClient())
            {
                using (HttpResponseMessage response = await PostClient.PostAsync(Posturl, postdata))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic ApiData = JObject.Parse(content);

                    if (ApiData.Status == "Passed")
                    {
                        Main main = new Main(UsernameField.Text, PasswordField.Text, content);
                        NavigationService.Navigate(main);


                    }
                    else
                    {
                        ErrorField.Text = "Account information is incorrect";
                    }

                }
            }

        }
    }
}
