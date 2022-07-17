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
using System.Net.Http;

using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Finance_App.Pages
{
    /// <summary>
    /// Interaction logic for Accounts.xaml
    /// </summary>
    public partial class Accounts : Page
    {
        public Accounts(string data)
        {
            InitializeComponent();

            dynamic content = JsonConvert.DeserializeObject(data);

            for (int i=0; i<content.Count; i++)
            {
                //Creates new Row Defintion
                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(30, GridUnitType.Pixel);
                grid.RowDefinitions.Add(newRow);

                //Add Account Name
                Label NewName = new Label();
                NewName.Content = content[i].Name;
                NewName.BorderBrush = Brushes.Black;
                NewName.BorderThickness = new Thickness(1);
                NewName.VerticalAlignment = VerticalAlignment.Stretch;
                NewName.VerticalContentAlignment = VerticalAlignment.Center;
                NewName.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewName.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewName, 0);
                Grid.SetRow(NewName, 2+i);
                grid.Children.Add(NewName);

                //Add Account Amount
                Label NewAmount = new Label();
                NewAmount.Content = "$" + content[i].Amount;
                NewAmount.BorderBrush = Brushes.Black;
                NewAmount.BorderThickness = new Thickness(1);
                NewAmount.VerticalAlignment = VerticalAlignment.Stretch;
                NewAmount.VerticalContentAlignment = VerticalAlignment.Center;
                NewAmount.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewAmount.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewAmount, 1);
                Grid.SetRow(NewAmount, 2 + i);
                grid.Children.Add(NewAmount);

                //Add Account Type
                Label NewType = new Label();
                NewType.Content = content[i].Type;
                NewType.BorderBrush = Brushes.Black;
                NewType.BorderThickness = new Thickness(1);
                NewType.VerticalAlignment = VerticalAlignment.Stretch;
                NewType.VerticalContentAlignment = VerticalAlignment.Center;
                NewType.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewType.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewType, 2);
                Grid.SetRow(NewType, 2 + i);
                grid.Children.Add(NewType);

                //Add Delete Button
                Button Newbtn = new Button();
                Newbtn.Content = "Delete";
                Newbtn.BorderBrush = Brushes.Black;
                Newbtn.BorderThickness = new Thickness(1);
                Newbtn.VerticalAlignment = VerticalAlignment.Stretch;
                Newbtn.VerticalContentAlignment = VerticalAlignment.Center;
                Newbtn.HorizontalAlignment = HorizontalAlignment.Stretch;
                Newbtn.HorizontalContentAlignment = HorizontalAlignment.Center;
                Newbtn.Click += new RoutedEventHandler(DeleteBtn);
                Grid.SetColumn(Newbtn, 3);
                Grid.SetRow(Newbtn, 2 + i);
                grid.Children.Add(Newbtn);
            }



        }

        public Accounts()
        {

        }

        private void AddBtn(object sender, RoutedEventArgs e)
        {
         



        }
        private void DeleteBtn(object sender, RoutedEventArgs e)
        {




        }
    }
}
