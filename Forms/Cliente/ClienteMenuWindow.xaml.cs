using ClienteCadastroWPF.Data;
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

    public partial class ClienteMenuWindow : Window
    {
        private DB db = new();

        public ClienteMenuWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;

            _carregaClientes();
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

        private void _carregaClientes()
        {
            var clientes = db.Cliente.Where(c => c.CLI_ATIVO == ckbAtivos.IsChecked).ToList();

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            dgClientes.ItemsSource = clientes;
        }
    }
}
