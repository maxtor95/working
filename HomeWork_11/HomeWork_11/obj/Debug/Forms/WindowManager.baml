   M S B A M L   `   `   `  ����F  BHomeWork_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HomeWork_11.FormsHomeWork_11.Forms  5   	   %    HomeWork_11.Forms.WindowManager   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HomeWork_11.Forms     5   	   -   5          � Title$  WindowManager��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dglistbankmanager��5
      $��Stretch=�6.   $��Stretch=�6J   $��	0,200,0,0q�6h      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Департамент��6\      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *SelectedItem+ �� ElementName$ 	cbdeparts��6q     5      $ Фамилия��6F   $ * 6W    6%   ��  �� Path$ SurName�6W     5      $ Имя��6C   $ * 6P    6%   �� $
 Name�6P     5      $ Отчество��6G   $ * 6Y    6%   �� $ LastName�6Y     5      $! Номер телефона��6E   $ * 6]    6%   �� $ Number�6]     5      $ Паспорт��6G   $ * 6X    6%   �� $ Passport�6X   5      �� 5   
   -   5        	 ��Name$	 	tbsurname��5      
�������$
��Left=�6;   $��23��6V   $��8,13,0,0q�6b   
 �� TextWrapping$

 Wrap=�6t   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.SurName+$ dglistbankmanager��6�   �� 5   
   -   5        $	 tbname��5      
�������$
��Left=�68   $��23��6S   $��8,44,0,0q�6_   $

 Wrap=�6q   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Name+$ dglistbankmanager��6�   �� 5   
   -   5        $	 
tblastname��5      
�������$
��Left=�6<   $��23��6W   $��8,75,0,0q�6c   $

 Wrap=�6u   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.LastName+$ dglistbankmanager��6�   �� 5   
   -   5        $	 tbnumber��5      
�������$
��Left=�6:   $��23��6U   $��	8,107,0,0q�6a   $

 Wrap=�6t   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Number+$ dglistbankmanager��6�   �� 5   
   -   5        $	 	tbpasport��5      
�������$
��Left=�6;   $��23��6V   $��	8,140,0,0q�6b   $

 Wrap=�6u   $	��Top=�6�   $	��269��6�   ��6�   �� *SelectedItem.Passport+$ dglistbankmanager��6�   �� 5   
   -   5         ��Name$ btsave��5      $��Сохранить��6!   $
��Left=�65   $��302,104,0,0q�6P   $	��Top=�6e   $	��113��6}   $��37��6�   6�   �� 5   
   -	   5        $ btdell��5      $��Удалить��6!   $
��Left=�63   $��
301,57,0,0q�6N   $	��Top=�6b   $	��113��6z   $��37��6�   6�   �� 5   
   -
   5        $ btadd��5      $��Добавить��6    $
��Left=�63   $��
301,11,0,0q�6N   $	��Top=�6b   $	��113��6z   $��37��6�   6�   �� 5   
   -   5        $��	cbdeparts��5      $
��Left=�6$   $��
485,36,0,0q�6?   $	��Top=�6S   $	��257��6k   5      �� 5   
   $��Департамент��6   $
��Left=�6&   $��	569,7,0,0q�6A   $	��Top=�6T   5      5       