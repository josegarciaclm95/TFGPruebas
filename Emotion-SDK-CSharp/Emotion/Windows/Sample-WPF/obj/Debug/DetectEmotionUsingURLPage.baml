   M S B A M L   `   `   `  ����Q  MEmotionAPI-WPF-Samples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmotionAPI_WPF_SamplesEmotionAPI_WPF_Samples  5      6    0EmotionAPI_WPF_Samples.DetectEmotionUsingURLPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:EmotionAPI_WPF_Samples     5        N� Title$  DetectEmotionUsingURLPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��
5, 5, 0, 0q�6!   $
��Bold"�65   )'Detect emotion by a specified image URL6p   �� 5   
   $��1��6   $��
5, 5, 0, 0q�6"   CAPlease type or paste an URL to an image below, and click [Detect]6y   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6#   $��
5, 5, 0, 0q�6=   .+�5      �� -   5         ��Name$ 
URLTextBox��5      $	��300��6*   $��
0, 5, 0, 0q�66   .��6J   FDhttps://oxfordportal.blob.core.windows.net/face/demo/detection 4.jpg6�   �� 5      -   5        $��
5, 5, 0, 0q�5   3   .��6G   Detect6O   5      �� 5   
   $��3��6   $
��Wrap=�6!   $��5q�65   nlThe top 3 emotions will be shown in the list box. For more details on other emotions, please see the status.6�   �� 5   
   -   5         ��Name$ _detectionStatus��5      $��4��6.   $��5q�6;   $
��Bold"�6F   6Z   8   2EmotionAPI_WPF_Samples.EmotionDetectionUserControl  5   
   -   5          Name$" _emotionDetectionUserControl��5   ,   $��5��6R   5      5!      5"      