   M S B A M L   `   `   `  ����X  TFrontend aplikacja o jedzeniu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Frontend_aplikacja_o_jedzeniuFrontend_aplikacja_o_jedzeniu  5      1    +Frontend_aplikacja_o_jedzeniu.TotalCalories   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Frontend_aplikacja_o_jedzeniu     5        N� Title$  TotalCalories��5	       � 	Resources 5
         DataGridCell �� 
TargetType*  $System.Windows.Controls.DataGridCell  DataGridRow)  #System.Windows.Controls.DataGridRow��%V   &	        &	 !     �� 5   
   "  6%   5      �� 5   
   "  6$   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagridTotalCal��5      $��217,160,217,75q�6-      AutoGenerateColumns$ False��6z      
IsReadOnly$
 True��5         CanUserAddRows$ False��6&      	CellStyle# [  5         RowStyle# [ 5      ��5      �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
RecordDate��6%      MinWidth$ 8Q�6X      Width5  /System.Windows.Controls.DataGridLengthConverter$ 99 6e      MaxWidth$	 100Q�6p      FontSize$ 20Q�6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
RecordDate+6     5      $
 Calories��6%   $ 20Q�6T    67   �� *
Calories+6T   5      �� 5   
   -   5         ��Name$ lblTotalCal��5      $��Label��6%   $��Center=�65   $��0,10,0,0q�6R   $	��Top=�6d   $	��661��6|   $	��130��6�   5       5!      