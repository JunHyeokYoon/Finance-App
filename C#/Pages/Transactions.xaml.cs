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
    /// Interaction logic for Transactions.xaml
    /// </summary>
    public partial class Transactions : Page
    {
        public Transactions(string Transactiondata)
        {
            InitializeComponent();
            dynamic Transactions = JsonConvert.DeserializeObject(Transactiondata);

            for (int i = 0; i < Transactions.Count; i++)
            {
                //Creates new Row Defintion
                RowDefinition newRow = new RowDefinition();
                newRow.Height = new GridLength(30, GridUnitType.Pixel);
                grid.RowDefinitions.Add(newRow);

                //Add Transaction Name
                Label NewName = new Label();
                NewName.Content = Transactions[i].Name;
                NewName.BorderBrush = Brushes.Black;
                NewName.BorderThickness = new Thickness(1);
                NewName.VerticalAlignment = VerticalAlignment.Stretch;
                NewName.VerticalContentAlignment = VerticalAlignment.Center;
                NewName.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewName.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewName, 0);
                Grid.SetRow(NewName, 2 + i);
                grid.Children.Add(NewName);

                //Add Transaction Amount
                Label NewAmount = new Label();
                NewAmount.Content = "$" + Transactions[i].Amount;
                NewAmount.BorderBrush = Brushes.Black;
                NewAmount.BorderThickness = new Thickness(1);
                NewAmount.VerticalAlignment = VerticalAlignment.Stretch;
                NewAmount.VerticalContentAlignment = VerticalAlignment.Center;
                NewAmount.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewAmount.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewAmount, 1);
                Grid.SetRow(NewAmount, 2 + i);
                grid.Children.Add(NewAmount);

                //Add Transaction Type
                Label NewType = new Label();
                NewType.Content = Transactions[i].Type;
                NewType.BorderBrush = Brushes.Black;
                NewType.BorderThickness = new Thickness(1);
                NewType.VerticalAlignment = VerticalAlignment.Stretch;
                NewType.VerticalContentAlignment = VerticalAlignment.Center;
                NewType.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewType.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewType, 2);
                Grid.SetRow(NewType, 2 + i);
                grid.Children.Add(NewType);

                //Add Transaction Account
                Label NewAccount = new Label();
                NewAccount.Content = Transactions[i].Account;
                NewAccount.BorderBrush = Brushes.Black;
                NewAccount.BorderThickness = new Thickness(1);
                NewAccount.VerticalAlignment = VerticalAlignment.Stretch;
                NewAccount.VerticalContentAlignment = VerticalAlignment.Center;
                NewAccount.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewAccount.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewAccount, 3);
                Grid.SetRow(NewAccount, 2 + i);
                grid.Children.Add(NewAccount);

                //Add Transaction Date
                Label NewDate = new Label();
                NewDate.Content = Transactions[i].Date;
                NewDate.BorderBrush = Brushes.Black;
                NewDate.BorderThickness = new Thickness(1);
                NewDate.VerticalAlignment = VerticalAlignment.Stretch;
                NewDate.VerticalContentAlignment = VerticalAlignment.Center;
                NewDate.HorizontalAlignment = HorizontalAlignment.Stretch;
                NewDate.HorizontalContentAlignment = HorizontalAlignment.Center;
                Grid.SetColumn(NewDate, 4);
                Grid.SetRow(NewDate, 2 + i);
                grid.Children.Add(NewDate);

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
                Grid.SetColumn(Newbtn, 5);
                Grid.SetRow(Newbtn, 2 + i);
                grid.Children.Add(Newbtn);

            }
        }
        public Transactions()
        {
            
        }

        private void DeleteBtn(object sender, RoutedEventArgs e)
        {




        }
    }
}
