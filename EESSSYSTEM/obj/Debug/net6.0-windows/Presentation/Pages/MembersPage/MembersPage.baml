   M S B A M L   `   `   `  ����E  AEESSSYSTEM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:EESSSYSTEM.Presentation.Pages.MembersPage)EESSSYSTEM.Presentation.Pages.MembersPage  5      ;    5EESSSYSTEM.Presentation.Pages.MembersPage.MembersPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Ilocal7clr-namespace:EESSSYSTEM.Presentation.Pages.MembersPage     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��UscMembersPage��5
        � DataContext  5      �� *MainViewModel+.��5      � 
�������.+�5   
   � .+�5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5        $��DialogoHost1��5   (      DialogContent 5      � 5      -   5         �Name$ grdDialogFormRegister��5      5      5      5      � 5   
   -   5        $ grdMain��5       � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $��* �6    6-   .+�5      � $��0��6   .+�5       ��  �� Orientation$ 
Horizontal=�6   $��	60 0 60 0q�66   $
��Left=�6I   .+�5!      o� 
�������$��Center=�6/   $��0q�6Q   $��0 0 10 0q�6u   ��6^   Z� .@�5"      m� -   5        $��menuItemRepuesto��5"   #   $��Montserrat Regular)�5#      
�������
���   � �� TextAlignment$
 Left=�5'      $��Filtrar��5(      $��50��60   $��10q�5)      $��13(�5*       m� Icon 5&      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Filter=�.@�5+      m� -   5        $��BtnAlphabet��5-   '   $��De la A a la Z��5+   '   
���   �5-   '   �� 5.      50      52      �� 53      -   5         ��Name$ BtnAddMember��53      $��	Añadir +��63   6c   54      56      � 57      $��1��6   $	��Top=�6!   .+�58      &   System.Windows.Controls.DataGrid  -   5        $��
DtgMembers��5:      	   AutoGenerateColumns$	 False��58      
�������
   SelectionMode$
 Single=�5;      $��15(�5<         
IsReadOnly$
 true��5=      $
��auto��5>      $��60q�5?         CanUserAddRows$ False��5@      $
��True��5A      ��5B      �� *MemberEntities+   Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ Id��5E   -      
Visibility$ 	Collapsed=�5G   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5F   -   ��  �� Path$ IdSpare�5G   -     5I      $ * 6-   $ Nombre Completo��5J   -    5K   -   �� $
 Name�  5M      $ * 6.   $ Fecha Nacimiento��5N   .    5O   .   �� $ DateBirthDay�  5Q      $ * 6-   $ Telefono��5R   -    5S   -   �� $ Phone�4  .System.Windows.Controls.DataGridTemplateColumn  5U      $ Eliminar��61   $
 auto 5V   1      CellTemplate 5W      �� 5X   "   .R�5Y   &   �� $��BtnDeletedMemberSelected��5]   -    &  "MaterialDesignToolForegroundButton#���   5Y   -   $��50��5Z   -   $��50��5[   -    K� ZIndex$ 0��5\   -   
���  ����5`   .   �� *" DataContext.DeletedMemberCommand+ �� ElementName$ UscMembersPage����5a   -   �� .��5c   *   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Delete=�6B   5d   '   5e   #   5g      5j      5k      5l      5m      5n      