   M S B A M L   `   `   `  ����F  BHomeWork_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HomeWork_11.FormsHomeWork_11.Forms  5   	   %    HomeWork_11.Forms.WindowConsult   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HomeWork_11.Forms     5   	   -   5          � Title$  WindowConsult��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dglistbankconsult��5
      $��Stretch=�6.   $��Stretch=�6J   $��	0,200,0,0q�6h      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        dgtcsurname��,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��5   [      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ��  �� Path$ SurName�6l     5      -   5        dgtcname��$ Имя��5   U   $ * 6b    67   �� $
 Name�6b     5      -   5        dgtclastname��$ Отчество��5   ]   $ * 6o    6;   �� $ LastName�6o     5      $! Номер телефона��6E   $ * 6]    6%   �� $ Number�6]     5      -   5        dgtcpassport��$ Паспорт��5   ]   $ * 6n    6;   �� $ Passport�6n   5      �� 5   
   -   5         ��Name$ 	tbsurname��5   V   
�������$
��Left=�6   $��23��6�   $��8,13,0,0q�6�   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��269��6�   ��6   �� *SelectedItem.SurName+
 �� ElementName$
 dglistbankconsult��6�   �� 5   
   -   5        $ tbname��5      
�������$
��Left=�68   $��23��6S   $��8,44,0,0q�6_   $
	 Wrap=�6q   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Name+$
 dglistbankconsult��6�   �� 5   
   -	   5        $ 
tblastname��5      
�������$
��Left=�6<   $��23��6W   $��8,75,0,0q�6c   $
	 Wrap=�6u   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.LastName+$
 dglistbankconsult��6�   �� 5   
   -
   5        $ tbnumber��5      
�������$
��Left=�6:   $��23��6U   $��	8,107,0,0q�6a   $
	 Wrap=�6t   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Number+$
 dglistbankconsult��6�   �� 5   
   -   5        $ 	tbpasport��5      
�������$
��Left=�6;   $��23��6V   $��	8,140,0,0q�6b   $
	 Wrap=�6u   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Passport+$
 dglistbankconsult��6�   �� 5   
   -   5         ��Name$ btsave��5      $��Сохранить��6!   $
��Left=�65   $��
302,13,0,0q�6P   $	��Top=�6d   $	��113��6|   $��37��6�   6�   5      5      