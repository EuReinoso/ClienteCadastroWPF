   M S B A M L   `   `   `  ���� M  IClienteCadastroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ClienteCadastroWPF.Forms.Cliente ClienteCadastroWPF.Forms.Cliente  8    2ClienteCadastroWPF.Forms.Cliente.ClienteMenuWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:ClienteCadastroWPF.Forms.Cliente       � WindowStartupLocation$  CenterScreen=� � Icon$ /Imagens/icon.ico�� � Title$ Clientes��$	��450��$	��800��.��� 
������� � RowDefinitions �� $��80 ��� $��* �.+��� 
���   �$��1q�._�� $��0�����	#FFD7FFD7.+��� -   $��	lblAtivos��$��Ativos��$
��Left=�$��15(�$	��Top=�$
��Bold"�$��	34,18,0,0q��� -   $��	ckbAtivos�� d� 	IsChecked$
 TrueY�$��13,27,746,21q��� -    ��Name$ btnSair��$��700,16,18,16q�$��Impact)�$��18(�$��0q� � Cursor$
 Hand������  j� Stretch$ Uniform=� �� ImageSource$ /Imagens/sair.png��.���� $��/Imagens/sair.png���� -   $ btnPesquisar��$��604,16,114,16q�$��Impact)�$��18(�$��0q����	#00707070���	#00000000$
 Hand������ $ Uniform=�$ /Imagens/lupa.png��.���� $��/Imagens/lupa.png���� -   $ 
btnExcluir��$��507,13,199,13q�$��Excluir��$��Impact)�$��18(��� -   $ 
btnIncluir��$��399,13,307,13q�$��Incluir��$��Impact)�$��18(��� 
���   �$��1q�$��1��._�� $��1�� �� $
��Auto �.+�&   System.Windows.Controls.DataGrid  -   $��
dgClientes��$��1��$	��340��	   AlternatingRowBackground	 �	#FFEDEDED$��15(�
   AutoGenerateColumns$
 False��   
IsReadOnly$
 True��   	RowHeight$ 25Q�   MaxColumnWidth$	 150Q�   CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserResizeRows$ False��   RowBackground �	#FFEEFFF8$	��771��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Código��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
CLI_CODIGO+  $ CPF/CNPJ�� �� *	CLI_CGC+  $
 Nome�� �� *
CLI_NOME+  $ Celular�� �� *CLI_CELULAR+  $ Email�� �� *	CLI_EMAIL+  $ Data Atualização�� �� *CLI_ATUALIZACAO+