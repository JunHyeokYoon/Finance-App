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
    /// Interaction logic for Portfolio.xaml
    /// </summary>
    public partial class Portfolio : Page
    {
        public Portfolio(string data)
        {
            InitializeComponent();
            dynamic PortfolioData = JsonConvert.DeserializeObject(data);

            for (int i = 0; i < PortfolioData.Count; i++)
            {
                //Creates new Row Defintion
                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(30, GridUnitType.Pixel);
                grid.RowDefinitions.Add(newRow);

                //Add Ticker
                Label Ticker = new Label();
                Ticker.Content = PortfolioData[i].Ticker;
                Ticker.BorderBrush = Brushes.Black;
                Ticker.BorderThickness = new Thickness(1);
                Ticker.VerticalAlignment = VerticalAlignment.Stretch;
                Ticker.VerticalContentAlignment = VerticalAlignment.Center;
                Ticker.HorizontalAlignment = HorizontalAlignment.Stretch;
                Ticker.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(Ticker, 0);
                Grid.SetRow(Ticker, 1 + i);
                grid.Children.Add(Ticker);

                //Add Average Price
                Label NewAveragePrice= new Label();
                NewAveragePrice.Content = "$" +  PortfolioData[i].AveragePrice;
                NewAveragePrice.BorderBrush = Brushes.Black;
                NewAveragePrice.BorderThickness = new Thickness(1);
                NewAveragePrice.VerticalAlignment = VerticalAlignment.Stretch;
                NewAveragePrice.VerticalContentAlignment = VerticalAlignment.Center;
                NewAveragePrice.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewAveragePrice.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewAveragePrice, 1);
                Grid.SetRow(NewAveragePrice, 1 + i);
                grid.Children.Add(NewAveragePrice);

                //Add Shares
                Label NewShares = new Label();
                NewShares.Content = PortfolioData[i].Shares;
                NewShares.BorderBrush = Brushes.Black;
                NewShares.BorderThickness = new Thickness(1);
                NewShares.VerticalAlignment = VerticalAlignment.Stretch;
                NewShares.VerticalContentAlignment = VerticalAlignment.Center;
                NewShares.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewShares.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewShares, 2);
                Grid.SetRow(NewShares, 1 + i);
                grid.Children.Add(NewShares);

                //Add Initial Price
                Label NewInitialValue = new Label();
                NewInitialValue.Content = "$" + PortfolioData[i].InitialValue;
                NewInitialValue.BorderBrush = Brushes.Black;
                NewInitialValue.BorderThickness = new Thickness(1);
                NewInitialValue.VerticalAlignment = VerticalAlignment.Stretch;
                NewInitialValue.VerticalContentAlignment = VerticalAlignment.Center;
                NewInitialValue.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewInitialValue.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewInitialValue, 3);
                Grid.SetRow(NewInitialValue, 1 + i);
                grid.Children.Add(NewInitialValue);

                //Add Current Price
                Label NewCurrentValue = new Label();
                NewCurrentValue.Content = "$" + PortfolioData[i].CurrentValue;
                NewCurrentValue.BorderBrush = Brushes.Black;
                NewCurrentValue.BorderThickness = new Thickness(1);
                NewCurrentValue.VerticalAlignment= VerticalAlignment.Stretch;
                NewCurrentValue.VerticalContentAlignment = VerticalAlignment.Center;
                NewCurrentValue.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewCurrentValue.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewCurrentValue, 4);
                Grid.SetRow(NewCurrentValue, 1 + i);
                grid.Children.Add(NewCurrentValue);

            }
        }

        public Portfolio()
        {
            
        }
    }
}
