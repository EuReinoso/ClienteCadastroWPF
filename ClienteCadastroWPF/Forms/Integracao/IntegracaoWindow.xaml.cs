using ClienteCadastroWPF.Api;
using ClienteCadastroWPF.Data;
using ClienteCadastroWPF.Forms.Main;
using ClienteCadastroWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace ClienteCadastroWPF.Forms.Integracao
{
    public partial class IntegracaoWindow : Window
    {
        PdvApi _api = new();

        DB db = new();

        public IntegracaoWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new();
            window.Show();

            this.Close();
        }

        private async void btnBaixar_Click(object sender, RoutedEventArgs e)
        {
            pbProgresso.Visibility = Visibility.Visible;

            lblLoginAviso.Content = "Baixando Dados...";

            var clientesData = await _api.GetClientes();

            int progressoTotal = clientesData.Count();

            int progressoAtual = 0;

            pbProgresso.IsIndeterminate = false;

            lblLoginAviso.Content = "Inserindo Dados no Banco...";

            foreach (var clienteDict in clientesData)
            {
                await _cadastraCliente(clienteDict);

                progressoAtual += 1;

                await _atualizarProgresso(progressoAtual, progressoTotal);

            }

            lblLoginAviso.Content = "Concluido.";
            MessageBox.Show("Todos os clientes clientes foram importados com sucesso!", "Importação Concluida", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private Task _atualizarProgresso(int progressoAtual, int progressoTotal)
        {
            return Dispatcher.InvokeAsync(() =>
            {
                lblProgresso.Content = $"{progressoAtual.ToString()} / {progressoTotal.ToString()}";
                pbProgresso.Value = progressoAtual / progressoTotal * 100;
            }).Task;
        }

        private Task _cadastraCliente(Dictionary<object, object> c)
        {
            return Dispatcher.InvokeAsync(() =>
            {

                EnderecoModel novoEndereco = new();

                db.Add(novoEndereco);
                db.SaveChanges();

                ClienteModel novoCliente = new();

                novoCliente.CLI_CODIGO_EXTERNO = c["Id"].ToString();
                novoCliente.CLI_CGC = Util.ApenasNumeros(c["CPFCNPJ"].ToString());
                novoCliente.CLI_NOME = c["Nome"].ToString();
                novoCliente.CLI_CELULAR = Util.ApenasNumeros(c["Celular"].ToString());
                novoCliente.CLI_ENDERECO = novoEndereco.END_CODIGO;

                //NASCIMENTO
                if (c.ContainsKey("DataNascimento"))
                {
                    novoCliente.CLI_NASCIMENTO = DateTime.Parse(c["DataNascimento"].ToString());
                }

                //EMAIL
                if (c["Email"].ToString().Length <= 50)
                {
                    novoCliente.CLI_EMAIL = c["Email"].ToString();
                }

                novoCliente.CLI_ATIVO = !bool.Parse(c["Inativo"].ToString());

                db.Add(novoCliente);
                db.SaveChanges();

            }).Task;
        }


        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            _api.Init(txbEnderecoApi.Text);


            if (await _api.Login(txbUsuario.Text, txbSenha.Text))
            {
                lblLoginAviso.Foreground = Brushes.Green;
                lblLoginAviso.Content = "Token gerado com Sucesso!";

                btnBaixar.IsEnabled = true;

                MessageBox.Show("Token gerado com Sucesso!", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                lblLoginAviso.Foreground = Brushes.Red;
                lblLoginAviso.Content = "Erro ao efetuar Login.";

                MessageBox.Show("Erro ao efetuar Login.", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

    }
}
