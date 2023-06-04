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
    }
}
