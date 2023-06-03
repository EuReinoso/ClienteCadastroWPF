using ClienteCadastroWPF.Data;
using ClienteCadastroWPF.Models;
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

namespace ClienteCadastroWPF.Forms.Cliente
{
    public partial class ClienteCadastroWindow : Window
    {
        private DB db =  new();

        private ClienteModel _cliente = new();

        private EnderecoModel _endereco = new();

        public ClienteCadastroWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {

            _endereco.END_CEP = Util.ApenasNumeros(txbCEP.Text);
            _endereco.END_ENDERECO = txbEndereco.Text;
            _endereco.END_NUMERO = txbNumero.Text;
            _endereco.END_BAIRRO = txbBairro.Text;
            _endereco.END_CIDADE = txbCidade.Text;

            db.Add(_endereco);
            db.SaveChanges();

            _cliente.CLI_CGC = Util.ApenasNumeros(txbCGC.Text);
            _cliente.CLI_NOME = txbNome.Text;
            _cliente.CLI_CELULAR = Util.ApenasNumeros(txbCelular.Text);
            _cliente.CLI_EMAIL = txbEmail.Text;
            _cliente.CLI_NASCIMENTO = dpNascimento.SelectedDate;
            _cliente.CLI_ENDERECO = _endereco.END_CODIGO;
            _cliente.CLI_CADASTRO = DateTime.UtcNow;
            _cliente.CLI_ATUALIZACAO = DateTime.UtcNow;

            if (cbbSexo.Text == "Masculino")
            {
                _cliente.CLI_SEXO = 'M';
            }
            else if (cbbSexo.Text == "Feminino")
            {
                _cliente.CLI_SEXO = 'F';
            }

            db.Add(_cliente);

            db.SaveChanges();

            ClienteCadastroWindow window = new();
            window.Show();

            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rdbFisica_Click(object sender, RoutedEventArgs e)
        {
            lblCGC.Content = "CPF";
            txbCGC.Text = "";
            txbCGC.Mask = "000 , 000 , 000 - 00";
        }

        private void rdbJuridica_Click(object sender, RoutedEventArgs e)
        {
            lblCGC.Content = "CNPJ";
            txbCGC.Text = "";
            txbCGC.Mask = "00 , 000 , 000 /0000-00";
        }

        private void txbCGC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_validaCGC())
                {
                    txbNome.Focus();
                }
            }
        }
        private void txbNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
               txbCelular.Focus();
            }
        }
        private void txbCelular_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbEmail.Focus();
            }
        }
        private void txbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                cbbSexo.Focus();
            }
        }

        private void cbbSexo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                dpNascimento.Focus();
            }
        }

        private void dpNascimento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbCEP.Focus();
            }
        }
        private void txbCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbEndereco.Focus();
            }
        }

        private void txbEndereco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbNumero.Focus();
            }
        }

        private void txbNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbBairro.Focus();
            }
        }
        private void txbBairro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txbCidade.Focus();
            }
        }

        private bool _validaCGC()
        {
            bool isValido = true;

            string mensagemValidacao = "";

            //verifica se o cpf é valido
            if (rdbFisica.IsChecked == true && !Util.IsCpfValido(txbCGC.Text))
            {
                mensagemValidacao = "CPF inválido!";
                isValido = false;
            }
            //verifica se o cnpj é valido
            else if (rdbJuridica.IsChecked == true && !Util.IsCnpjValido(txbCGC.Text))
            {
                mensagemValidacao = "CNPJ inválido!";
                isValido = false;
            }
            //Verifica se o CGC ja existe no banco de dados
            else if (db.Cliente.Where(c => c.CLI_CGC == Util.ApenasNumeros(txbCGC.Text)).FirstOrDefault() != null)
            {
                mensagemValidacao = "CPF/CNPJ ja existente!";
                isValido = false;
            }

            if (!isValido)
            {
                MessageBox.Show(mensagemValidacao, "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
                txbCGC.Foreground = Brushes.Red;
            }
            else
            {
                txbCGC.Foreground = Brushes.Black;
            }
            

            return isValido;
        }
    }

}
