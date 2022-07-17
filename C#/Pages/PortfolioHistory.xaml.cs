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
    /// Interaction logic for PortfolioHistory.xaml
    /// </summary>
    public partial class PortfolioHistory : Page
    {
        public PortfolioHistory(string data)
        {
            InitializeComponent();

            dynamic Transactions = JsonConvert.DeserializeObject(data);

            for (int i = 0; i < Transactions.Count; i++)
            {
                //Creates new Row Defintion
                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(30, GridUnitType.Pixel);
                grid.RowDefinitions.Add(newRow);

                //Add Ticker
                Label Ticker = new Label();
                Ticker.Content = Transactions[i].Ticker;
                Ticker.BorderBrush = Brushes.Black;
                Ticker.BorderThickness = new Thickness(1);
                Ticker.VerticalAlignment = VerticalAlignment.Stretch;
                Ticker.VerticalContentAlignment = VerticalAlignment.Center;
                Ticker.HorizontalAlignment = HorizontalAlignment.Stretch;
                Ticker.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(Ticker, 0);
                Grid.SetRow(Ticker, 2 + i);
                grid.Children.Add(Ticker);

                //Add buysell
                Label buysell = new Label();
                buysell.Content = Transactions[i].BuySell;
                buysell.BorderBrush = Brushes.Black;
                buysell.BorderThickness = new Thickness(1);
                buysell.VerticalAlignment = VerticalAlignment.Stretch;
                buysell.VerticalContentAlignment = VerticalAlignment.Center;
                buysell.HorizontalAlignment = HorizontalAlignment.Stretch;
                buysell.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(buysell, 1);
                Grid.SetRow(buysell, 2 + i);
                grid.Children.Add(buysell);

                //Add Price
                Label TickerPrice = new Label();
                TickerPrice.Content = "$" + Transactions[i].Price;
                TickerPrice.BorderBrush = Brushes.Black;
                TickerPrice.BorderThickness = new Thickness(1);
                TickerPrice.VerticalAlignment = VerticalAlignment.Stretch;
                TickerPrice.VerticalContentAlignment = VerticalAlignment.Center;
                TickerPrice.HorizontalAlignment = HorizontalAlignment.Stretch;
                TickerPrice.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(TickerPrice, 2);
                Grid.SetRow(TickerPrice, 2 + i);
                grid.Children.Add(TickerPrice);

                //Add Shares
                Label TickerShares = new Label();
                TickerShares.Content = Transactions[i].Shares;
                TickerShares.BorderBrush = Brushes.Black;
                TickerShares.BorderThickness = new Thickness(1);
                TickerShares.VerticalAlignment = VerticalAlignment.Stretch;
                TickerShares.VerticalContentAlignment = VerticalAlignment.Center;
                TickerShares.HorizontalAlignment = HorizontalAlignment.Stretch;
                TickerShares.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(TickerShares, 3);
                Grid.SetRow(TickerShares, 2 + i);
                grid.Children.Add(TickerShares);

                //Add Total Value
                Label TotalVal = new Label();
                TotalVal.Content = Transactions[i].TotalValue;
                TotalVal.BorderBrush = Brushes.Black;
                TotalVal.BorderThickness = new Thickness(1);
                TotalVal.VerticalAlignment = VerticalAlignment.Stretch;
                TotalVal.VerticalContentAlignment = VerticalAlignment.Center;
                TotalVal.HorizontalAlignment = HorizontalAlignment.Stretch;
                TotalVal.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(TotalVal, 4);
                Grid.SetRow(TotalVal, 2 + i);
                grid.Children.Add(TotalVal);

                //Add Date
                Label TransactionDate = new Label();
                TransactionDate.Content = Transactions[i].Date;
                TransactionDate.BorderBrush = Brushes.Black;
                TransactionDate.BorderThickness = new Thickness(1);
                TransactionDate.VerticalAlignment = VerticalAlignment.Stretch;
                TransactionDate.VerticalContentAlignment = VerticalAlignment.Center;
                TransactionDate.HorizontalAlignment = HorizontalAlignment.Stretch;
                TransactionDate.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(TransactionDate, 5);
                Grid.SetRow(TransactionDate, 2 + i);
                grid.Children.Add(TransactionDate);

                //Add Delete Button
                Button Newbtn = new Button();
                Newbtn.Content = "Delete";
                Newbtn.BorderBrush = Brushes.Black;
                Newbtn.BorderThickness = new Thickness(1);
                Newbtn.VerticalAlignment = VerticalAlignment.Stretch;
                Newbtn.VerticalContentAlignment = VerticalAlignment.Center;
                Newbtn.HorizontalAlignment = HorizontalAlignment.Stretch;
                Newbtn.HorizontalContentAlignment = HorizontalAlignment.Center;
                //Newbtn.Click += new RoutedEventHandler(DeleteBtn);
                Grid.SetColumn(Newbtn, 6);
                Grid.SetRow(Newbtn, 2 + i);
                grid.Children.Add(Newbtn);

            }
        }

        public PortfolioHistory()
        {
            
        }
    }
}
