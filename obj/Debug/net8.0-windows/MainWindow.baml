   M S B A M L   `   `   `  ����T  PDesignerClientApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DesignerClientApplicationDesignerClientApplication  5   	   *    $DesignerClientApplication.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:DesignerClientApplication     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��650��6)   .��5	      � -   5         �Name$ grdMainForm��5	      ���	#FFF5EFE6$
��Auto��67   .+�5
   
   �� -   5         ��Name$ 
lstClients��5
      $��40,0,0,0q�5      
���   ����	#FFE8DFCA$��Cascadia Code)�5      $��0,0,0,0q�6-   $	��325��6v   $��Center=�6�   $
��Left=�6�   $	��163��6�   �� 5   
   -   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
40,374,0,0q�6J   $	��Top=�6^   $��32��6v   $��49��6�   $��Cascadia Code SemiBold)�6�   ���	#FF1A4D2E$��0,0,0,0q�6�   ���	#FFE8DFCA6�   �� 5   
   -   5         ��Name$ 
lblClients��5      $��Clients��6$   $
��Left=�66   $��	91,10,0,0q�6Q   $	��Top=�6d   $��16(�6|   $
��Bold"�6�    J� RenderTransformOrigin$ 1.059,0.585&�6�   �� 5   
   -   5         ��Name$ imgFloorPlan��5      $
��Left=�6&   $	��202��6A   $��325,163,0,0q�6N   $	��Top=�6c   $	��300��6{   �� 5   
   -   5        $ btnGeneratePDF��5      $��
Create PDF��6)   $
��Left=�6>   $��423,374,0,0q�6Y   $	��Top=�6n   $��32��6�   $��94��6�   ���	#FF1A4D2E���	#FFE8DFCA$
��Bold"�6�    � ToolTip$% Click to create and print a PDF��6�   �� 5   
   -   5        $ lblAddressOutput��5      $��Address��6*   $
��Left=�6<   $��
253,55,0,0q�6W   $	��Top=�6k   $
��Bold"�6�   �� 5   
   -   5        $ lblOutputEmail��5      $��Email��6(   $
��Left=�68   $��253,114,0,0q�6S   $	��Top=�6h   $
��Bold"�6�   �� 5   
   -	   5        $ lblOutputPhone��5      $��Phone��6(   $
��Left=�68   $��
253,90,0,0q�6S   $	��Top=�6g   $
��Bold"�6   �� 5   
   -
   5        $ lblOutputImage��5      $��
Floor Plan��6(   $
��Left=�6=   $��253,150,0,0q�6X   $	��Top=�6m   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtAddressOutput��5      $
��Left=�6,   $��
324,62,0,0q�6G   	 �� TextWrapping$
	 Wrap=�6[   $��TextBox��6o   $	��Top=�6~   $	��292��6�   $��18��6�   ��6�   Z� �� 5   
   -   5        $ txtPhoneOutput��5      $
��Left=�6*   $��
324,94,0,0q�6E   $
	 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��292��6�   ��6�   Z� �� 5   
   -   5        $ txtEmailOutput��5      $
��Left=�6*   $��324,117,0,0q�6E   $
	 Wrap=�6Z   $��TextBox��6n   $	��Top=�6}   $	��292��6�   ��6�   Z� �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��
97,374,0,0q�6L   $	��Top=�6`   $��32��6x   $��49��6�   $��Cascadia Code SemiBold)�6�   ���	#FF1A4D2E$��0,0,0,0q�6�   ���	#FFE8DFCA$ Click A Client��6  �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��154,374,0,0q�6P   $	��Top=�6e   $��32��6}   $��49��6�   $��Cascadia Code SemiBold)�6�   ���	#FF1A4D2E$��0,0,0,0q�6�   ���	#FFE8DFCA6   �� 5   
   -   5        $ lblClients_Copy��5      $��Information��6)   $
��Left=�6?   $��
369,10,0,0q�6Z   $	��Top=�6n   $��16(�6�   $
��Bold"�6�   $ 1.059,0.585&�6�   5      5      