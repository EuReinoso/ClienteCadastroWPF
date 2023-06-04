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
using ClienteCadastroWPF.Forms.Cliente;
using ClienteCadastroWPF.Forms.Integracao;

namespace ClienteCadastroWPF.Forms.Main
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            ClienteMenuWindow window = new ClienteMenuWindow();
            window.Show();
        }

        private void btnIntegracao_Click(object sender, RoutedEventArgs e)
        {
            IntegracaoWindow window = new IntegracaoWindow();
            window.Show();
        }
    }
}
