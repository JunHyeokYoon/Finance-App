   M S B A M L   `   `   `  ����F  BFinance App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Finance_App.PagesFinance_App.Pages  5      $    Finance_App.Pages.Transactions   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Finance_App.Pages     5        N� Title$  Transactions��5	      .��5      � -   5         �Name$
 grid��5      
������� � ColumnDefinitions 5   
   �� 5      $��0.18* �6   �� 5      $��0.18* �6   �� 5      $��0.18* �6   �� 5      $��0.18* �6   �� 5      $��0.18* �6   �� 5      $��0.10* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��Center=�6   $��Stretch=�64   $��Transaction Name��6R   $��0��6m   $��0��6}   �� 5   
   $��Center=�6   $��Stretch=�64   $��Transaction Amount��6R   $��1��6o   $��0��6   �� 5   
   $��Center=�6   $��Stretch=�64   $��Transaction Type��6R   $��2��6m   $��0��6}   �� 5   
   $��Center=�6   $��Stretch=�64   $��Account��6R   $��3��6d   $��0��6t   �� 5   
   $��Center=�6   $��Stretch=�64   $��Transaction Date��6R   $��4��6m   $��0��6}   �� 5   
   -   5         ��Name$ TransactionName��5      $��0��6+   $��1��6;   $��20��6H   6V   �� 5    
   -   5        $ TransactionAmount��5       $��1��6-   $��1��6=   $��20��6J   6X   �� 5!   
   -   5        $ TransactionType��5!      $��2��6+   $��1��6;   $��20��6H   6V   �� 5"   
   -   5        $ TransactionAccount��5"      $��3��6.   $��1��6>   $��20��6K   6Y   �� 5#   
   -   5        $ TransactionDate��5#      $��4��6+   $��1��6;   $��20��6H   6V   �� 5$   
   -   5         ��Name$ TransactionAdd��5$   S   $��Center=�6   $��Stretch=�65   $��5��6k   $��1��6{   $��20��6�   $	��Add��6�   6�   5'      5(      