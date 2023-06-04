using System.Windows;
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

            this.Close();
        }
    }
}
