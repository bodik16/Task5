   M S B A M L   `   `   `  ����@  <Task3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task5Task5  5   	       Task5.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task5     5   	   -   5        $��MainTaxiDriverWindow��5   T     � Title$  Водій Таксі��6   $��Verdana)�6   $��790.821��62   $��976.875��6C   .��5
      � -   5        $��MainGrid��5
      $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��213* �6   �� 5      $
��491* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��2��6   $��	0,0,172,0q�6#    J� RenderTransformOrigin$ 0.455,0.548&�66    5      �� 5      $��* �6     5      �� 5      $
��0.5* �6#   �� 5      $
��0.5* �6#   .+�5      �� -   5         ��Name$ groupBox��5      $��Verdana)�6*   $��Вхід водія��6?   $��0��6S   $��0��6`   $��0,0,5,10q�6p   .��5      �  5      �� 5      $
��0.5* �6+   �� 5      $
��0.5* �6+    5!      �� 5"      $
��Auto �6(   �� 5#      $
��Auto �6(   �� 5$      $
��Auto �6(   .+�5&      �� -   5         ��Name$ driverUsernameLabel��5&      $��Verdana)�69   $#��Прізвище водія: ��6N   $��0��6i   $��0��6v   �� 5'      -   5         ��Name$ driverSurName��5'      $��Verdana)�65    �� TextWrapping$
 Wrap=�6J   $��23��6^   $��Mykytyn��6j   $��0��6y   $��1��6�   �� 5(      -   5        $ driverUserNameLabel��5(      $��Verdana)�69   $��Імя водія: ��6N   $��1��6d   $��0��6q   �� 5)      -   5        $ driverUserName��5)      $��Verdana)�66   $
 Wrap=�6K   $��23��6_   $��Anatolii��6k   $��1��6{   $��1��6�   �� 5*      -   5         ��Name$ 	endOfWork��5*      $��Verdana)�60   $#��Завершити зміну��6E   $��2��6_   $��0��6l   $��5q�6|   6�   �� 5+      -	   5        $ 	startWork��5+      $��Verdana)�60   $��Почати зміну��6E   $��2��6\   $��1��6i   $��5q�6y   6�   5,      5-      �� 5.      -
   5        $ 	groupBox1��5.      $��Verdana)�6*   $+��%Інформаційна панель��6?   $��0��6\   $��0,120,5.333,-110q�6i   .��5/      �  50      �� 51      $
��Auto �6+   �� 52      $
��Auto �6+   �� 53      $
��Auto �6+   �� 54      $
��Auto �6+    56      �� 57      $
��Auto �6(   �� 58      $
��Auto �6(   �� 59      $
��Auto �6(   .+�5;      �� -   5        $ driverInfoSurnameName��5;      $��Verdana)�6;   $��Водій: ��6P   $��0��6b   $��0��6o   �� 5<      -   5        $" driverInfoSurnameNameDetails��5<      $��Verdana)�6B   $-��'(інформація відсутня)��6W   $��0��6w   $��1��6�   �� 5=      -   5        $ driverInfoAge��5=      $��Verdana)�63   $��Вік: ��6H   $��0��6X   $��2��6e   �� 5>      -   5        $ driverInfoAgeDetails��5>      $��Verdana)�6:   $
��(--)��6O   $��0��6^   $��3��6k   �� 5?      -   5        $ driverInfoCar��5?      $��Verdana)�64   $��
Авто: ��6I   $��1��6Z   $��0��6g   �� 5@      -   5        $ driverInfoCarDetails��5@      $��Verdana)�6:   $��(номер)��6O   $��1��6a   $��1��6n   �� 5A      -   5        $ driverInfoExp��5A      $��Verdana)�63   $��
Стаж: ��6H   $��1��6Y   $��2��6f   �� 5B      -   5        $ driverInfoExpDetails��5B      $��Verdana)�6:   $��(--) років��6O   $��1��6d   $��3��6q   �� 5C      -   5        $ driverInfoCost��5C      $��Verdana)�64   $��Виручка: ��6I   $��2��6]   $��0��6j   $
��Bold"�6{   �� 5D      -   5        $ driverInfoCostDetails��5D      $��Verdana)�6;   $��0 грн��6P   $��2��6`   $��1��6m   $
��Bold"�6~   �� 5E      -   5        $ driverInfoCostPerMin��5E      $��Verdana)�6:   $��грн/хв: ��6O   $��2��6b   $��2��6o   �� 5F      -   5        $! driverInfoCostPerMinDetails��5F      $��Verdana)�6A   $��0��6V   $��2��6b   $��3��6o   5G      5H      5I      �� 5J   
   -   5        $ 	groupBox2��5J      $��Замовлення��6'   $��1��6;   $��0��6H   $��0,135,0,10.333q�6X   $��2��6p   .��5K      �  5L      �� 5M      $
��293* �6'   �� 5N      $
��645* �6'   .+�5P      � $��2��6    5Q      �� 5R      $	��18* �6+   69   �� 5S      $
��122* �6+   �� 5T      $
��141* �6+   6:   �� 5U      $
��187* �6+   6:   �� 5V      $
��188* �6+   6:   �� 5W      $
��141* �6+   6:   �� 5X      $��140.667 �6+   6=   .+�5Z      �� -   5        $��dummywidth1��5Z   -   $��0��6   $��3��6@   $��0,0,140.333,-0.333q�6T   6r   �� 5[      -   5        $��dummywidth2��5[   -   $��2��6   $��0.334,0,0.333,-0.333q�6@   6`   �� 5\      -   5        $��dummywidth3��5\   -   $��2��6   $��3��6@   $��140.334,0,187.666,-0.333q�6T   6x   �� 5]      -   5        $��dummywidth4��5]   -   $��4��6   $��2��6@   $��0.334,0,140.333,-0.333q�6T   6v   �� 5^      -   5        $��dummywidth5��5^   -   $��5��6   $��2��6@   $��140.334,0,-0.001,-0.333q�6T   6w   �� 5_      -   5        $��dummywidth6��5_   -   $��5��6   $��2��6@   $��140.334,0,-0.001,-0.333q�6T   6w   5`      �� 5a      -   5        	 ��Name$	 orders��5a      $��Verdana)�6,   $
��Left=�6A   $	��928��6�   $��2��6�   $��0,10,0,0q�6�   
 �� View
 5b      �� 5c      .P�5d      �� $��Ім'я клієнта��6-    �� Width 6C   ��  �� ElementName$ dummywidth1�� �� Path$ ActualWidth� �� DisplayMemberBinding 6   �� *Client.Name+�� 5e      $��Моб. тел.��6-    6@   �� $ dummywidth2��$ ActualWidth� 6|   �� *Client.PhoneNumber+�� 5f      $)��#Пункт відправлення��6-    6I   �� $ dummywidth3��$ ActualWidth� 6�   �� *
Dispatch+�� 5g      $'��!Пункт призначення��6-    6H   �� $ dummywidth4��$ ActualWidth� 6�   �� *Destination+�� 5h      $%��Час відправлення��6-    6G   �� $ dummywidth5��$ ActualWidth� 6�   �� *
ArriveTime+�� 5i      $��Виконано��6-    6?   �� $ dummywidth6��$ ActualWidth� 6{   �� *IsDone+5j      5l      5m      5n      �� 5o   
   $��WELCOME TO OUR TAXI��6   
������$��37(�6D   $��1��6R   $
��Left=�6b   $��157.667,83,0,0q�6}   $	��Top=�6�   $��82��6�   $	��464��6�   $��2��6�   5p      5r      