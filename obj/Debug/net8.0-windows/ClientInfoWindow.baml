   M S B A M L   `   `   `  ����T  PDesignerClientApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DesignerClientApplicationDesignerClientApplication  5   	   0    *DesignerClientApplication.ClientInfoWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:DesignerClientApplication     5   	     � Title$  ClientInfoWindow��5   	   $	��450��6"   $	��300��6/   .��5	      � -   5         �Name$ grdClientInfo��5	      ���	#FFF5EFE6$��	0,0,-13,0q�69   .+�5
   
   �� -   5         ��Name$ lblTitle��5
      $��
Add Client��6"   $��Center=�67   $��0,10,0,0q�6T   $	��Top=�6f   $��Arial Black)�6~   $��20(�6�   ���	#FF1A4D2E6�   �� 5   
   -   5         ��Name$ txtFirstNameInput��5      $
��Left=�6-   $��	97,52,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��193��6�   $��23��6�   �� 5   
   -   5        $ lblFirstName��5      $��
First Name��6&   $
��Left=�6;   $��	10,51,0,0q�6V   $	��Top=�6i   $��Arial Black)�6�   �� 5   
   -   5        $ lblLastName��5      $��	Last Name��6%   $
��Left=�69   $��	10,81,0,0q�6T   $	��Top=�6g   $��Arial Black)�6   �� 5   
   -   5        $ txtLastNameInput��5      $
��Left=�6,   $��	97,83,0,0q�6G   $
 Wrap=�6Z   $	��Top=�6n   $	��194��6�   $��22��6�   �� 5   
   -   5        $ lblPhone��5      $��Phone��6"   $
��Left=�62   $��
10,130,0,0q�6M   $	��Top=�6a   $��Arial Black)�6y   �� 5   
   -   5        $ lblEmail��5      $��Email��6"   $
��Left=�62   $��
10,159,0,0q�6M   $	��Top=�6a   $��Arial Black)�6y   �� 5   
   -	   5        $ txtPhoneInput��5      $
��Left=�6)   $��
97,131,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��194��6�   $��23��6�   �� 5   
   -
   5        $ txtEmailInput��5      $
��Left=�6)   $��
97,161,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��194��6�   $��22��6�   �� 5   
   -   5        $ 	lblStreet��5      $��Street��6#   $
��Left=�64   $��
10,217,0,0q�6O   $	��Top=�6c   $��Arial Black)�6{   �� 5   
   -   5        $ lblCity��5      $��City                ��6!   $
��Left=�5      $��
10,246,0,0q�6-   $	��Top=�6A   $��Arial Black)�6Y   $��41��6r   �� 5   
   -   5        $ 
lblZipcode��5      $��Zipcode��6$   $
��Left=�66   $��
10,275,0,0q�6Q   $	��Top=�6e   $��Arial Black)�6}   �� 5   
   -   5        $ txtStreetInput��5      $
��Left=�6*   $��
97,219,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��193��6�   $��22��6�   �� 5   
   -   5        $ txtCityInput��5      $
��Left=�6(   $��
98,248,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��193��6�   $��22��6�   �� 5   
   -   5        $ txtZipInput��5      $
��Left=�6'   $��
98,277,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��192��6�   $��22��6�   �� 5   
   -   5         ��Name$ cmbState��5      $
��Left=�6%   $��
98,320,0,0q�6@   $	��Top=�6T   $	��192��6l   �� 5   
   -   5        $ lblState��5      $��State��6"   $
��Left=�62   $��
10,318,0,0q�6M   $	��Top=�6a   $��Arial Black)�6y   �� 5   
   -   5        $ lblFloorPlan��5      $��
Floor Plan��6&   $
��Left=�6;   $��
10,362,0,0q�6V   $	��Top=�6j   $��Arial Black)�6�   �� 5   
   -   5         ��Name$ btnFile��5      $��	Open File��6"   $
��Left=�66   $��216,364,0,0q�6Q   $	��Top=�6f   $��74��6~   ���	#FF1A4D2E���	#FFE8DFCA � ToolTip$, &We suggest a 450 * 600 pixel size jpeg��6�   �� 5   
   -   5        $ btnOk��5      $��Ok��6    $��Center=�6-   $��	0,404,0,0q�6J   $	��Top=�6]   $	��103��6u   ���	#FF1A4D2E���	#FFE8DFCA6�   �� 5   
   -   5        $ lblFileName��5      $�� ��6%   $��Center=�60   $��	0,362,0,0q�6M   $	��Top=�6`   $	��103��6x   5!      5"      