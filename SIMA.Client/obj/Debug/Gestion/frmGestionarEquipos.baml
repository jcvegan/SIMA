   M S B A M L   `   `   `  ����  SIMA.Client-    'SIMA.Client.Gestion.frmGestionarEquipos   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      o kTelerik.Windows.Controls.RibbonBar, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j	 fTelerik.Windows.Controls.Data, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w
 sTelerik.Windows.Controls.DataVisualization, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Gauge, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.Scheduler, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation      	 
      5      -   5        .��5      /  )Telerik.Windows.Controls.RadBusyIndicator  -   5        $��biIndicador��5      .��5   
   �   � RowDefinitions  5	      �� 5
      �� 5      .+�5      � $��0��6     5      �� 5      $��24 �6$   �� 5      �� 5      $��24 �6$   .+�5      �� $��0��6   $��1q�6&   $��0q�6:   $	��Top=�6E   $��24��6]    �� CornerRadius$ 2,2,0,0��6i   ��5      �� 5       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5      �  � Color$ 	#FF5B5B5B��6+    � Offset$ 1Q�6=   � 5      $ 	#FF868686��6+   $	 0.1Q�6=   � 5      $ 	#FF4F4F4F��6+   $
 0.57Q�6=   � 5      $ 	#FF0E0E0E��6+   $
 0.11Q�6=   5      ��5      �� 5      $ 1,0.5&�6.   $ 0,0.5&�6?   .��5      � $ 0Q�6+   � 5       $ 1Q�6+   � 5!      $ White��6+   $	 0.5Q�69   5"      ._�5$      �� $��Gestión de Equipos��6    
�������$��Right=�6R   $��Center=�6n   $��15,0,0,0q�6�   $��16(�6�   5%      � 5&      $��1��6     5'      �� 5(      $��30 �6(   �� 5)      $��30 �6(   �� 5*      $��30 �6(   �� 5+      $��30 �6(   �� 5,      $��30 �6(   �� 5-      $��30 �6(   �� 5.      $��30 �6(   �� 5/      $��30 �6(   �� 50      $��30 �6(    � ColumnDefinitions 52      �� 53      $	��170 �6+   �� 54      �� 55      $	��170 �6+   �� 56      .+�58      �� $��0��6   $��0��6,   $��	ID Equipo��69   $
��Left=�6M   $��Center=�6h   $��25,0,0,0q�6�   �� 59      $��0��6   $��1��6,   $��Área��69   $
��Left=�6H   $��Center=�6c   $��25,0,0,0q�6~   �� 5:      $��0��6   $��2��6,   $��Descripción��69   $
��Left=�6O   $��Center=�6j   $��25,0,0,0q�6�   �� 5;      $��0��6   $��3��6,   $��Marca��69   $
��Left=�6I   $��Center=�6d   $��25,0,0,0q�6   �� 5<      -   5        $��	lblModelo��5<      $��0��6.   $��4��6>   $��Modelo��6K   $
��Left=�6\   $��Center=�6w   $��25,0,0,0q�6�   $y�Hidden=�6�   �� 5=      $��25,0,0,0q�6   $��5��6.   .��6;   Serie6B   �� 5>      $��0��6   $��6��6,   $��Costo��69   $
��Left=�6I   $��Center=�6d   $��25,0,0,0q�6   �� 5?      $��7��6   $��Cantidad disponible��6)   $��25,0,0,0q�6G   �� 5@      $��2��6   $��0��6,   $��Pertenece a��69   $
��Left=�6O   $��Center=�6j   $��25,0,0,0q�6�   �� 5A      $��2��6   $��1��6,   $��Fecha adquisición��69   $
��Left=�6U   $��Center=�6p   $��25,0,0,0q�6�   �� 5B      $��2��6   $��2��6,   $��Horas permitidas��69   $
��Left=�6T   $��Center=�6o   $��25,0,0,0q�6�   �� 5C      $��2��6   $��3��6,   $��Es de uso único��69   $
��Left=�6S   $��Center=�6n   $��25,0,0,0q�6�   �� 5D      $��2��6   $��4��6,   $��Capacidad de Operación��69   $
��Left=�6Z   $��Center=�6u   $��25,0,0,0q�6�   �� 5E      $��2��6   $��5��6,   $��Diametro interno��69   $
��Left=�6T   $��Center=�6o   $��25,0,0,0q�6�   �� 5F      $��2��6   $��6��6,   $��Revestimiento Interior��69   $
��Left=�6Z   $��Center=�6u   $��25,0,0,0q�6�   �� 5G      -   5        $��	lblEstado��5G      $��2��6-   $��8��6=   $��Estado��6J   $
��Left=�6[   $��Center=�6v   $��25,0,0,0q�6�   �� 5H      $��2��6   $��7��6,   $��Tipos de Mantenimiento��69   $
��Left=�6Z   $��Center=�6u   $��25,0,0,0q�6�   2  ,Telerik.Windows.Controls.RadWatermarkTextBox  5I      -   5        $��txtCodigoEquipo��5I   2   $��1��6I   $��0��6Y   $	��150��6f   $
��Left=�6r   $��Center=�6�   $��25,0,0,0q�6�   {�.     WatermarkContent$ (AutoAsignado)��6�   *  $Telerik.Windows.Controls.RadComboBox  5J      -   5        $��cmbAreaEquipo��5J   *   $��1��6?   $��1��6O   $	��150��6\   $
��Left=�6h   $��	22,5,63,3q�6�   $��22��6�   +  %Telerik.Windows.Controls.StyleManager   Theme-  'Telerik.Windows.Controls.ThemeConverter$ Summer 6�   	 �� SelectedValuePath$	 Id_Area��6�   
 �� DisplayMemberPath$
 Nombre��6�   �� 5K      -   5        $��txtDescripcion��5K      $��1��64   $��2��6D   $	��150��6Q   $
��Left=�6]   $��Center=�6x   $��25,0,0,0q�6�     5L      -   5        $��cmbMarcaEquipo��5L   *   $��1��6@   $��3��6P   $	��150��6]   $
��Left=�6i   $��	22,5,63,3q�6�   $��22��6�   $	 Id_Marca��6�   $
 Nombre��6�   $ Summer 6�   6�     5M      -	   5        $��cmbModeloEquipo��5M   *   $��1��6A   $��4��6Q   $	��150��6^   $
��Left=�6j   $��	22,5,63,3q�6�   $��22��6�   $ Summer 6�   $y�Hidden=�6�   $	 	Id_Modelo��6  $
 Descripcion��6.  �� 5N      -
   5        $��txtSerie��5N      $��1��6.   $��5��6>   $	��150��6K   $
��Left=�6W   $��Center=�6r   $��25,0,0,0q�6�   /  )Telerik.Windows.Controls.RadNumericUpDown  5O      -   5        $��udCostoUnidad��5O   /   $��1��6D   $��6��6T   $	��150��6a   $
��Left=�6m   $��Center=�6�   $��25,0,0,0q�6�   +  %Telerik.Windows.Controls.RadRangeBase   Minimum$ 0Q�6�   $ Summer 6�   �� 5P      -   5        $��txtCantidad��5P      $��1��61   $��7��6A   $	��150��6N   $
��Left=�6Z   $��Center=�6u   $��25,0,0,0q�6�   �� 5Q      -   5        $��stkPerteneceA��5Q   !   $��3��66   $��0��6F   $��Stretch=�6S   $��Stretch=�6q    �� Orientation$ 
Horizontal=�6�   $��25,0,0,0q�6�   .+�5R      �� -   5        $��DescripcionEquipo��5R   $   $	��150��6=   $��(No tiene pertenencia)��6I   $
��Left=�6g   $��Center=�6�   (  "Telerik.Windows.Controls.RadButton  5S      -   5        $��btnSelEquipoPadre��5S   ,   $��Asignar��6E   $��Center=�6W   $ Summer 6r   6�   5T      -	  'Telerik.Windows.Controls.DateTimePicker	  5U      -   5        $��dtFAdquisicion��5U   -   $��3��6C   $��1��6S   $	��210��6`   $
��Left=�6l   $��Center=�6�   $��25,0,0,0q�6�   $ Summer 6�   $��22��6�     5V      -   5        $��
udMaxHoras��5V   /   $��3��6A   $��2��6Q   $	��120��6^   $
��Left=�6j   $��Center=�6�   $��25,0,6,0q�6�   $ Summer 6�   $��22��6�   $ 0Q�6�      Maximum$ 23Q�6�   �� 5W      -   5        $��chkEsUsoUnico��5W      $��3��64   $��3��6D   $��Si��6Q   $
��Left=�6^   $��Center=�6y   $��25,0,0,0q�6�   �� 5X      -   5        $��
txtCapOper��5X      $��3��60   $��4��6@   $	��120��6M   $
��Left=�6Y   $��Center=�6t   $��25,0,5,0q�6�   �� 5Y      -   5        $��txtDiamtero��5Y      $��3��61   $��5��6A   $	��120��6N   $
��Left=�6Z   $��Center=�6u   $��25,0,5,0q�6�   �� 5Z      -   5        $��txtRevestimiento��5Z      $��3��66   $��6��6F   $	��120��6S   $
��Left=�6_   $��Center=�6z   $��25,0,5,0q�6�   �� 5[      -   5        $��stkTiposMantenimiento��5[   !   $��3��6>   $��7��6N   $��Stretch=�6[   $��Stretch=�6y   $ 
Horizontal=�6�   $��25,0,0,0q�6�   .+�5\      �� -   5        $��TipodMantenimiento��5\   $   $	��150��6>   $#��(No tiene tipo mantenimiento)��6J   $
��Left=�6o   $��Center=�6�     5]      -   5        $��btnSelTipoMantenimiento��5]   ,   $��Asignar��6K   $��Center=�6]   $ Summer 6x   6�   5^        5_      -   5        $��	cmbEstado��5_   *   $��3��6;   $��8��6K   $	��150��6X   $
��Left=�6d   $��25,0,0,0q�6   $��22��6�   $ Summer 6�   5`      �� 5a      $��2��6   $��Stretch=�6*   $��Stretch=�6H   $ 
Horizontal=�6d   .+�5b        -   5        $��btnRegistrar��5b   (   $��	Registrar��6<   $	��100��6P   $ Summer 6w     5c      -   5        $��btnActualizar��5c   (   $��
Actualizar��6=   $	��100��6R   $ Summer 6z     5d      -   5        $��btnEliminar��5d   (   $��Eliminar��6;   $	��100��6N   $ Summer 6t     5e      -   5        $��
btnLimpiar��5e   (   $��Limpiar��6:   $	��100��6L   $ Summer 6q   5g      5h      *
  $Telerik.Windows.Controls.RadGridView
  5i      -   5        $��gvEquipo��5i   "   $��1��62   $ Summer 6?   ;  5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .     
IsReadOnly .    Columns 5j      1  +Telerik.Windows.Controls.GridViewDataColumn  5k      6  0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$ 	ID Equipo��61      DataMemberBinding 6D   �� *	Id_Equipo+  5l      $ Descripcion��61    6F   �� *Descripcion+  5m      $ Costo��61      DataFormatString$ {0:c}��6d    6@   �� *Costo+6d     5n      $ 
Inventario��61    6E   �� *Stock+5p      5r      5s      5t      