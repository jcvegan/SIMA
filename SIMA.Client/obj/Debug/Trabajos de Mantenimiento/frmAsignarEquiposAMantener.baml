   M S B A M L   `   `   `  ����  SIMA.ClientF    @SIMA.Client.Trabajos_de_Mantenimiento.frmAsignarEquiposAMantener   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      o kTelerik.Windows.Controls.RibbonBar, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j	 fTelerik.Windows.Controls.Data, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w
 sTelerik.Windows.Controls.DataVisualization, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Gauge, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.Scheduler, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2010.2.714.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation      	 
      5      -   5        .��5      �   � RowDefinitions  5   
   �� 5	      $��24 �6   �� 5
      $��30 �6   $��30��6(   �� 5      $��30 �6   $��30��6(   �� 5      $��30 �6   $��30��6(   �� 5      $��30 �6   $��30��6(   �� 5      $��30 �6   $��30��6(   �� 5      $��30 �6   $��30��6(   �� 5       � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��0��6   $��3��6   $��1q�62   $��0q�6F   $	��Top=�6Q   $��24��6i    �� CornerRadius$ 2,2,0,0��6u   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF5B5B5B��6#    � Offset$ 1Q�65   � 5      $ 	#FF868686��6#   $	 0.1Q�65   � 5      $ 	#FF4F4F4F��6#   $
 0.57Q�65   � 5      $ 	#FF0E0E0E��6#   $
 0.11Q�65   5      ��5       �� 5!      $ 1,0.5&�6&   $ 0,0.5&�67   .��5"      � $ 0Q�6#   � 5#      $ 1Q�6#   � 5$      $ White��6#   $	 0.5Q�61   5%      ._�5'      �� $'��!Asignación de equipos a mantener��6   
�������$��Right=�6X   $��Center=�6t   $��15,0,0,0q�6�   $��16(�6�   5(      �� 5)   
   $��Equipo��6   $��0��6"   $��1��62   $
��Left=�6?   $��Center=�6Z   $��25,0,0,0q�6u   �� 5*   
   $��Tipo mantenimiento��6   $��0��6.   $��2��6>   $
��Left=�6K   $��Center=�6f   $��25,0,0,0q�6�   �� 5+   
   $��Fecha de trabajo��6   $��0��6,   $��3��6<   $
��Left=�6I   $��Center=�6d   $��25,0,0,0q�6   �� 5,   
   $��Hora de inicio��6   $��0��6*   $��4��6:   $
��Left=�6G   $��Center=�6b   $��25,0,0,0q�6}   �� 5-   
   $��Hora de fin��6   $��0��6'   $��5��67   $
��Left=�6D   $��Center=�6_   $��25,0,0,0q�6z   *  $Telerik.Windows.Controls.RadComboBox  5.   
   -   5        $��
cmbEquipos��5.      $��1��60   $��1��6@   $
��Left=�6M   $��Center=�6h   $��25,0,0,0q�6�   $	��170��6�   +  %Telerik.Windows.Controls.StyleManager   Theme-  'Telerik.Windows.Controls.ThemeConverter$ Summer 6�    �� SelectedValuePath$ 	Id_Equipo��6�   	 �� DisplayMemberPath$	 Descripcion��6�   6    5/   
   -   5        $��cmbTipoMantenimientos��5/      $��1��6;   $��2��6K   $
��Left=�6X   $��Center=�6s   $��25,0,0,0q�6�   $	��170��6�   $ Summer 6�   $ 	Id_Equipo��6�   $	 Descripcion��6�   ,  &Telerik.Windows.Controls.RadDatePicker  50   
   -   5        $��dpFechaInicio��50       $��1��65   $��3��6E   $
��Left=�6R   $��Center=�6m   $��25,0,0,0q�6�   $	��170��6�   $ Summer 6�   ,  &Telerik.Windows.Controls.RadTimePicker  51   
   -   5        $��tpHoraInicio��51       $��1��64   $��4��6D   $
��Left=�6Q   $��Center=�6l   $��25,0,0,0q�6�   $	��170��6�   $ Summer 6�     52   
   -   5        $��	tpHoraFin��52       $��1��61   $��5��6A   $
��Left=�6N   $��Center=�6i   $��25,0,0,0q�6�   $	��170��6�   $ Summer 6�   (  "Telerik.Windows.Controls.RadButton  53   
   -   5        $��
btnAgregar��53      $��Agregar��6.   $��1��6@   $��6��6P   $��25,0,0,0q�6]   $
��Left=�6o   $��Center=�6�   $	��100��6�   $ Summer 6�   *  $Telerik.Windows.Controls.RadGridView  55   
   -   5        $��gvMantenimientosAsignados��55      $��7��6?   $��2��6L   $ Summer 6`   ;  5Telerik.Windows.Controls.GridView.GridViewDataControl
   ShowGroupPanel
 .     GridLinesVisibility$ 
Horizontal=�6�      ShowColumnFooters .     ShowInsertRow .     AutoGenerateColumns .  57      +	  %Telerik.Windows.Controls.RadScheduler	  58   
   -	   5        $��
schHorario��58      $ Summer 61   $��2��6U   $��1��6e   $��7��6r    	  ViewMode$
 Week=�6�    	  
IsReadOnly . 5:      5;      5<      