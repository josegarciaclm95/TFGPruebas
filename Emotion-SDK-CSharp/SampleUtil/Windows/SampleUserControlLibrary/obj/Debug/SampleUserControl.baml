   M S B A M L   `   `   `  ����S  OSampleUserControlLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SampleUserControlLibrarySampleUserControlLibrary  5      .    (SampleUserControlLibrary.SampleScenarios   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:SampleUserControlLibrary     5      -   5          >�Name$   SampleScenariosUserControl��5       � 	Resources 5
      7   1SampleUserControlLibrary.ScenarioBindingConverter   ScenarioConverter��%   &	          5   
   6E   5      .��5      � $��Stretch=�6   $��0,0,0,0q�6)   $��Stretch=�6:    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $
��Auto �6   .+�5   
   ]� $��0��6   $��0��6!   $��2��61   ���#00b294.+�5      �� -   5         ��Name$ SampleNameLabel��5      $��Center=�6{   $��Center=�6�   $��
5, 0, 0, 0q�6�   $��26(�6�   ��61   ��  �� ElementName$  SampleScenariosUserControl�� �� Path$ SampleTitle�6�   5      �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��2��69   $��0��6J   ��5      �� 5       �� Color# � ��6"   .+�5      �� -   5        $��5q�5   @   $
��Left=�6L   ��6g   Z� ��6~   Z� .��6�   Subscription Key Management6�   �� 5       .��6   Select a scenario:6(   �� 5!      -   5        	 ��Name$	 _scenarioListBox��5!      $��Disabled=�60   $��0q�6f   $��10, 5, 5, 5q�6z   ��5"      �� 5#      # � ��6&   ��5%      �� 5&      .R�5'      �� $
��Wrap=�6$   $��
0, 5, 0, 5q�68   ��6L   �� 
 �� 	Converter#
 [  5(      5*      5+       � 5,   
   -   5          �Name$ _scenarioFrame��5,      $��1��6(   $��1��65     � NavigationUIVisibility$ Hidden=�6E   $
��Bold"�6e   $��18.667(�6w   $��
0, 5, 0, 5q�6�   6�   �� 5-   
   -   5         ��Name$ _logTextBox��5-      $��2��6'   $��1��64   $��5q�6D   " �� VerticalScrollBarVisibility$
 Auto=�6P    �� TextWrapping$
 Wrap=�6s   .��6�   ��5.      �� 5/      # � ��6"   .��50   "   Status text goes here69   �� 51   
   $ 
Horizontal=�6   $��3��6.   $��0��6;   $��2��6K   #��� ��6_   .+�52      �� $��Center=�6   $
��Left=�63   $
��Wrap=�6N   $��5q�6b   ��Microsoft will receive the images you upload and may use them to improve Face API and related services. By submitting an image, you confirm you have consent from everyone in it.6   53      54      55      