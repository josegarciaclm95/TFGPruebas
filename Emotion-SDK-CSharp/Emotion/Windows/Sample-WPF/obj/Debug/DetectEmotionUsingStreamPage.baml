   M S B A M L   `   `   `  ����Q  MEmotionAPI-WPF-Samples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmotionAPI_WPF_SamplesEmotionAPI_WPF_Samples  5      9    3EmotionAPI_WPF_Samples.DetectEmotionUsingStreamPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:EmotionAPI_WPF_Samples     5      $��Stretch=�5        N� Title$"  DetectEmotionUsingStreamPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��
5, 5, 0, 0q�6!   $
��Bold"�65   $"Detect emotion by an bitmap stream6k   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� $��
5, 5, 0, 0q�6   <:Please click [Load Image] to specify the images to detect.6h   �� 5      -   5        $��
5, 5, 0, 0q�5   3   $��80��6G   $
��Left=�6R   .��6m   
Load Image6y   5      �� 5   
   $��2��6   $
��Wrap=�6!   $��5q�65   nlThe top 3 emotions will be shown in the list box. For more details on other emotions, please see the status.6�   �� 5   
   -   5         ��Name$ _detectionStatus��5      $��3��6.   $��5q�6;   $
��Bold"�6F   6Z   8   2EmotionAPI_WPF_Samples.EmotionDetectionUserControl  5   
   -   5          Name$" _emotionDetectionUserControl��5   ,   $��4��6R   5      5      5      