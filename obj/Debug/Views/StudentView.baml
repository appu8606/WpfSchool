   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      D @WpfSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfSchool.ViewsWpfSchool.Views 5      9!clr-namespace:WpfSchool.ViewModelWpfSchool.ViewModel 5      1clr-namespace:WpfSchool.ModelWpfSchool.Model 5	      !   WpfSchool.Views.StudentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7core&clr-namespace:System;assembly=mscorlib     5      /localclr-namespace:WpfSchool.Views     5      7	viewModel!clr-namespace:WpfSchool.ViewModel     5      /Modelclr-namespace:WpfSchool.Model     5	        � 	Resources  5       
  myEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� Type  WpfSchool.Model.Subject��%e   &	        S� 5   
   $ 	GetValues��6,   "  6C    5   
   M� 5      "  6   5      5       � DataContext 5      *  $WpfSchool.ViewModel.StudentViewModel  5   
   .��56      � .+�58   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG_myStudents��58         AutoGenerateColumns .  ��6*   �� *
Students+   Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   
   CanUserResize
 .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Name+6c      RowDetailsTemplate 5<      �� 5=      .R�5>        $ 
DG_myMarks��6   $��15,8,8,8q�6T   $	��399��6g    .  ��63   �� *	details+ 5?        5@      $	 Subcode��61   $
 Auto 6^    6B   �� *	Subcode+6^   4	  .System.Windows.Controls.DataGridComboBoxColumn	  5A      $	 Subject��65    	  SelectedItemBinding 6G   �� *	MySubject+ 	  ItemsSource 6q   ��  �� Source# [    5C      $	 
Total Mark��61   $
 Auto 6b    6E   �� *
TotMarks+6b   5E      5F      5H      5I      5J      