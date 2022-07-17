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
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Finance_App.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        string username;
        string password;
        string content;

        string AccountData;
        string PortfolioData;
        string PortfolioHistoryData;
        string TransactionData;
        string UserData;
        public Main(string id, string pw, string data)
        {
            InitializeComponent();
            username = id;
            password = pw;

            dynamic content = JObject.Parse(data);
            AccountData = JsonConvert.SerializeObject(content.Accounts);
            TransactionData = JsonConvert.SerializeObject(content.Transactions);
            UserData = JsonConvert.SerializeObject(content.User);
            PortfolioData = JsonConvert.SerializeObject(content.Portfolio);
            PortfolioHistoryData = JsonConvert.SerializeObject(content.PortfolioHistory);

            Home home = new Home(AccountData, PortfolioData);
            ContentFrame.Content = home;

            UserField.Text = "Hello " + content.User[0].first_name + " " + content.User[0].last_name;
        }




        private void HomeBtn(object sender, RoutedEventArgs e)
        {
            Home home = new Home(AccountData, PortfolioData);
            ContentFrame.Content = home;
        }

        private void TransactionBtn(object sender, RoutedEventArgs e)
        {
            Transactions transaction = new Transactions(TransactionData);
            ContentFrame.Content = transaction;
        }

        private void AccountsBtn(object sender, RoutedEventArgs e)
        {
            Accounts account = new Accounts(AccountData);
            ContentFrame.Content = account;
        }

        private void PortfolioBtn(object sender, RoutedEventArgs e)
        {
            Portfolio portfolio = new Portfolio(PortfolioData);
            ContentFrame.Content = portfolio;
        }

        private void PortfolioHistoryBtn(object sender, RoutedEventArgs e)
        {
            PortfolioHistory portfoliohistory = new PortfolioHistory(PortfolioHistoryData);
            ContentFrame.Content = portfoliohistory;
        }

        private void LookUpBtn(object sender, RoutedEventArgs e)
        {
            LookUp lookup = new LookUp();
            ContentFrame.Content = lookup;
        }


        private void LogOutBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.MainFrame.Content = new LogIn();
        }
    }
}
