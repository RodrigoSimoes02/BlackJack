   M S B A M L   `   `   `  ����D  @BlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlackJack	BlackJack  5   	       BlackJack.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BlackJack     5   	     � Title$  	BlackJack��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y   .��5	      � $��0,1,0,-1q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ Button_SplitDeck��5      $��Split��6+   $
��Left=�6;   $	��Top=�6V   $��75��6n   $��366,200,0,0q�6y    J� RenderTransformOrigin$ 
0.52,-1.25&�6�   �� 5   
   -   5        $ Button_Stop��5      $
��Stop��6&   $
��Left=�65   $	��Top=�6P   $��75��6h   $��464,200,0,0q�6s   6�   �� 5   
   -   5        $ Button_AddCard��5      $	��Add��6)   $
��Left=�67   $	��Top=�6R   $��75��6j   $��271,200,0,0q�6u   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ Button_Reset��5      $��Reset��6'   $
��Left=�67   $��20��6R   $��
93,231,0,0q�6^   $	��Top=�6r   $��51��6�   6�   �� 5   
   -   5         ��Name$ Label_Points��5      $��Points��6&   $
��Left=�67   $	��Top=�6R   $��381,161,0,0q�6j   $ 0.214,-5.731&�6   �� 5   
   -   5        $ Label_HousePoints��5      $��HousePoints��6+   $
��Left=�6A   $	��Top=�6\   $��
385,12,0,0q�6t   �� 5   
   -   5        $ Label_HouseCard1��5      $��
CardHouse1��6*   $
��Left=�6?   $	��Top=�6Z   $��
152,38,0,0q�6r   �� 5   
   -   5        $ Label_HouseCard2��5      $��
CardHouse2��6*   $
��Left=�6?   $	��Top=�6Z   $��
265,38,0,0q�6r   �� 5   
   -	   5        $ Label_HouseCard3��5      $��
CardHouse3��6*   $
��Left=�6?   $	��Top=�6Z   $��
381,38,0,0q�6r   �� 5   
   -
   5        $ Label_HouseCard4��5      $��
CardHouse4��6*   $
��Left=�6?   $	��Top=�6Z   $��
499,38,0,0q�6r   �� 5   
   -   5        $ Label_HouseCard5��5      $��
CardHouse5��6*   $
��Left=�6?   $	��Top=�6Z   $��
614,38,0,0q�6r   �� 5   
   -   5        $ Label_Busted��5      $��BUSTED��6&   $
��Left=�67   $	��Top=�6R   $��
35,161,0,0q�6j   $��45(�6~   �� 5   
   -   5         ��Name$ Image_Card1��5      $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��170,241,0,0q�6q   �� 5   
   -   5        $ Image_Card2��5      $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��256,241,0,0q�6q   �� 5   
   -   5        $ Image_Card3��5      $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��339,241,0,0q�6q   �� 5    
   -   5        $ Image_Card4��5       $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��419,241,0,0q�6q   �� 5!   
   -   5        $ Image_Card5��5!      $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��499,241,0,0q�6q   �� 5"   
   -   5        $ Image_Card6��5"      $
��Left=�6%   $	��160��6@   $	��Top=�6M   $	��120��6e   $��584,241,-9,0q�6q   �� 5#   
   -   5        $ BackgroundOfGame��5#      $
��Left=�6*   $	��421��6E   $	��Top=�6R   $	��794��6j   $��
0,0,-100,0q�6v   $��UniformToFill=�6�   $��bin/Background.png��6�   5$      5%      