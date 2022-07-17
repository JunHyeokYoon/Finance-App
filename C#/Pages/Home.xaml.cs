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
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Finance_App.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        int AccountTotal;
        int PortfolioTotal;
        public Home(string data, string data2)
        {
            InitializeComponent();
            dynamic PortfolioData = JsonConvert.DeserializeObject(data2);
            dynamic AccountData = JsonConvert.DeserializeObject(data);
            for(int i = 0; i < PortfolioData.Count; i++)
            {
                label.Content = PortfolioData[i].CurrentValue;
                
            }   

            //label.Text = PortfolioTotal.ToString();
        }

        public Home()
        {

        }
    }
}
