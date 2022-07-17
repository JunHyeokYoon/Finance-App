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
using Newtonsoft.Json;
namespace Finance_App.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            LogIn login = new LogIn();
            NavigationService.Navigate(login);

        }

        private async void Registerbtn(object sender, RoutedEventArgs e)
        {
            string Posturl = "http://137.184.50.180:8000/api/CreateUser/";
            IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("FirstName", fname.Text),
                new KeyValuePair<string, string>("LastName", lname.Text),
                new KeyValuePair<string, string>("username", Username.Text),
                new KeyValuePair<string, string>("email", Email.Text),
                new KeyValuePair<string, string>("password1", Password1.Text),
                new KeyValuePair<string, string>("password2", Password2.Text),

            };
            HttpContent postdata = new FormUrlEncodedContent(data);
            using (HttpClient PostClient = new HttpClient())
            {
                using (HttpResponseMessage response = await PostClient.PostAsync(Posturl, postdata))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                    if (dict.Keys.First() == "username")
                    {

                    }
                    errorfield.Content = dict.Keys.First() + " field:  " + dict.Values.First();
                    

                }
            }
        }
    }
}
