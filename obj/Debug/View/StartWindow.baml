   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   A =MMAApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MMAApp.ViewMMAApp.View 5   	   3clr-namespace:MMAApp.ViewModelMMAApp.ViewModel 5
   	      MMAApp.View.StartWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:MMAApp.View     5   	   4	viewModelclr-namespace:MMAApp.ViewModel     5
   	     � Title$"  Start Window - Fight Metrics��5	   	   $	��350��6.   $	��591��6;   
������� � DataContext 5   	   ��    mainViewModelLocator �� Source# [   �� Path$ StartWindowViewModel�.��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Select Figther For Match��6   $
��Left=�6B   $��	37,27,0,0q�6]   $	��Top=�6p   $	��146��6�   $��31��6�   �� 5   
   -   5         ��Name$ listViewFighters��5      $
��Left=�6�   $	��201��6�   $��	37,63,0,0q�6�   $	��Top=�6�   $	��146��6�   ��6-   �� *
Fighters+ �� Mode$ TwoWay=� �� SelectedItem 6\   �� *SelectedFigther+$ TwoWay=� �� View 5      �� 5      .P�5      �� $
��Name��6)   	 �� DisplayMemberBinding	 67   �� *Name+5      5      �� 5   
   -   5        
 ��Name$
 button��5      $��Add Fighter��6G   $
��Left=�6]   $��
37,269,0,0q�6x   $	��Top=�6�   $	��146��6�    J� RenderTransformOrigin$ 
0.307,0.37&�6�   $��6��6�   ��6!   �� *AddFighterCommand+6�   �� 5   
   -   5        $ label1��5      $!��Selected Fighters for Match��6    $
��Left=�6F   $��
265,27,0,0q�6a   $	��Top=�6u   $ -0.658,-0.038&�6�   $	��156��6�   �� 5   
   -   5        $&  listViewSelectedFigthersForMatch��5      $
��Left=�6f   $	��201��6�   $��
265,63,0,0q�6�   $	��Top=�6�   $	��146��6�   ��6=   �� *FigthersForMatch+ 5      �� 5      .P�5      �� $
��Name��6%   	 63   �� *Name+5      5!      �� 5"   
   -   5        $
 button1��5"      $��Start Metrics��6J   $
��Left=�6b   $	��Top=�6}   $	��146��6�   $��265,267,0,0q�6�   ��6"   �� *StartMetricsCommand+6�   5$      5%      