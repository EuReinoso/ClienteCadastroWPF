   M S B A M L   `   `   `  ���� M  IClienteCadastroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ClienteCadastroWPF.Forms.Integracao#ClienteCadastroWPF.Forms.Integracao  :    4ClienteCadastroWPF.Forms.Integracao.IntegracaoWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:ClienteCadastroWPF.Forms.Integracao       � Icon$  /Imagens/icon.ico�� � WindowStartupLocation$ CenterScreen=� � Title$ Integração��$	��450��$
��460 ��.��� 
������� � RowDefinitions �� $��80 ��� $��* �.+��� 
���   �$��1q�._�� $��0�����	#FFD7FFD7.+��� -   $��lblEnderecoApi��$��Enredeço da API��$
��Left=�$��15(�$	��Top=�$	��129��$
��Bold"�$��10,9,0,0q��� -   $��txbEnderecoApi��$��15,41,157,0q�$	��Top=�$��Center=�$��15(� �� 	MaxLength$ 50�� J� RenderTransformOrigin$ 0.5,0.5&��� -    ��Name$ btnSair��$��368,18,10,18q�$��Impact)�$��18(�$��0q� � Cursor$
 Hand������  j� Stretch$ Uniform=�	 �� ImageSource$	 /Imagens/sair.png��.���� $��/Imagens/sair.png���� 
���   �$��1q�$��1��._�� $��1�� �� $	��220 ��� $
��Auto �.+��� -   $��
lblUsuario��$��Usuário��$��Center=�$��Center=�$��15(�$	��Top=�$��72��$
��Bold"�$��32��$��0,4,0,0q��� -   $��
txbUsuario��$��144,36,144,0q�$��Center=�$	��Top=�$��Center=�$��15(�$ 50��$ 0.5,0.5&��� -   $��lblSenha��$��Senha��$��Center=�$��15(�$	��Top=�$��54��$
��Bold"�$��0,63,0,0q�$��30���� -   $��txbSenha��$��144,98,144,0q�$��Center=�$	��Top=�$��Center=�$��15(�$ 50��$ 0.5,0.5&��� -   $ btnLogin��$��182,134,182,56q�$��Login��$��Impact)�$��18(�$ 0.5,0.5&��� -	   $��lblLoginAviso��$�� ��$��Center=�$��Center=�$��15(�$	��Top=�$	��286��$
��Bold"�$��	0,180,0,0q��� -
   $ 	btnBaixar��$��149,10,149,-36q�$��Baixar Clientes��$��Impact)�$��18(�$ 0.5,0.5&�$��1��${�False���� -   $��lblProgresso��$��1��$��Center=�$��Center=�$��12(�$��61,62,61,-57q�� -   
 �Name$
 pbProgresso��$y�Hidden=� � IsIndeterminate$
 True��$��10��$��1��$��61,83,61,-82q�