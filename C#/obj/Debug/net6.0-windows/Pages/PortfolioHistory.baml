   M S B A M L   `   `   `  ����F  BFinance App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Finance_App.PagesFinance_App.Pages  5      (    "Finance_App.Pages.PortfolioHistory   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Finance_App.Pages     5        N� Title$  PortfolioHistory��5	      .��5      � -   5         �Name$
 grid��5      
������� � ColumnDefinitions 5   
   �� 5      $��0.15* �6   �� 5      $��0.15* �6   �� 5      $��0.15* �6   �� 5      $��0.15* �6   �� 5      $��0.15* �6   �� 5      $��0.15* �6   �� 5      $��0.10* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��Center=�6   $��Stretch=�64   $��Ticker��6R   $��0��6c   $��0��6s   �� 5   
   $��Center=�6   $��Stretch=�64   $��Buy/Sell��6R   $��1��6e   $��0��6u   �� 5   
   $��Center=�6   $��Stretch=�64   $��Price��6R   $��2��6b   $��0��6r   �� 5   
   $��Center=�6   $��Stretch=�64   $��Shares��6R   $��3��6c   $��0��6s   �� 5   
   $��Center=�6   $��Stretch=�64   $��Total Value��6R   $��4��6h   $��0��6x   �� 5   
   $��Center=�6   $��Stretch=�64   $
��Date��6R   $��5��6a   $��0��6q   �� 5!   
   -   5         ��Name$ Ticker��5!      $��0��6"   $��1��62   $��20��6?   6M   �� 5"   
   -   5        $ BuySell��5"      $��1��6#   $��1��63   $��20��6@   6N   �� 5#   
   -   5        $ TickerPrice��5#      $��2��6'   $��1��67   $��20��6D   6R   �� 5$   
   -   5        $ Shares��5$      $��3��6"   $��1��62   $��20��6?   6M   �� 5%   
   -   5        $ TotalVal��5%      $��4��6$   $��1��64   $��20��6A   6O   �� 5&   
   -   5        $
 Date��5&      $��5��6    $��1��60   $��20��6=   6K   �� 5'   
   -   5         ��Name$ TransactionAdd��5'   S   $��Center=�6   $��Stretch=�65   $��6��6k   $��1��6{   $��20��6�   $	��Add��6�   6�   5*      5+      