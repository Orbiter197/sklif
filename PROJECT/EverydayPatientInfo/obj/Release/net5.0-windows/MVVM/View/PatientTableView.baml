   M S B A M L   `   `   `  ���� N  JEverydayPatientInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:EverydayPatientInfo.MVVM.ViewEverydayPatientInfo.MVVM.View  4    .EverydayPatientInfo.MVVM.View.PatientTableView   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:EverydayPatientInfo.MVVM.View     .����  	  Light#��[  ._�]� .+�]� $
��Left=�$��False��.+��� $	��Top=�.+��� $��Add Patient��$��10q�  Blue#��[   FontSizeSmall#��[ ���� *AddPatientCommand+�� $��Modify Patient��$��10q�#��[ #��[ ���� *ModifyPatientCommand+�� $��Export to Excel��$��10q�#��[ #��[ ���� *ExportToExcelCommand+�� $��Stretch=�  BackgroundVeryLightBrush#��[ ._�&   System.Windows.Controls.DataGrid  $	��Top=�$��Stretch=�    CanUserReorderColumns$  False��   CanUserResizeColumns$ False��   CanUserResizeRows$ False��   
IsReadOnly$
 True��   SelectionUnit$ FullRow=�   SelectionMode$ Single=�   AutoGenerateColumns$ False������ *PatientList+ �� SelectedItem �� *SelectedPatient+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Chamber��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *	Chamber+  $	 	Last name��
 �� *
LastName+  $	 
First name��
 �� *	FirstName+  $	 
Patronymic��
 �� *
Patronymic+  $	 Sick Leave Number��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 
 �� *	SickLeave+   RowDetailsTemplate �� .R�]� $��Stretch=�.+�  $  False��$ False��$ False��$
 True��$ FullRow=�$ Single=�$ False������ *PatientDataList+   $
	 Date��
 �� *Date+  $	 Pressure evening��
 �� *PressureEvening+  $	 Pressure morning��
 �� *PressureMorning+  $	 Sugar evening��
 �� *SugarEvening+  $	 Sugar morning��
 �� *SugarMorning+  $	 Weight evening  ��
 �� *WeightEvening+  $	 Weight morning��
 �� *WeightMorning+  $	 Height��
 �� *Height+  $	 Notes Evening��
 �� *NotesEvening+  $	 Notes Morning��
 �� *NotesMorning+