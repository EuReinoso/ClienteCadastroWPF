   M S B A M L   `   `   `  ����M  IClienteCadastroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ClienteCadastroWPF.Forms.Cliente ClienteCadastroWPF.Forms.Cliente  5   	   8    2ClienteCadastroWPF.Forms.Cliente.ClienteMenuWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:ClienteCadastroWPF.Forms.Cliente     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Icon$ /Imagens/icon.ico��5	   	    � Title$ Clientes��5
   	   $	��450��6   $	��800��6'   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� 
���   �$��1q�6%   ._�5      � $��0��6   ���	#FFD7FFD7.+�5      �� -   5        $��	lblAtivos��5      $��Ativos��6)   $
��Left=�6:   $��15(�6U   $	��Top=�6c   $
��Bold"�6{   $��	34,18,0,0q�6�   �� 5      -   5        $��	ckbAtivos��5       d� 	IsChecked$
 TrueY�6,   $��13,27,746,21q�6=   �� 5      -   5         ��Name$ btnSair��5      $��700,16,18,16q�6*   $��Impact)�6@   $��18(�6T   $��0q�6x    � Cursor$
 Hand��6�   ��5      �� 5       j� Stretch$ Uniform=�6%    �� ImageSource$ /Imagens/sair.png��67   .��5      �� $��/Imagens/sair.png��6   5      �� 5      -   5        $ btnPesquisar��5      $��604,16,114,16q�6/   $��Impact)�6F   $��18(�6Z   $��0q�6�   ���	#00707070���	#00000000$
 Hand��6�   ��5       �� 5!      $ Uniform=�6%   $ /Imagens/lupa.png��67   .��5#      �� $��/Imagens/lupa.png��6   5$      �� 5&      -   5        $ 
btnExcluir��5&      $��507,13,199,13q�6-   $��Excluir��6D   $��Impact)�6V   $��18(�6j   6x   �� 5'      -   5        $ 
btnIncluir��5'      $��399,13,307,13q�6-   $��Incluir��6D   $��Impact)�6V   $��18(�6j   6x   5(      5)      �� 5+   
   
���   �$��1q�6%   $��1��69   ._�5,      � $��1��6    5-      �� 5.      $
��Auto �6$   .+�51      &   System.Windows.Controls.DataGrid  -   5        $��
dgClientes��51      $��1��6-   $	��340��6:   	   AlternatingRowBackground	 �	#FFEDEDED$��15(�6l   
   AutoGenerateColumns$
 False��6z      
IsReadOnly$
 True��6�      	RowHeight$ 25Q�6�      MaxColumnWidth$	 150Q�6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6�      CanUserResizeRows$ False��6�      RowBackground �	#FFEEFFF8$	��771��6}     Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Código��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
CLI_CODIGO+  54      $ CPF/CNPJ��6-    6?   �� *	CLI_CGC+  55      $
 Nome��6-    6;   �� *
CLI_NOME+  56      $ Celular��6-    6>   �� *CLI_CELULAR+  57      $ Email��6-    6<   �� *	CLI_EMAIL+  58      $ Data Atualização��6-    6G   �� *CLI_ATUALIZACAO+5:      5;      5<      5>      5?      