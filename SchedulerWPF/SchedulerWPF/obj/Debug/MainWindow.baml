   M S B A M L   `   `   `  ????G  CWpfScheduler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfSchedulerWpfScheduler  5   	   ?$clr-namespace:WpfScheduler.ViewModelWpfScheduler.ViewModel  5   	       WpfScheduler.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ` \Syncfusion.Tools.Wpf, Version=20.3460.0.60, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.Wpf, Version=20.3460.0.60, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.SfSkinManager.WPF, Version=19.1451.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f bSyncfusion.SfScheduler.WPF, Version=19.1451.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1451.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89j
 fSyncfusion.SfBusyIndicator.WPF, Version=19.1451.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=20.3460.0.60, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89>
syncfusion!http://schemas.syncfusion.com/wpf     	 
  5   	   2localclr-namespace:WpfScheduler     	 
  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a?interactivity+http://schemas.microsoft.com/xaml/behaviors  5   	   4	viewModel$clr-namespace:WpfScheduler.ViewModel  5   	   -   5          ?Name$  MainWindow1??5   	    ? WindowStartupLocation$ CenterScreen=?5   	   $
??1280??6.   $	??720??6;    ? DataContext 5	      /   )WpfScheduler.ViewModel.OrderInfoViewModel  5
   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??133* ?6   ?? 5      $
??871* ?6   ?? 5      $
??276* ?6   .+?5   
   ?? -   5         ??Name$ MainWindowTabControl??5      $??3??63   .@?5      ?? $!??Личный Кабинет??6   .??5      ? ???	#FFE5E5E5.+?5      ?? -   5        $ MainMenuTabContorl??5   !    ?? TabStripPlacement$
 Left=?6=   .@?5      ?? $??TabItem??6"   .??5      ? -   5         ?Name$ 	Root_Grid??5   #   ???	#FFE5E5E5.+?5   "   (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ dataGrid??5   8      AddNewRowPosition$ Bottom=?6J   	   AddNewRowText$.	 (Добавить новую запись??6e   (  "Syncfusion.UI.Xaml.Grid.SfGridBase
   AutoGenerateColumns
 . $
??Left=?6?   $	??Top=?6?   $	??650??6?   $
??1192??6     ItemsSource 6?   ?? *Orders+6  5      5      ?? 5      $??TabItem??6"   .??5       ? ???	#FFE5E5E56#   5!      5"      5#      5$      ?? 5%      -   5        $??Календарь??5%      .??5&      ? ???	#FFE5E5E5 5'      ?? 5(      $	??43* ?6+   ?? 5)      $??1231* ?6+   .+?5+      .  (Syncfusion.UI.Xaml.Scheduler.SfScheduler  -   5          Name$ Schedule??5+   -      FirstDayOfWeek$ Monday=?5,   !      ViewType$
 Week=?5-   !   $??2??5.   W   $	??676??6k   $??Center=?6x      ItemsSource 6!   ?? *ScheduleAppointmentCollection+6x   5/      50      51      *  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 52   
   $   WpfScheduler.SchedulerBehavior  53      55      56      