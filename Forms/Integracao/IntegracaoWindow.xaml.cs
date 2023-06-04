using ClienteCadastroWPF.Api;
using ClienteCadastroWPF.Data;
using ClienteCadastroWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClienteCadastroWPF.Forms.Integracao
{
    public partial class IntegracaoWindow : Window
    {
        PdvApi _api = new();

        public IntegracaoWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBaixar_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            _api.Init(txbEnderecoApi.Text);


            if (await _api.Login(txbUsuario.Text, txbSenha.Text))
            {
                lblLoginAviso.Foreground = Brushes.Green;
                lblLoginAviso.Content = "Token gerado com Sucesso!";

                MessageBox.Show("Token gerado com Sucesso!", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                lblLoginAviso.Foreground = Brushes.Red;
                lblLoginAviso.Content = "Erro ao efetuar Login.";

                MessageBox.Show("Erro ao efetuar Login.", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

    }
}
