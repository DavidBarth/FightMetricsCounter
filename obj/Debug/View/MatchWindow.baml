   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   A =MMAApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MMAApp.ViewMMAApp.View 5	   	   3clr-namespace:MMAApp.ViewModelMMAApp.ViewModel 5   	      MMAApp.View.MatchWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   +localclr-namespace:MMAApp.View     5	   	   4	viewModelclr-namespace:MMAApp.ViewModel     5   	   -   5          � Title$"  Match Window - Fight Metrics��5   	   $	��400��6.   $	��533��6;   
������� � DataContext 5   	   ��    mainViewModelLocator �� Source# [   �� Path$ MatchWindowViewModel�.��5      � $	��390��6   $	��Top=�6   $��	0,0,0,-20q�60   .+�5   
   �� -   5         ��Name$ Fighter1Label��5      $��	Figther 1��6'   $
��Left=�6;   $	��Top=�6V   $��64��6n   $��	45,27,0,0q�6y   �� 5   
   -   5         ��Name$ textBox1��5      
�������$
��Left=�6c   $��23��6~   $��	45,58,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6:   �� *FightersInMatch[0].Name+6�   �� 5   
   -   5        $ Fighter2Label��5      $��	Fighter 2��6'   $
��Left=�6;   $��
350,27,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ textBox2��5      
�������$
��Left=�6b   $��23��6}   $��
350,58,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��121��6�   ��69   �� *FightersInMatch[1].Name+6�   �� 5   
   -   5         ��Name$ groupBox��5      $"��Press characters accordingly��6%   $��
22,86,23,0q�6K   $	��Top=�6_   $	��129��6w   5      �� 5   
   -   5        $ HeadTextBlock1��5      $
��Left=�6,   $��
45,124,0,0q�6G   $
��Wrap=�6[   $��Head Strikes Q��6o   $	��Top=�6�   $��16��6�    J� RenderTransformOrigin$ 0.456,-0.625&�6�   $��88��6�   �� 5    
   -   5        $ BodyText1Block1��5       $
��Left=�6-   $��
45,158,0,0q�6H   $
��Wrap=�6\   $��Body Strikes W��6p   $	��Top=�6�   $��16��6�   $ 0.456,-0.625&�6�   �� 5!   
   -	   5        $ LegTextBlock1��5!      $
��Left=�6+   $��
45,189,0,0q�6F   $
��Wrap=�6Z   $��Leg Strikes E��6n   $	��Top=�6�   $��16��6�   $ 0.456,-0.625&�6�   �� 5"   
   -
   5        $ Head1��5"      $
��Left=�6$   $��23��6?   $��138,124,0,0q�6K   $
��Wrap=�6`   $	��Top=�6t   $	��121��6�   5&      �� 5'   
   -   5        $ Body1��5'      $
��Left=�6#   $��23��6>   $��139,158,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5(   
   -   5        $
 Leg1��5(      $
��Left=�6"   $��23��6=   $��139,189,0,0q�6I   $
��Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5*   
   -   5        $ HeadTextBlock2��5*      $
��Left=�6,   $��350,155,0,0q�6G   $
��Wrap=�6\   $��Body Strikes O��6p   $	��Top=�6�   $��16��6�   $ 0.456,-0.625&�6�   �� 5+   
   -   5        $ BodyTextBlock2��5+      $
��Left=�6,   $��350,186,0,0q�6G   $
��Wrap=�6\   $��Leg Strikes P��6p   $	��Top=�6�   $��16��6�   $ 0.456,-0.625&�6�   �� 5,   
   -   5        $ LegTextBlock2��5,      $
��Left=�6+   $��350,121,0,0q�6F   $
��Wrap=�6[   $��Head Strikes I��6o   $	��Top=�6�   $��16��6�   $ 0.456,-0.625&�6�   $��88��6�   �� 5-   
   -   5        $ Head2��5-      $
��Left=�6#   $��23��6>   $��443,121,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $��49��6�   �� 5.   
   -   5        $ Body2��5.      $
��Wrap=�6#   $��443,155,23,211q�67   �� 5/   
   -   5        $
 Leg2��5/      $
��Left=�6"   $��443,186,0,0q�6=   $
��Wrap=�6R   $	��Top=�6f   $��49��6~   �� 51   
   -   5         ��Name$ button��51      $��SAVE RESULTS��6!   $
��Left=�68   $��402,331,0,0q�6S   $	��Top=�6h   $	��100��6�   �� 52   
   -   5        $ 
StartTimer��52      $��
StartTimer��6%   $
��Left=�6:   $��106,237,0,0q�6U   $	��Top=�6j   $��75��6�   �� 53   
   -   5        $ 	StopTimer��53      $��	StopTimer��6$   $
��Left=�68   $��106,331,0,0q�6S   $	��Top=�6h   $��75��6�   �� 54   
   -   5        $ CounterLabel��54      
�������$
��Left=�6=   $��106,285,0,0q�6X   $	��Top=�6m   $��75��6�   �� 55   
   -   5        $ 
TimerLabel��55      $��
Match Time��6$   $
��Left=�69   $��
22,285,0,0q�6T   $	��Top=�6h   $��79��6�   59      5:      