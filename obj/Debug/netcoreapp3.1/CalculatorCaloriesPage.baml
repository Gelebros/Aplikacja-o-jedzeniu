   M S B A M L   `   `   `  ����X  TFrontend aplikacja o jedzeniu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Frontend_aplikacja_o_jedzeniuFrontend_aplikacja_o_jedzeniu  5	      p lMicrosoft.Toolkit.Wpf.UI.Controls.WebView, Version=6.1.0.0, Culture=neutral, PublicKeyToken=4aff67a105548ee2�bclr-namespace:Microsoft.Toolkit.Wpf.UI.Controls;assembly=Microsoft.Toolkit.Wpf.UI.Controls.WebView!Microsoft.Toolkit.Wpf.UI.Controls 5
      :    4Frontend_aplikacja_o_jedzeniu.CalculatorCaloriesPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <dg-http://schemas.microsoft.com/wpf/2008/toolkit     5      =local+clr-namespace:Frontend_aplikacja_o_jedzeniu     5	      wControlsbclr-namespace:Microsoft.Toolkit.Wpf.UI.Controls;assembly=Microsoft.Toolkit.Wpf.UI.Controls.WebView     5
        N� Title$  Stronakalkulatorkalori��5       � 	Resources 5         DataGridCell �� 
TargetType*  $System.Windows.Controls.DataGridCell  DataGridRow)  #System.Windows.Controls.DataGridRow��%V   &	        &	 !     �� 5   
   "  6%   5      �� 5   
   "  6$   5      5      .��5      � .+�5   
   �� -   5         ��Name$ lblCal��5      $��0��6    $
��Left=�6,   $��	94,10,0,0q�6G   $	��Top=�6Z   $	��140��6r   $	��591��6   ���	#FFEEEBEB���	#FFF0EBEB$��20(�6�   $��Rockwell Extra Bold)�6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   ���	#FF1D0505$��32��6�   $��84��6�   ���	#FFF4F4F4$��Result��6�   �� 5   
   -   5         ��Name$ btnAddSPCal��5      $��Add Calories��6&   $
��Left=�6=   $��543,155,0,0q�6X   $	��Top=�6m   $��60��6�   $	��166��6�   6�   �� 5   
   -   5        $ btnResetCal��5      $��Reset��6&   $
��Left=�66   $��543,215,0,0q�6Q   $	��Top=�6f   $��60��6~   $	��166��6�   6�   �� 5   
   -   5        $ btnSaveCalories��5      $��Save ��6*   $
��Left=�6:   $��543,395,0,0q�6U   $	��Top=�6j   $��65��6�   $	��166��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagridCal��5      $��10,163,171,25q�6(      AutoGenerateColumns$ False��5         SelectionUnit$ FullRow=�5          SelectionMode$ Single=�6    	   
IsReadOnly$
	 True��5!      
   CanUserAddRows$
 False��6      	CellStyle# [  5"         RowStyle# [ 5#       �� SelectedItem 5$      �� *SelectedProduct+ �� Mode$ TwoWay=���5%      ��    Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ Drinks��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Drinks+  5*      $
 Meal��6%    63   �� *Meal+  5,      $ Singleproducts��6%    6=   �� *Singleproducts+  5-      $ Calories��6%    67   �� *
Calories+5/      �� 50   
   -   5        $ btnResetData��50      $��
Reset Data��6'   $
��Left=�6<   $��543,345,0,0q�6W   $	��Top=�6l   $��50��6�   $	��166��6�   6�   �� 51   
   -   5        $ btnCreateTableCal��51      $��Create DataTable��6,   $
��Left=�6G   $��543,275,0,0q�6b   $	��Top=�6w   $��70��6�   $	��166��6�   6�   54      55      