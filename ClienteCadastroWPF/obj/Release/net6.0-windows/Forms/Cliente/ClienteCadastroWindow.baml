   M S B A M L   `   `   `  ���� M  IClienteCadastroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ClienteCadastroWPF.Forms.Cliente ClienteCadastroWPF.Forms.Cliente  <    6ClienteCadastroWPF.Forms.Cliente.ClienteCadastroWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  :local.clr-namespace:ClienteCadastroWPF.Forms.Cliente    � WindowStartupLocation$  CenterScreen=� � Icon$ /Imagens/icon.ico�� � Title$ Cliente Cadastro��$	��450��$	��800��.��� 
������� � RowDefinitions �� $��80 ��� $��* �.+��� 
���   �$��1q�._�� $��0�����	#FFD7FFD7.+��� -    ��Name$ btnSair��$��700,16,18,16q�$��Impact)�$��18(�$��0q�����  j� Stretch$
 None=� �� ImageSource$ /Imagens/sair.png��.���� $��/Imagens/sair.png���� -   $ btnConfirmar��$��589,13,100,13q�$��	Confirmar��$��Impact)�$��18(��� -   $��ckbAtivo��$��Ativo��$��15(�$
��Bold"� d� 	IsChecked$
 TrueY�$��483,16,237,39q��� $��29,16,640,4q� J� RenderTransformOrigin$ 0.495,0.481&�.+�	� -   	 	�Name$	 	rdbFisica��$��Física��$��15(�$	��177��$
��Bold"�$
 TrueY�	� -   $	 rdbJuridica��$��	Jurídica��$��15(�$	��177��$
��Bold"�$��20���� 
���   �$��1q�$��1��._�� $��1�� �� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $
��Auto �.+��� -   $��lblCGC��$	��CPF��$
��Left=�$��15(�$��	36,0,0,30q�$	��Top=�$	��101��$
��Bold"�%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��txbCGC��
   Mask$
 000 , 000 , 000 - 00��$	��Top=�$��Center=�$��36,32,576,0q�$��15(��� -   $��lblNome��$
��Nome��$
��Left=�$��15(�$	��Top=�$��
247,0,0,30q�$	��101��$
��Bold"��� -	   $��txbNome��$��247,30,226,5q�$��Center=�$��Center=�$��15(� �� 	MaxLength$ 50���� -
    ��Name$ 
lblCelular��$��Celular��$
��Left=�$��15(�$	��Top=�$	��102��$
��Bold"�$��36,0,0,0q�$��1��  -     Name$ 
txbCelular��$
 (00) 0 0000-0000��$��Center=�$��36,30,630,0q�$��Center=�$��15(�$��1���� -   $ lblEmail��$��Email��$
��Left=�$	��Top=�$��15(�$��	247,0,0,0q�$	��101��$
��Bold"�$��1���� -    ��Name$ txbEmail��$��247,30,226,0q�$��15(�$��Center=�$��Center=�$��1��$ 50���� -   $ lblSexo��$
��Sexo��$
��Left=�$��15(�$	��Top=�$��36,0,0,0q�$	��102��$
��Bold"�$��2��$��30���� -   $��cbbSexo��$��36,30,618,0q�$��2��$��13(�$	��Top=�$��Center=�.@��� $��	Masculino��$��13(�$��Center=�$��Center=��� $��Feminino��$��13(�$��Center=�$��Center=��� -   $ lblNascimento��$��Data Nascimento��$
��Left=�$	��Top=�$��15(�$��	247,0,0,0q�$	��134��$
��Bold"�$��2��(  "System.Windows.Controls.DatePicker  -   $��dpNascimento��$��15(�$	��Top=�$��Center=�$��2��$��247,30,390,0q��� -   $ lblCEP��$	��CEP��$
��Left=�$	��Top=�$��15(�$��36,0,0,0q�$	��101��$
��Bold"�$��3��  -   $ txbCEP��$
 00000 - 000��$	��Top=�$��36,35,644,0q�$��Center=�$��15(�$��3���� -   $ lblEndereco��$��Endereco��$
��Left=�$	��Top=�$��15(�$��	247,0,0,0q�$	��101��$
��Bold"�$��3���� -   $ txbEndereco��$��247,35,226,0q�$��15(�$	��Top=�$��Center=�$��3��$ 70���� -   $ 	lblNumero��$��Numero��$
��Left=�$	��Top=�$��15(�$��	605,0,0,0q�$	��101��$
��Bold"�$��3���� -   $ 	txbNumero��$��605,35,108,0q�$��15(�$	��Top=�$��Center=�$��3��$ 5���� -   $ 	lblBairro��$��Bairro��$
��Left=�$	��Top=�$��15(�$��36,2,0,0q�$	��101��$
��Bold"�$��4���� -   $ 	txbBairro��$��36,32,605,0q�$��15(�$	��Top=�$��Center=�$��4��$ 40���� -   $ 	lblCidade��$��Cidade��$
��Left=�$	��Top=�$��15(�$��	247,0,0,0q�$	��101��$
��Bold"�$��4���� -   $ 	txbCidade��$��247,32,308,0q�$��15(�$	��Top=�$��Center=�$ 50��$��4��