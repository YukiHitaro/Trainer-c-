   M S B A M L   `   `   `  џџџџH  DTypingTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TypingTrainerTypingTrainer  5   	       TypingTrainer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TypingTrainer     5   	     § Title$  Typing Trainer§5   	   $	бџ450Єў6    $	Чџ800Єў6-    џ DataContext 5
      '  !TypingTrainer.MainWindowViewModel  5   
   .ђџ5      џ 
Њџшци­џ џ RowDefinitions 5   
   у§ 5      $Ђџ* џ6   у§ 5      $Ђџ* џ6   у§ 5      $Ђџ30 џ6   .+џ5   
   џ $Сџ0Хў6   $Яџ10q§5      
Њџшџџџ .+џ5      Іў $фџ16(џ5      $аџCenter=џ5      ђџ5      ьџ *CurrentChallenge+5   3   5      џ 5   
   $Сџ1Хў6   $Яџ10q§5      .+џ5      § $фџ14(џ5      џ5      ьџ *	UserInput+ ьџ UpdateSourceTrigger$ PropertyChanged=џ5      5       џ 5"   
   $Сџ2Хў6   
ЊџшPџџ.+џ5$      § $аџRight=џ6   .+џ5%      Іў $
сџBold"џ5&      $фџ12(џ5'      ђџ5%      ьџ *TotalCorrect+5'      Іў 5(      $ђџ/§6   $фџ12(џ5)      Іў 5*      $
сџBold"џ5+      $фџ12(џ5,      ђџ5*      ьџ *TotalAttempts+5,      5-      5.      50      51      