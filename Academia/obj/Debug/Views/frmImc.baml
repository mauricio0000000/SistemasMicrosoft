   M S B A M L   `   `   `  ����C  ?Academia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Academia.ViewsAcademia.Views  5   	       Academia.Views.frmImc   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Academia.Views     5   	   -   5          � Title$  Índice de Massa Corporal��5   	   $	��450��6*   $	��800��67    � WindowStartupLocation$ CenterScreen=�6C   .��5	      � .+�5
   
   �� -   5         ��Name$ lblPeso��5
      $
��Peso��6!   $
��Left=�60   $��	10,10,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $��txtPeso��5      $
��Left=�6!   $��23��6<   $��	10,36,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ 	lblAltura��5      $��Altura��6#   $
��Left=�64   $��	10,59,0,0q�6O   $	��Top=�6b   �� 5   
   -   5         ��Name$ 	txtAltura��5      $
��Left=�6%   $��23��6@   $��	10,85,0,0q�6L   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ txtKg��5      $
��Left=�6#   $��
135,43,0,0q�6>   $
��Wrap=�6R   $��kg��6f   $	��Top=�6p   �� 5   
   -   5        $ txtCm��5      $
��Left=�6#   $��
135,92,0,0q�6>   $
��Wrap=�6R   $��cm��6f   $	��Top=�6p   �� 5   
   -   5        $ txtImc��5      $��
246,59,0,0q�6$   $
��Wrap=�68   $��IMC= ��6L   $	��Top=�6Y   $��26��6q   $	��160��6}   $
��Left=�6�   $��20(�6�   �� 5   
   -	   5         ��Name$ btnCalcularImc��5      $��Calcular��6)   $
��Left=�6<   $��
33,124,0,0q�6W   $	��Top=�6k   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ cboImc��5      $��Center=�6#      AutoGenerateColumns .  $	��230��6\   $��	0,165,0,0q�6i   $	��Top=�6|   $	��750��6�   	   CanUserResizeColumns	 .  $��2q�6�   
   CanUserAddRows
 .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Peso��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *peso+6L     5      $ Altura��6@   $	 150 6P    6%   �� *altura+6P     5      $
 Data��6B   $	 150 6P    6%   �� *
criadoEm+6P     5      $	 Imc��6C   $	 150 6P    6%   �� *	imcResult+6P     5      $ 	Resultado��6C   $	 150 6V    6%   �� *	resultado+6V   5      5      5      