   M S B A M L   `   `   `  ����F  BFinance App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Finance_App.PagesFinance_App.Pages  5      !    Finance_App.Pages.Portfolio   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Finance_App.Pages     5        N� Title$  	Portfolio��5	      .��5      � -   5         �Name$
 grid��5      
������� � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6    � RowDefinitions 5   
   �� 5      $��30 �6   .+�5   
   �� $��Center=�6   $��Stretch=�64   $��Ticker��6R   $��0��6c   $��0��6s   �� 5   
   $��Center=�6   $��Stretch=�64   $��Average Price��6R   $��1��6j   $��0��6z   �� 5   
   $��Center=�6   $��Stretch=�64   $��Shares��6R   $��2��6c   $��0��6s   �� 5   
   $��Center=�6   $��Stretch=�64   $��Initial Value��6R   $��3��6j   $��0��6z   �� 5   
   $��Center=�6   $��Stretch=�64   $��Current Value��6R   $��4��6j   $��0��6z   5      5      