   M S B A M L   `   `   `  ����F  BFinance App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Finance_App.PagesFinance_App.Pages  5           Finance_App.Pages.Accounts   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Finance_App.Pages     5        N� Title$  Accounts��5	      .��5      � -   5         �Name$
 grid��5      
������� � ColumnDefinitions 5   
   �� 5      $��0.30* �6   �� 5      $��0.30* �6   �� 5      $��0.30* �6   �� 5      $��0.10* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��Center=�6   $��Stretch=�64   $��Account Name��6R   $��0��6i   $��0��6y   �� 5   
   $��Center=�6   $��Stretch=�64   $��Account Amount��6R   $��1��6k   $��0��6{   �� 5   
   $��Center=�6   $��Stretch=�64   $��Account Type��6R   $��2��6i   $��0��6y   �� 5   
   -   5         ��Name$ AccountName��5      $��0��6'   $��1��67   $��20��6D   6R   �� 5   
   -   5        $ AccountAmount��5      $��1��6)   $��1��69   $��20��6F   6T   �� 5   
   -   5        $ AccountType��5      $��2��6'   $��1��67   $��20��6D   6R   �� 5   
   -   5         ��Name$ 
AccountAdd��5   S   $��Center=�6   $��Stretch=�65   $��3��6g   $��1��6w   $��20��6�   $	��Add��6�   6�   5       5!      