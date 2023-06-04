using ClienteCadastroWPF.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ClienteCadastroWPF.Models;

namespace ClienteCadastroWPF.Forms.Cliente
{

    public partial class ClienteMenuWindow : Window
    {
        private DB db = new();

        int? _clienteSelectionadoCodigo = new();

        public ClienteMenuWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;

        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroWindow window = new ClienteCadastroWindow();
            window.Show();

            this.Close();
        }
        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            _carregaClientes();
        }

        private void _carregaClientes()
        {
            var clientes = db.Cliente.Where(c => c.CLI_ATIVO == ckbAtivos.IsChecked).ToList();

            dgClientes.ItemsSource = clientes;
        }

        private void dgClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid? dg = sender as DataGrid;

            if (dg.SelectedItem != null)
            {
                var clienteSelecionado = dg.SelectedItem as ClienteModel;

                ClienteModel cliente = db.Cliente.Where(c => c.CLI_CODIGO == clienteSelecionado.CLI_CODIGO).First();

                ClienteCadastroWindow window = new ClienteCadastroWindow(cliente);

                window.Show();

                this.Close();
            }
        }

        private void dgClientes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DataGrid? dg = sender as DataGrid;

            if (dg.SelectedItem != null)
            {
                var clienteSelecionado = dg.SelectedItem as ClienteModel;

                _clienteSelectionadoCodigo = clienteSelecionado.CLI_CODIGO;
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (_clienteSelectionadoCodigo != null)
            {
                ClienteModel clienteExcluido = db.Cliente.Where(c => c.CLI_CODIGO == _clienteSelectionadoCodigo).First();

                clienteExcluido.CLI_ATIVO = false;

                db.Update(clienteExcluido);

                db.SaveChanges();

                _carregaClientes();
            }
        }
    }
}
