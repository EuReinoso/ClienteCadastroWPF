   M S B A M L   `   `   `  ����M  IClienteCadastroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ClienteCadastroWPF.Forms.Integracao#ClienteCadastroWPF.Forms.Integracao  5   	   :    4ClienteCadastroWPF.Forms.Integracao.IntegracaoWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:ClienteCadastroWPF.Forms.Integracao     5   	     � Icon$  /Imagens/icon.ico��5   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Integração��5   	   $	��450��6   $
��460 ��6)   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� 
���   �$��1q�6%   ._�5      � $��0��6   ���	#FFD7FFD7.+�5      �� -   5        $��lblEnderecoApi��5      $��Enredeço da API��6.   $
��Left=�6H   $��15(�6c   $	��Top=�6q   $	��129��6�   $
��Bold"�6�   $��10,9,0,0q�6�   �� 5      -   5        $��txbEnderecoApi��5      $��15,41,157,0q�60   $	��Top=�6E   $��Center=�6]   $��15(�6    �� 	MaxLength$ 50��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5      -   5         ��Name$ btnSair��5      $��368,18,10,18q�6*   $��Impact)�6@   $��18(�6T   $��0q�6x    � Cursor$
 Hand��6�   ��5      �� 5       j� Stretch$ Uniform=�6%   	 �� ImageSource$	 /Imagens/sair.png��67   .��5      �� $��/Imagens/sair.png��6   5      5       5!      �� 5#   
   
���   �$��1q�6%   $��1��69   ._�5$      � $��1��6    5%      �� 5&      $	��220 �6$   �� 5'      $
��Auto �6$   .+�5*      �� -   5        $��
lblUsuario��5*      $��Usuário��6*   $��Center=�6<   $��Center=�6Y   $��15(�6}   $	��Top=�6�   $��72��6�   $
��Bold"�6�   $��32��6�   $��0,4,0,0q�6�   �� 5+      -   5        $��
txbUsuario��5+      $��144,36,144,0q�6,   $��Center=�6B   $	��Top=�6f   $��Center=�6~   $��15(�6�   $ 50��6�   $ 0.5,0.5&�6�   �� 5-      -   5        $��lblSenha��5-      $��Senha��6(   $��Center=�68   $��15(�6U   $	��Top=�6c   $��54��6{   $
��Bold"�6�   $��0,63,0,0q�6�   $��30��6�   �� 5.      -   5        $��txbSenha��5.      $��144,98,144,0q�6*   $��Center=�6@   $	��Top=�6d   $��Center=�6|   $��15(�6�   $ 50��6�   $ 0.5,0.5&�6�   �� 50      -   5        $ btnLogin��50      $��182,134,182,56q�6+   $��Login��6C   $��Impact)�6S   $��18(�6g   $ 0.5,0.5&�6�   �� 52      -	   5        $��lblLoginAviso��52      $�� ��6-   $��Center=�68   $��Center=�6\   $��15(�6y   $	��Top=�6�   $	��286��6�   $
��Bold"�6�   $��	0,180,0,0q�6�   �� 54      -
   5        $ 	btnBaixar��54      $��149,10,149,-36q�6,   $��Baixar Clientes��6D   $��Impact)�6^   $��18(�6r   $ 0.5,0.5&�6�   $��1��6�   ${�False��6�   �� 56      -   5        $��lblProgresso��56      $��1��6,   $��Center=�69   $��Center=�6[   $��12(�6   $��61,62,61,-57q�6�   � 57      -   5        
 �Name$
 pbProgresso��57      $y�Hidden=�63    � IsIndeterminate$
 True��6G   $��10��6^   $��1��6j   $��61,83,61,-82q�6w   58      59      5;      5<      